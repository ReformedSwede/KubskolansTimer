namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClearLast = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.labelScramble = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelAvg = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelB12 = new System.Windows.Forms.Label();
            this.labelB5 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.labelWorst = new System.Windows.Forms.Label();
            this.labelBest = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAdd1 = new System.Windows.Forms.Label();
            this.textBoxAdd2 = new System.Windows.Forms.TextBox();
            this.labelAdd2 = new System.Windows.Forms.Label();
            this.labelAdd3 = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.checkBoxInspect = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelInspect = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInspectionTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLastScrambleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySessionAvgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ifStartingTheTimerWithSpacebarDeosntWorkClickOnTheTextPressSpacebarToStartAndStopTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPlus2 = new System.Windows.Forms.Button();
            this.buttonDNF = new System.Windows.Forms.Button();
            this.buttonResetPenalty = new System.Windows.Forms.Button();
            this.buttonReplay = new System.Windows.Forms.Button();
            this.buttonScramble = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTimer
            // 
            this.buttonTimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTimer.FlatAppearance.BorderSize = 0;
            this.buttonTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimer.Location = new System.Drawing.Point(12, 29);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(576, 217);
            this.buttonTimer.TabIndex = 0;
            this.buttonTimer.Text = "Press spacebar to start and stop timer";
            this.buttonTimer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonTimer.UseVisualStyleBackColor = false;
            this.buttonTimer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonTimer_KeyUp);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTimer.Font = new System.Drawing.Font("Arial", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(22, 62);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(458, 134);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "0:00,00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(635, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(421, 311);
            this.textBox1.TabIndex = 3;
            // 
            // buttonClearLast
            // 
            this.buttonClearLast.Location = new System.Drawing.Point(1062, 382);
            this.buttonClearLast.Name = "buttonClearLast";
            this.buttonClearLast.Size = new System.Drawing.Size(93, 23);
            this.buttonClearLast.TabIndex = 4;
            this.buttonClearLast.Text = "Clear last time";
            this.buttonClearLast.UseVisualStyleBackColor = true;
            this.buttonClearLast.Click += new System.EventHandler(this.buttonClearLast_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(1062, 413);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(160, 23);
            this.buttonClearAll.TabIndex = 5;
            this.buttonClearAll.Text = "Clear all times in this session";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // labelScramble
            // 
            this.labelScramble.AutoSize = true;
            this.labelScramble.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScramble.Location = new System.Drawing.Point(12, 290);
            this.labelScramble.MaximumSize = new System.Drawing.Size(505, 0);
            this.labelScramble.Name = "labelScramble";
            this.labelScramble.Size = new System.Drawing.Size(71, 16);
            this.labelScramble.TabIndex = 6;
            this.labelScramble.Text = "Scramble:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2x2",
            "3x3",
            "4x4",
            "5x5",
            "6x6",
            "7x7",
            "NxN",
            "Pyraminx",
            "Megaminx",
            "Square-1"});
            this.comboBox1.Location = new System.Drawing.Point(516, 252);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(3, 42);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(93, 13);
            this.labelAvg.TabIndex = 8;
            this.labelAvg.Text = "Session avg: DNF";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(632, 362);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(421, 52);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Click to add times manually";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd1
            // 
            this.textBoxAdd1.Location = new System.Drawing.Point(632, 391);
            this.textBoxAdd1.Name = "textBoxAdd1";
            this.textBoxAdd1.Size = new System.Drawing.Size(32, 20);
            this.textBoxAdd1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelB12);
            this.panel1.Controls.Add(this.labelB5);
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.label100);
            this.panel1.Controls.Add(this.labelWorst);
            this.panel1.Controls.Add(this.labelBest);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelAvg);
            this.panel1.Location = new System.Drawing.Point(1062, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 311);
            this.panel1.TabIndex = 12;
            // 
            // labelB12
            // 
            this.labelB12.AutoSize = true;
            this.labelB12.Location = new System.Drawing.Point(3, 234);
            this.labelB12.Name = "labelB12";
            this.labelB12.Size = new System.Drawing.Size(125, 13);
            this.labelB12.TabIndex = 16;
            this.labelB12.Text = "Best average of 12: DNF";
            // 
            // labelB5
            // 
            this.labelB5.AutoSize = true;
            this.labelB5.Location = new System.Drawing.Point(3, 170);
            this.labelB5.Name = "labelB5";
            this.labelB5.Size = new System.Drawing.Size(119, 13);
            this.labelB5.TabIndex = 15;
            this.labelB5.Text = "Best average of 5: DNF";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(3, 10);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(92, 13);
            this.labelCount.TabIndex = 14;
            this.labelCount.Text = "Number of solves:";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(3, 266);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(129, 13);
            this.label100.TabIndex = 13;
            this.label100.Text = "Average of 100 (98): DNF";
            // 
            // labelWorst
            // 
            this.labelWorst.AutoSize = true;
            this.labelWorst.Location = new System.Drawing.Point(3, 106);
            this.labelWorst.Name = "labelWorst";
            this.labelWorst.Size = new System.Drawing.Size(85, 13);
            this.labelWorst.TabIndex = 12;
            this.labelWorst.Text = "Worst time: DNF";
            // 
            // labelBest
            // 
            this.labelBest.AutoSize = true;
            this.labelBest.Location = new System.Drawing.Point(3, 74);
            this.labelBest.Name = "labelBest";
            this.labelBest.Size = new System.Drawing.Size(78, 13);
            this.labelBest.TabIndex = 11;
            this.labelBest.Text = "Best time: DNF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Average of 12 (10): DNF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Average of 5 (3): DNF";
            // 
            // labelAdd1
            // 
            this.labelAdd1.AutoSize = true;
            this.labelAdd1.Location = new System.Drawing.Point(664, 395);
            this.labelAdd1.Name = "labelAdd1";
            this.labelAdd1.Size = new System.Drawing.Size(43, 13);
            this.labelAdd1.TabIndex = 13;
            this.labelAdd1.Text = "minutes";
            // 
            // textBoxAdd2
            // 
            this.textBoxAdd2.Location = new System.Drawing.Point(707, 391);
            this.textBoxAdd2.Name = "textBoxAdd2";
            this.textBoxAdd2.Size = new System.Drawing.Size(49, 20);
            this.textBoxAdd2.TabIndex = 14;
            this.textBoxAdd2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAdd2_KeyDown);
            // 
            // labelAdd2
            // 
            this.labelAdd2.AutoSize = true;
            this.labelAdd2.Location = new System.Drawing.Point(756, 395);
            this.labelAdd2.Name = "labelAdd2";
            this.labelAdd2.Size = new System.Drawing.Size(47, 13);
            this.labelAdd2.TabIndex = 15;
            this.labelAdd2.Text = "seconds";
            // 
            // labelAdd3
            // 
            this.labelAdd3.AutoSize = true;
            this.labelAdd3.Location = new System.Drawing.Point(824, 362);
            this.labelAdd3.Name = "labelAdd3";
            this.labelAdd3.Size = new System.Drawing.Size(231, 39);
            this.labelAdd3.TabIndex = 16;
            this.labelAdd3.Text = "To add times manually, enter minutes (optional)\r\nand seconds (use comma as the de" +
    "cimal point, \r\nnot period) and press enter to add the time.";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLast.Location = new System.Drawing.Point(12, 370);
            this.labelLast.MaximumSize = new System.Drawing.Size(505, 0);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(78, 14);
            this.labelLast.TabIndex = 17;
            this.labelLast.Text = "Last scramble:";
            // 
            // checkBoxInspect
            // 
            this.checkBoxInspect.AutoSize = true;
            this.checkBoxInspect.Location = new System.Drawing.Point(234, 256);
            this.checkBoxInspect.Name = "checkBoxInspect";
            this.checkBoxInspect.Size = new System.Drawing.Size(121, 17);
            this.checkBoxInspect.TabIndex = 18;
            this.checkBoxInspect.Text = "Use inspection time:";
            this.checkBoxInspect.UseVisualStyleBackColor = true;
            this.checkBoxInspect.CheckedChanged += new System.EventHandler(this.checkBoxInspect_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(353, 255);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelInspect
            // 
            this.labelInspect.AutoSize = true;
            this.labelInspect.Location = new System.Drawing.Point(395, 257);
            this.labelInspect.Name = "labelInspect";
            this.labelInspect.Size = new System.Drawing.Size(47, 13);
            this.labelInspect.TabIndex = 20;
            this.labelInspect.Text = "seconds";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.copyDataToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1256, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeInspectionTimeToolStripMenuItem,
            this.changeInterfaceToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeInspectionTimeToolStripMenuItem
            // 
            this.changeInspectionTimeToolStripMenuItem.Name = "changeInspectionTimeToolStripMenuItem";
            this.changeInspectionTimeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.changeInspectionTimeToolStripMenuItem.Text = "Change inspection time";
            // 
            // changeInterfaceToolStripMenuItem
            // 
            this.changeInterfaceToolStripMenuItem.Name = "changeInterfaceToolStripMenuItem";
            this.changeInterfaceToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.changeInterfaceToolStripMenuItem.Text = "Change interface";
            // 
            // copyDataToolStripMenuItem
            // 
            this.copyDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAllTimesToolStripMenuItem,
            this.copyLastScrambleToolStripMenuItem,
            this.copySessionAvgToolStripMenuItem});
            this.copyDataToolStripMenuItem.Name = "copyDataToolStripMenuItem";
            this.copyDataToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.copyDataToolStripMenuItem.Text = "Copy data";
            // 
            // copyAllTimesToolStripMenuItem
            // 
            this.copyAllTimesToolStripMenuItem.Name = "copyAllTimesToolStripMenuItem";
            this.copyAllTimesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.copyAllTimesToolStripMenuItem.Text = "Copy all times";
            this.copyAllTimesToolStripMenuItem.Click += new System.EventHandler(this.copyAllTimesToolStripMenuItem_Click);
            // 
            // copyLastScrambleToolStripMenuItem
            // 
            this.copyLastScrambleToolStripMenuItem.Name = "copyLastScrambleToolStripMenuItem";
            this.copyLastScrambleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.copyLastScrambleToolStripMenuItem.Text = "Copy last scramble";
            this.copyLastScrambleToolStripMenuItem.Click += new System.EventHandler(this.copyLastScrambleToolStripMenuItem_Click);
            // 
            // copySessionAvgToolStripMenuItem
            // 
            this.copySessionAvgToolStripMenuItem.Name = "copySessionAvgToolStripMenuItem";
            this.copySessionAvgToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.copySessionAvgToolStripMenuItem.Text = "Copy session avg";
            this.copySessionAvgToolStripMenuItem.Click += new System.EventHandler(this.copySessionAvgToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readManualToolStripMenuItem,
            this.ifStartingTheTimerWithSpacebarDeosntWorkClickOnTheTextPressSpacebarToStartAndStopTimerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readManualToolStripMenuItem
            // 
            this.readManualToolStripMenuItem.Name = "readManualToolStripMenuItem";
            this.readManualToolStripMenuItem.Size = new System.Drawing.Size(624, 22);
            this.readManualToolStripMenuItem.Text = "Read manual";
            // 
            // ifStartingTheTimerWithSpacebarDeosntWorkClickOnTheTextPressSpacebarToStartAndStopTimerToolStripMenuItem
            // 
            this.ifStartingTheTimerWithSpacebarDeosntWorkClickOnTheTextPressSpacebarToStartAndStopTimerToolStripMenuItem.Name = "ifStartingTheTimerWithSpacebarDeosntWorkClickOnTheTextPressSpacebarToStartAndStop" +
    "TimerToolStripMenuItem";
            this.ifStartingTheTimerWithSpacebarDeosntWorkClickOnTheTextPressSpacebarToStartAndStopTimerToolStripMenuItem.Size = new System.Drawing.Size(624, 22);
            this.ifStartingTheTimerWithSpacebarDeosntWorkClickOnTheTextPressSpacebarToStartAndStopTimerToolStripMenuItem.Text = "If starting the timer with spacebar deosn\'t work, click on the text \"Press spaceb" +
    "ar to start and stop timer\".";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisApplicationToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutThisApplicationToolStripMenuItem
            // 
            this.aboutThisApplicationToolStripMenuItem.Name = "aboutThisApplicationToolStripMenuItem";
            this.aboutThisApplicationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aboutThisApplicationToolStripMenuItem.Text = "About this application";
            // 
            // buttonPlus2
            // 
            this.buttonPlus2.Location = new System.Drawing.Point(12, 252);
            this.buttonPlus2.Name = "buttonPlus2";
            this.buttonPlus2.Size = new System.Drawing.Size(38, 23);
            this.buttonPlus2.TabIndex = 21;
            this.buttonPlus2.Text = "+2";
            this.buttonPlus2.UseVisualStyleBackColor = true;
            this.buttonPlus2.Click += new System.EventHandler(this.buttonPlus2_Click);
            // 
            // buttonDNF
            // 
            this.buttonDNF.Location = new System.Drawing.Point(56, 252);
            this.buttonDNF.Name = "buttonDNF";
            this.buttonDNF.Size = new System.Drawing.Size(38, 23);
            this.buttonDNF.TabIndex = 22;
            this.buttonDNF.Text = "DNF";
            this.buttonDNF.UseVisualStyleBackColor = true;
            this.buttonDNF.Click += new System.EventHandler(this.buttonDNF_Click);
            // 
            // buttonResetPenalty
            // 
            this.buttonResetPenalty.Location = new System.Drawing.Point(100, 252);
            this.buttonResetPenalty.Name = "buttonResetPenalty";
            this.buttonResetPenalty.Size = new System.Drawing.Size(69, 23);
            this.buttonResetPenalty.TabIndex = 23;
            this.buttonResetPenalty.Text = "No penalty";
            this.buttonResetPenalty.UseVisualStyleBackColor = true;
            this.buttonResetPenalty.Click += new System.EventHandler(this.buttonResetPenalty_Click);
            // 
            // buttonReplay
            // 
            this.buttonReplay.Location = new System.Drawing.Point(1062, 351);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(93, 23);
            this.buttonReplay.TabIndex = 24;
            this.buttonReplay.Text = "Redo last solve";
            this.buttonReplay.UseVisualStyleBackColor = true;
            this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click);
            // 
            // buttonScramble
            // 
            this.buttonScramble.Location = new System.Drawing.Point(505, 290);
            this.buttonScramble.Name = "buttonScramble";
            this.buttonScramble.Size = new System.Drawing.Size(83, 23);
            this.buttonScramble.TabIndex = 25;
            this.buttonScramble.Text = "New scramble";
            this.buttonScramble.UseVisualStyleBackColor = true;
            this.buttonScramble.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1256, 448);
            this.Controls.Add(this.buttonScramble);
            this.Controls.Add(this.buttonReplay);
            this.Controls.Add(this.buttonResetPenalty);
            this.Controls.Add(this.buttonDNF);
            this.Controls.Add(this.buttonPlus2);
            this.Controls.Add(this.labelInspect);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBoxInspect);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelAdd3);
            this.Controls.Add(this.labelAdd2);
            this.Controls.Add(this.textBoxAdd2);
            this.Controls.Add(this.labelAdd1);
            this.Controls.Add(this.textBoxAdd1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelScramble);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonClearLast);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClearLast;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label labelScramble;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeInspectionTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisApplicationToolStripMenuItem;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAdd1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWorst;
        private System.Windows.Forms.Label labelBest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAdd1;
        private System.Windows.Forms.TextBox textBoxAdd2;
        private System.Windows.Forms.Label labelAdd2;
        private System.Windows.Forms.Label labelAdd3;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.CheckBox checkBoxInspect;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelInspect;
        private System.Windows.Forms.ToolStripMenuItem ifStartingTheTimerWithSpacebarDeosntWorkClickOnTheTextPressSpacebarToStartAndStopTimerToolStripMenuItem;
        private System.Windows.Forms.Button buttonPlus2;
        private System.Windows.Forms.Button buttonDNF;
        private System.Windows.Forms.Button buttonResetPenalty;
        private System.Windows.Forms.Button buttonReplay;
        private System.Windows.Forms.ToolStripMenuItem copyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyLastScrambleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySessionAvgToolStripMenuItem;
        private System.Windows.Forms.Button buttonScramble;
        private System.Windows.Forms.Label labelB12;
        private System.Windows.Forms.Label labelB5;
    }
}

