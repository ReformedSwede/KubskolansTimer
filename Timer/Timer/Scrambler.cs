using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    class Scrambler
    {
        Random rand = new Random();

        /****Constant arrays****/
        static readonly string[] letters = {"F", "R", "U", "B", "L", "D"};
        static readonly string[] signs = {"", "'", "2"};
        static readonly string[] wides = {"", "w" };
        static readonly string[] bigs = { "", "1", "2", "3", "4", "5" };
        
        public string Scramble(string puzzleType) // Returns a scramble algorithm. 
        {
            switch (puzzleType)
            {
                case "2x2":
                    return TwoByTwo();
                case "3x3":
                    return ThreeByThree();
                case "4x4":
                    return FourByFour();
                case "5x5":
                    return FiveByFive();
                case "6x6":
                    return SixBySix();
                case "7x7":
                    return SevenBySeven();
                case "Pyraminx":
                    return Pyraminx();
                case "Megaminx":
                    return Megaminx();
                case "Square-1":
                    return SquareOne();
                default:
                    return "";
            }
        }

        private string TwoByTwo()
        {
            string[] moves = new string[11]; // Each string in this array is a move in the scramble algorithm. 
            int count = 0;
            while (count < 11) // Generates 10 letters for the algorithm. 
            {
                moves[count] = LetterGenerator(0, 3);
                count++;
                if (count > 1)
                {
                    if (moves[count - 1] == moves[count - 2]) // Makes sure no letter is the same as the last one. I.E. avoids "R, R2"
                    {
                        count--;
                    }
                    else if (count > 3 && moves[count - 1] == moves[count - 3]) // Makes sure no letter is the same as the one before the last one. Avoids "R', L2, R"
                    {
                        count--;
                    }
                }
            }
            return String.Join(" ", moves.Select(move => move + SignGenerator(0, 3)));
        }

        private string ThreeByThree()
        {
            string[] moves = new string[25];
            int count = 0;
            while (count < 25)
            {
                moves[count] = LetterGenerator(0, 6);
                count++;
                if (count > 1)
                {
                    if (moves[count - 1] == moves[count - 2])
                    {
                        count--;
                    }
                    else if (count > 2 && moves[count - 1] == moves[count - 3])
                    {
                        count--;
                    }
                }
            }
            return String.Join(" ", moves.Select(move => move + SignGenerator(0, 3)));
        }

        private string FourByFour()
        {
            string[] moves = new string[30];
            int count = 0;
            while (count < 30)
            {
                moves[count] = LetterGenerator(0, 6) + WideGenerator(0, 2);
                count++;
                if (count > 1)
                {
                    if (moves[count - 1] == moves[count - 2])
                    {
                        count--;
                    }
                    else if (count > 3 && moves[count - 1] == moves[count - 3]) // Makes sure no letter is the same as the one before the last one. Avoids "R', L2, R"
                    {
                        count--;
                    }
                }
            }
            return String.Join(" ", moves.Select(move => move + SignGenerator(0, 3)));
        }

        private string FiveByFive()
        {
            string[] moves = new string[40];
            int count = 0;
            while (count < 40)
            {
                moves[count] = LetterGenerator(0, 6) + WideGenerator(0, 2);
                count++;
                if (count > 1)
                {
                    if (moves[count - 1] == moves[count - 2])
                    {
                        count--;
                    }
                    else if (count > 3 && moves[count - 1] == moves[count - 3]) // Makes sure no letter is the same as the one before the last one. Avoids "R', L2, R"
                    {
                        count--;
                    }
                }
            }
            return String.Join(" ", moves.Select(move => move + SignGenerator(0, 3)));
        }

        private string SixBySix()
        {
            string[] moves = new string[50];
            int count = 0;
            while (count < 50)
            {
                moves[count] = BigGenerator(0, 3) + LetterGenerator(0, 6);
                count++;
                if (count > 1)
                {
                    if (moves[count - 1] == moves[count - 2])
                    {
                        count--;
                    }
                    else if (count > 3 && moves[count - 1] == moves[count - 3]) // Makes sure no letter is the same as the one before the last one. Avoids "R', L2, R"
                    {
                        count--;
                    }
                }
            }
            return String.Join(" ", moves.Select(move => move + SignGenerator(0, 3)));
        }

        private string SevenBySeven()
        {
            string[] moves = new string[60];
            int count = 0;
            while (count < 60)
            {
                moves[count] = BigGenerator(0, 3) + LetterGenerator(0, 6);
                count++;
                if (count > 1)
                {
                    if (moves[count - 1] == moves[count - 2])
                    {
                        count--;
                    }
                    else if (count > 3 && moves[count - 1] == moves[count - 3]) // Makes sure no letter is the same as the one before the last one. Avoids "R', L2, R"
                    {
                        count--;
                    }
                }
            }
            return string.Join(" ", moves.Select(move => move + SignGenerator(0, 3)));
        }

        private string Pyraminx()
        {
            string algorithmToReturn;
            string[] moves = new string[10];
            int count = 0;
            while (count < 10)
            {
                moves[count] = LetterGenerator(1, 5);
                count++;
                if (count > 1)
                {
                    if (moves[count - 1] == moves[count - 2])
                    {
                        count--;
                    }
                }
            }
            algorithmToReturn = string.Join(" ", moves.Select(move => move + SignGenerator(0, 2)));

            //The following code can probably be simplified...
            moves = new string[4];
            count = 0;
            while (count < 4)
            {
                moves[count] = SignGenerator(0, 3);
                switch (count)
                {
                    case 0:
                        if (moves[count] == "2 ")
                            algorithmToReturn += "";
                        else
                            algorithmToReturn += " u" + moves[count];
                        break;
                    case 1:
                        if (moves[count] == "2 ")
                            algorithmToReturn += "";
                        else
                            algorithmToReturn += " r" + moves[count];
                        break;
                    case 2:
                        if (moves[count] == "2 ")
                            algorithmToReturn += "";
                        else
                            algorithmToReturn += " l" + moves[count];
                        break;
                    case 3:
                        if (moves[count] == "2 ")
                            algorithmToReturn += "";
                        else
                            algorithmToReturn += " b" + moves[count];
                        break;
                }
                count++;
            }

            return algorithmToReturn;
        }

        private string Megaminx()
        {
            return "";
        }

        private string SquareOne()
        {
            return "";
        }

        private string LetterGenerator(int min, int max) // Is used for generating a random letter.
        {
            return letters[rand.Next(min, max)];
        }

        private string SignGenerator(int min, int max) // Is used for generating a random sign.
        {
            return signs[rand.Next(min, max)];
        }

        private string WideGenerator(int min, int max) // Is used to generate "w" in 4x4 scramble. 
        {
            return wides[rand.Next(min, max)];
        }

        private string BigGenerator(int min, int max)// Is used for generating scrambles for puzzles >= 6x6
        {
            return bigs[rand.Next(min, max)];
        }
    }
}
