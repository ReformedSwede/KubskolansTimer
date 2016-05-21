using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Timer
{
    public partial class Form1 : Form
    {
        /****************************************************
         *                                                  *
         *           Global variables & objects             *
         *                                                  *
         *                                                  *     
         * ***************************************************/
          
        Random rand = new Random(); // a random number generator.
        Stopwatch stopWatch = new Stopwatch(); // the timer
        Session session = new Session(); //The list that stores all information about the session (times, scrambles, penalties, stats...)
        Scrambler scrambler = new Scrambler();

        /*********************Numbers******************************/
        int index = -1; // Indicates what index (in the session list) the last made solve had. Is incremented when new solve is started => First solve has index 0, no solve has index -1.
        int count = 0; // This is used in the scramble generator. Makes sure the scramble is at the appropriate length. 
        int numberOfDNFs = 0;
        decimal inspectiontime = 15;
        float WorstTime = float.MinValue;   //The current best and worst times. Since this info is also in the class, it might be possible to remove these...
        float BestTime = float.MaxValue;    //... ,change some things and still have it work.

        /*********************Booleans***************************/
        bool timerStart = true; // Determines wether spacebar starts or stops timer
        bool manualAdd = false; // Determines weather in manual adding mode or not. 
        bool inspect = false;

        /*********************Other*******************************/
        string penalty = ""; // Is used to send info about penalty from inspection to the finished Solve object

        //Constuctor
        public Form1()
        {
            InitializeComponent();
            buttonTimer.Focus();
            comboBox1.SelectedIndex = 1;
            labelScramble.Text = Scramble();
            buttonAdd.BringToFront();
            labelLast.Text = "Last scramble:";
            MessageBox.Show("This application is still in beta. Please report all bugs found.");
        }

        /****************************************************
         *                                                  *
         *                Timer functions                   *
         *                                                  *
         *                                                  *     
         * ***************************************************/
         
        private void buttonTimer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                buttonResetPenalty.Enabled = true;
                buttonPlus2.Enabled = true;
                buttonDNF.Enabled = true;

                if (inspect == true)
                {
                    buttonTimer.BackColor = Color.Green;
                    labelTimer.BackColor = Color.Green;
                    stopWatch.Reset();
                    stopWatch.Start();
                    timer2.Start();
                    inspect = false;
                }
                else
                    if (timerStart == true)
                    {
                        if (stopWatch.IsRunning)
                        {
                            stopWatch.Stop();
                            timer2.Stop();
                        }
                        buttonTimer.BackColor = Color.Red;
                        labelTimer.BackColor = Color.Red;
                        timerStart = false;
                        index++;
                        stopWatch.Reset();

                        timer1.Start();
                        stopWatch.Start();
                    }
                    else
                    {
                        stopWatch.Stop();

                        timer1.Stop();
                        timerStart = true;
                        Solve solve = new Solve();
                        session.Add(solve);
                        solve.penalty = penalty;
                        penalty = "";   //reset for next solve

                        switch (solve.penalty) // adds the time to the session list & displays it, all according to the penalty. 
                        {
                            case "":
                                solve.time = (float)Math.Round(stopWatch.Elapsed.TotalSeconds, 2);

                                if (solve.time < 60) // Switches between displaying 0,00 and 0:00,00
                                    labelTimer.Text = solve.time.ToString();
                                else
                                    labelTimer.Text = secondsToMinutes(solve.time);
                                break;

                            case "+2":
                                solve.time = (float)Math.Round(stopWatch.Elapsed.TotalSeconds + 2, 2);

                                if (solve.time < 60)
                                    labelTimer.Text = solve.time.ToString() + "+";
                                else
                                    labelTimer.Text = secondsToMinutes(solve.time) + "+";
                                break;

                            case "DNF":
                                solve.time = (float)Math.Round(stopWatch.Elapsed.TotalSeconds, 2);

                                labelTimer.Text = "DNF";
                                break;
                        }


                        if (solve.time < BestTime)
                            BestTime = solve.time;
                        if (solve.time > WorstTime)
                            WorstTime = solve.time;

                        solve.bestTime = BestTime;  //used when recalling, e.g. when clearing the last solve
                        solve.worstTime = WorstTime;

                        if (session.Count < 5)
                            solve.bestFive = float.MaxValue;
                        if (session.Count < 12)
                            solve.bestTwelve = float.MaxValue;


                        buttonTimer.BackColor = Color.WhiteSmoke;
                        labelTimer.BackColor = Color.WhiteSmoke;

                        solve.scramble = labelScramble.Text;
                        labelLast.Text = "Last scramble: " + solve.scramble;
                        labelScramble.Text = Scramble();
                        if (solve.penalty != "")
                        {
                            buttonPlus2.Enabled = false;
                            buttonDNF.Enabled = false;
                        }

                        displaySession();
                        if (checkBoxInspect.Checked) // bool inspect has to be restored. 
                            inspect = true;
                    }
            }
        }
             
        private void timer1_Tick(object sender, EventArgs e) //used during solve
        {
            if (Math.Round(stopWatch.Elapsed.TotalSeconds, 2) < 60)
                labelTimer.Text = Math.Round(stopWatch.Elapsed.TotalSeconds, 2).ToString();
            else
                labelTimer.Text = secondsToMinutes((float)Math.Round(stopWatch.Elapsed.TotalSeconds, 2));
        }

        private void timer2_Tick(object sender, EventArgs e)  // Used during inspection
        {
            if (stopWatch.Elapsed.Seconds < inspectiontime) //if time < 15 
            {
                labelTimer.Text = (inspectiontime - stopWatch.Elapsed.Seconds).ToString();
            }
            else
            {
                if (stopWatch.Elapsed.Seconds < inspectiontime + 2) //if 15 < time < 17
                {
                    labelTimer.Text = "+2";
                    penalty = "+2";
                }
                else //if time > 17
                {
                    stopWatch.Stop();
                    timer2.Stop();
                    labelTimer.Text = "DNF";
                    penalty = "DNF";
                    numberOfDNFs++;
                }
            }
        }

        private void buttonClearLast_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {
                if (session[index].penalty == "DNF")
                    numberOfDNFs--;

                session.Remove(index);    //Removes all data from last solve

                if (index >= 1)
                    labelLast.Text = "Last scramble: " + session[index - 1].scramble;
                else
                    labelLast.Text = "Last scramble: ";

                if (index >= 1)
                {
                    BestTime = session[index - 1].bestTime;
                    WorstTime = session[index - 1].worstTime;
                }
                else
                {
                    BestTime = float.MaxValue;
                    WorstTime = float.MinValue;
                }

                index--;
                if (index == -1)
                    labelTimer.Text = "0:00,00";
                else
                {
                    if (session[index].time < 60)
                        if (session[index].penalty != "DNF")
                            labelTimer.Text = session[index].time.ToString();
                        else
                            labelTimer.Text = "DNF (" + session[index].time.ToString() + ")";
                    else
                        if (session[index].penalty != "DNF")
                            labelTimer.Text = secondsToMinutes(session[index].time);
                        else
                            labelTimer.Text = "DNF (" + secondsToMinutes(session[index].time) + ")";
                }

                displaySession();
            }
            else
                MessageBox.Show("Error. Can not remove solve data, index too low.");

            buttonTimer.Focus();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            session.Clear();    //clears EVERYTHING!!!

            WorstTime = float.MinValue;
            BestTime = float.MaxValue;
            numberOfDNFs = 0;

            index = -1;
            labelTimer.Text = "0:00,00";
            displaySession();
            buttonTimer.Focus();
            labelLast.Text = "Last scramble:";
            labelScramble.Text = Scramble();
        }

        private void buttonReplay_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {
                labelScramble.Text = session[index].scramble;

                if (index >= 1)
                    labelLast.Text = "Last scramble: " + session[index - 1].scramble;
                else
                    labelLast.Text = "Last scramble: ";

                if (session[index].penalty == "DNF")
                    numberOfDNFs--;

                session.Remove(index); //Removes data from last solve

                if (index >= 1)
                {
                    BestTime = session[index - 1].bestTime;
                    WorstTime = session[index - 1].worstTime;
                }
                else
                {
                    BestTime = float.MaxValue;
                    WorstTime = float.MinValue;
                }

                index--;
                if (session.Count > 1)
                    labelTimer.Text = session[index].time.ToString();
                else
                    labelTimer.Text = "0:00,00";
                displaySession();
            }
            else
                MessageBox.Show("Error. Can not remove solve data, index too low.");
            buttonTimer.Focus();
        }
        
        private void textBoxAdd2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Solve solve = new Solve();
                session.Add(solve);
                solve.penalty = "";

                try
                {
                    if (textBoxAdd1.Text == "") // if no minutes
                    {
                        solve.time = float.Parse(textBoxAdd2.Text);
                        labelTimer.Text = Math.Round(solve.time, 2).ToString();
                    }
                    else                        //if minutes
                    {
                        solve.time = int.Parse(textBoxAdd1.Text) * 60 + float.Parse(textBoxAdd2.Text);
                        labelTimer.Text = secondsToMinutes(solve.time);
                    }

                    solve.scramble = labelScramble.Text;
                    labelLast.Text = "Last scramble: " + solve.scramble;
                    labelScramble.Text = Scramble();

                    index++;

                    if (solve.time < BestTime)
                        BestTime = solve.time;
                    if (solve.time > WorstTime)
                        WorstTime = solve.time;

                    solve.bestTime = BestTime;  //used when recalling, e.g. when clearing the last solve
                    solve.worstTime = WorstTime;

                    if (session.Count < 5)
                        solve.bestFive = float.MaxValue;
                    if (session.Count < 12)
                        solve.bestTwelve = float.MaxValue;

                    displaySession();
                }
                catch
                {
                    MessageBox.Show("Error! Input time was in wrong format.");
                    labelTimer.Text = "0:00,00";
                }
                textBoxAdd1.Text = "";
                textBoxAdd2.Text = "";
            }
        }
        
        private void buttonPlus2_Click(object sender, EventArgs e)
        {
            if (session.Count > 0)
            {
                if (session[index].time == session[index].bestTime) //if the time that got penalty was the best...
                {
                    if (index >= 1)
                    {
                        session[index].bestTime = session[index - 1].bestTime;
                        BestTime = session[index - 1].bestTime;
                    }
                    else
                    {
                        session[index].bestTime += 2;
                        BestTime += 2;
                    }
                }
                if (session[index].time == session[index].worstTime) //if the time that got penalty was the worst...
                {
                    session[index].worstTime += 2;
                    WorstTime += 2;
                }

                session[index].penalty = "+2";
                session[index].time += 2;

                if (session[index].time < 60)
                    labelTimer.Text = session[index].time.ToString() + "+";
                else
                    labelTimer.Text = secondsToMinutes(session[index].time) + "+";

                displaySession();
                buttonPlus2.Enabled = false;
                buttonDNF.Enabled = false;
            }
            else
                MessageBox.Show("Error. No solve has been made.");

            buttonTimer.Focus();
        }

        private void buttonDNF_Click(object sender, EventArgs e)
        {
            if (session.Count > 0)
            {
                session[index].penalty = "DNF";
                labelTimer.Text = "DNF";
                numberOfDNFs++;

                if (session[index].time == WorstTime)
                {
                    if (index > 0)
                        WorstTime = session[index - 1].worstTime;
                    else
                        WorstTime = float.MinValue;
                    session[index].worstTime = WorstTime;
                }
                if (session[index].time == BestTime)
                {
                    if (index > 0)
                        BestTime = session[index - 1].bestTime;
                    else
                        BestTime = float.MaxValue;
                    session[index].bestTime = BestTime;
                }

                displaySession();
                buttonPlus2.Enabled = false;
                buttonDNF.Enabled = false;
            }
            else
                MessageBox.Show("Error. No solve has been made.");

            buttonTimer.Focus();
        }

        private void buttonResetPenalty_Click(object sender, EventArgs e)
        {
            if (session.Count > 0)
            {
                if (session[index].penalty == "+2")
                {
                    if (session[index].time == BestTime)
                    {
                        session[index].bestTime -= 2;
                        BestTime -= 2;
                    }
                    if (session[index].time == WorstTime)
                    {
                        WorstTime -= 2;
                        session[index].worstTime -= 2;
                    }

                    session[index].time -= 2;
                }

                if (session[index].penalty == "DNF")
                {

                    if (session[index].time < BestTime)
                    {
                        BestTime = session[index].time;
                        session[index].bestTime = BestTime;
                    }
                    if (session[index].time > WorstTime)
                    {
                        WorstTime = session[index].time;
                        session[index].worstTime = session[index].time;
                    }
                    numberOfDNFs--;
                }

                session[index].penalty = "";

                if (session[index].time < 60)
                    labelTimer.Text = session[index].time.ToString();
                else
                    labelTimer.Text = secondsToMinutes(session[index].time);

                displaySession();
                buttonPlus2.Enabled = true;
                buttonDNF.Enabled = true;
            }
            else
                MessageBox.Show("Error. No solve has benn made.");

            buttonTimer.Focus();
        }

        private void displaySession()
        {
            // ---------------------------------------------------------------Displays all times in textbox.
            textBox1.Text = "";
            foreach (Solve solve in session.Solves)
            {
                if (solve.penalty == "DNF")
                    textBox1.Text += "DNF(" + solve.time + ")";
                else
                {
                    if (solve.time < 60)
                        textBox1.Text += solve.time.ToString();
                    else
                        textBox1.Text += secondsToMinutes(solve.time);

                    if (solve.penalty == "+2")
                        textBox1.Text += "+";
                }
                textBox1.Text += "   ";
            }

            // ---------------------------------------------------------------Displays number of solves. 
            labelCount.Text = "Number of solves: " + session.Count.ToString();

            //----------------------------------------------------------------Calculates and displays total avg in seconds.
            if (session.Count > 0 && (session.Count - numberOfDNFs) >= 3)
            {
                float totalSum = 0;
                foreach (Solve solve in session.Solves)
                {
                    if (solve.penalty == "DNF")
                        totalSum += WorstTime;
                    else
                        totalSum += solve.time;
                }
                if (Math.Round((totalSum / session.Count), 2) < 60)
                    labelAvg.Text = "Session avg: " + Math.Round((totalSum / session.Count), 2).ToString();
                else
                    labelAvg.Text = "Session avg: " + secondsToMinutes((float)Math.Round((totalSum / session.Count), 2));
            }
            else
                labelAvg.Text = "Session avg: DNF";

            // ----------------------------------------------------------------Calculates and displays average of 5
            float sumOf5 = 0;                                                  //sum of all 5 times
            if (session.Count >= 5)                                            //only works when we have more than 5 times in the session
            {
                int n = -1;                                                    //used in the foreach() loop
                Solve[] average5 = new Solve[5];
                average5 = session.GetRange(session.Count - 5, 5).ToArray<Solve>();
                average5 = bubbleSortSolve(average5);                               //an array with all five times, sorted in ascending order. 

                foreach (Solve solve in average5)                               //Här finns en Bug! Om en tid, vilken som helst, matchar största eller minsta värdet räknas den inte med. 
                {
                    n++;
                    if (n != 0 && n != 4)                                      //leave out smallest and largest times 
                        if (solve.penalty == "DNF")
                            sumOf5 += WorstTime;
                        else
                            sumOf5 += solve.time;
                }

                if (Math.Round(sumOf5 / 3, 2) < 60)                             //calculate average and print
                    label5.Text = "Average of 5 (3): " + Math.Round(sumOf5 / 3, 2).ToString();
                else
                    label5.Text = "Average of 5 (3): " + secondsToMinutes((float)Math.Round(sumOf5 / 3, 2));
            }
            else
                label5.Text = "Average of 5 (3): DNF";

            //------------------------------------------------------------------Calculates and displays best average of 5
            if (session.Count >= 5)
            {
                if (Math.Round(sumOf5 / 3, 2) < session[index - 1].bestFive)
                {
                    session[index].bestFive = (float)Math.Round(sumOf5 / 3, 2);

                    if (Math.Round(sumOf5 / 3, 2) < 60)
                        labelB5.Text = "Best average of 5: " + Math.Round(sumOf5 / 3, 2).ToString();
                    else
                        labelB5.Text = "Best average of 5: " + secondsToMinutes((float)Math.Round(sumOf5 / 3, 2));
                }
                else
                {
                    session[index].bestFive = session[index - 1].bestFive;

                    if (Math.Round(sumOf5 / 3, 2) < 60)
                        labelB5.Text = "Best average of 5: " + session[index].bestFive.ToString();
                    else
                        labelB5.Text = "Best average of 5: " + secondsToMinutes((float)session[index].bestFive);
                }
            }
            else
                labelB5.Text = "Best average of 5: DNF";

            // -----------------------------------------------------------------Calculates and displays average of 12
            float sumOf12 = 0;
            if (session.Count >= 12)
            {
                int n = -1;
                Solve[] average12 = new Solve[12];
                average12 = session.GetRange(session.Count - 12, 12).ToArray<Solve>();
                average12 = bubbleSortSolve(average12);

                foreach (Solve solve in average12)
                {
                    n++;
                    if (n != 0 && n != 11)
                        if (solve.penalty == "DNF")
                            sumOf12 += WorstTime;
                        else
                            sumOf12 += solve.time;
                }
                if (Math.Round(sumOf12 / 10, 2) < 60)
                    label12.Text = "Average of 12 (10): " + Math.Round(sumOf12 / 10, 2).ToString();
                else
                    label12.Text = "Average of 12 (10): " + secondsToMinutes((float)Math.Round(sumOf12 / 10, 2));
            }
            else
                label12.Text = "Average of 12 (10): DNF";

            //------------------------------------------------------------------Calculates and displays best average of 12
            if (session.Count >= 12)
            {
                if (Math.Round(sumOf12 / 10, 2) < session[index - 1].bestTwelve)
                {
                    session[index].bestTwelve = (float)Math.Round(sumOf12 / 10, 2);

                    if (Math.Round(sumOf12 / 10, 2) < 60)
                        labelB12.Text = "Best average of 12: " + Math.Round(sumOf12 / 10, 2).ToString();
                    else
                        labelB12.Text = "Best average of 12: " + secondsToMinutes((float)Math.Round(sumOf12 / 10, 2));
                }
                else
                {
                    session[index].bestTwelve = session[index - 1].bestTwelve;

                    if (Math.Round(sumOf12 / 10, 2) < 60)
                        labelB12.Text = "Best average of 12: " + session[index].bestTwelve.ToString();
                    else
                        labelB12.Text = "Best average of 12: " + secondsToMinutes(session[index].bestTwelve);
                }
            }
            else
                labelB12.Text = "Best average of 12: DNF";

            // -----------------------------------------------------------------Calculates and displays average of 100
            float sumOf100 = 0;
            if (session.Count >= 100)
            {
                int n = -1;
                Solve[] average100 = new Solve[100];
                average100 = session.GetRange(session.Count - 100, 100).ToArray<Solve>();
                average100 = bubbleSortSolve(average100);

                foreach (Solve solve in average100)
                {
                    n++;
                    if (n != 0 || n != 99)
                        if (solve.penalty == "DNF")
                            sumOf100 += WorstTime;
                        else
                            sumOf100 += solve.time;
                }
                if (Math.Round(sumOf100 / 98, 2) < 60)
                    label100.Text = "Average of 100 (98): " + Math.Round(sumOf100 / 98, 2).ToString();
                else label100.Text = "Average of 100 (98): " + secondsToMinutes((float)Math.Round(sumOf100 / 98, 2));
            }
            else
                label100.Text = "Average of 100 (98): DNF";

            // -----------------------------------------------------------------Displays best and worst times
            if (session.Count > 0 && numberOfDNFs != session.Count)
            {
                if (BestTime < 60)
                    labelBest.Text = "Best time: " + BestTime;
                else
                    labelBest.Text = "Best time: " + secondsToMinutes(BestTime);

                if (WorstTime < 60)
                    labelWorst.Text = "Worst time: " + WorstTime;
                else
                    labelWorst.Text = "Worst time: " + secondsToMinutes(WorstTime);
            }
            else
            {
                labelBest.Text = "Best time: DNF";
                labelWorst.Text = "Worst time: DNF";
            }
        }

        /****************************************************
         *                                                  *
         *              Interface functions                 *
         *                                                  *
         *                                                  *     
         * ***************************************************/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLast.Text = "Last scramble: " + labelScramble.Text;
            labelScramble.Text = Scramble();
            buttonTimer.Focus();
        }

        private void copyAllTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void copyLastScrambleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(session[index].scramble);
        }

        private void copySessionAvgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelAvg.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelScramble.Text = Scramble();
            buttonTimer.Focus();
        }    
      
        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (manualAdd == true)
            {
                manualAdd = false;
                buttonAdd.Size = new Size(421, 52);
                buttonAdd.Font = new Font("Microsoft Sans Serif", 15);
                buttonAdd.Text = "Click to add times manually";
                buttonTimer.Focus();
            }
            else
            {
                manualAdd = true;
                buttonAdd.Size = new Size(180, 25);
                buttonAdd.Text = "Click to add times with spacebar";
                buttonAdd.Font = DefaultFont;
                buttonTimer.Focus();
                textBoxAdd1.Text = "";
                textBoxAdd2.Text = "";
            }
        }

        private void checkBoxInspect_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInspect.Checked == true)
            {
                numericUpDown1.Enabled = true;
                inspect = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
                inspect = false;
            }
            buttonTimer.Focus();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            inspectiontime = numericUpDown1.Value;
            buttonTimer.Focus();
        }

        /****************************************************
        *                                                  *
        *              Utility functions                   *
        *                                                  *
        *                                                  *     
        * ***************************************************/

        private string secondsToMinutes(float seconds)
        {
            if (seconds < 60)
            {
                MessageBox.Show("Time is not higher than 60! Time sent: " + seconds);
                return seconds.ToString();
            }

            int minutes = 0;
            while (seconds >= 60)
            {
                seconds -= 60;
                minutes++;
            }

            if (seconds >= 10)
                return minutes.ToString() + ":" + Math.Round(seconds, 2).ToString();
            else
                return minutes.ToString() + ":0" + Math.Round(seconds, 2).ToString();
        }

        private float[] bubbleSort(float[] array)
        {
            float memory = 0;
            bool madeChange = true;

            while (madeChange == true)
            {
                madeChange = false;
                for (int i = 0; i < array.Length -1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        memory = array[i];
                        array[i] = array[i+1];
                        array[i+1] = memory;
                        madeChange = true;
                    }                        
                }
            }
            return array;
        }

        private Solve[] bubbleSortSolve(Solve[] array)
        {
            Solve tmp = new Solve();    //temporary Sovle object
            tmp.time = 0;

            bool madeChange = true;

            while (madeChange == true)  //continue sorting until finished, i.e. no change is made
            {
                madeChange = false;
                for (int i = 0; i < array.Length - 1; i++)  //go through each element in the array
                {
                    if (array[i].time > array[i + 1].time)  //move if necessary
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        madeChange = true;
                    }
                }
            }
            return array;
        }

        private string Scramble()
        {
            string puzzleType = comboBox1.SelectedItem?.ToString();
            if(puzzleType == null)
            {
                comboBox1.SelectedIndex = 1;
                comboBox1.Text = puzzleType = "3x3";
                buttonTimer.Focus();  
            }
            return scrambler.Scramble(puzzleType);
        }
    }
}
