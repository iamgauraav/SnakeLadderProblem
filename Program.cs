using System;

namespace SnakeLadder
{/// <summary>
 /// UC6- Report number of times dice was played to win and the position after every die rolled
 /// </summary>

    class Program
    {
        //constant
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 3;


        //Method to return CheckDice
        public static int CheckDice()
        {
            Random random = new Random();           //random method to generate random number
            int CheckDice = random.Next(1, 7);      //next method to generate value from 1 to 6
            Console.WriteLine("Dice number: " + CheckDice);
            return CheckDice;
        }

        public static void CheckOption()
        {
            int position = 0;           
            int CheckDie = Program.CheckDice();     //Called the CheckDice in which position 1 to 6 is stored

            //while loop
            while (position < 100)
            {
                position++;
                Random random = new Random();           //random method to generate random number
                int CheckOption = random.Next(1, 4);    //next method to generate value from 1 to 3

                //If else if selection statement
                if (CheckOption == LADDER)
                {
                    if (position + CheckDie < 100) 
                    {
                        position += CheckDie;
                        Console.WriteLine("LADDER");
                        Console.WriteLine("player current position : " + position);
                    }
                }
                else if (CheckOption == SNAKE)
                {
                    if (position - CheckDie >= 0)
                    {
                        position -= CheckDie;
                        Console.WriteLine("SNAKE");
                        Console.WriteLine("player current position : " + position);
                    }
                    else
                    {
                        position = 0;
          
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program.CheckOption();
            Console.ReadLine();
        }
    }
}