using System;

namespace SnakeLadder
{

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
            
            Random random = new Random();           //random method to generate random number
            int CheckOption = random.Next(1, 4);    //next method to generate value from 1 to 3
            int CheckDie = Program.CheckDice();     //Called the CheckDice in which position 1 to 6 is stored
            int currentPlayer = 1;
            int posPlayer = 0;
            int posplayer1 = 0;
            int posplayer2 = 0;
            int numOfDiceRolles = 0;

            //while loop
            while (posPlayer < 100 && posplayer2 <= 100)
            {
                numOfDiceRolles++;
                //If else if selection statement

                //re-initilize variable
                if (currentPlayer == 1)
                {
                    posPlayer = posplayer1;
                }
                else
                {
                    posPlayer = posplayer2;
                }

                if (CheckOption == LADDER)
                {
                    if (posPlayer + CheckDie <= 100) //Checking if the dice goes above 100 than it come to 100 position
                    {
                        posPlayer += CheckDie;
                        Console.WriteLine("LADDER");
                        Console.WriteLine("player current position : " + posPlayer);
                    }
                    else
                    {
                        posPlayer++;
                        Console.WriteLine("LADDER");
                        Console.WriteLine("player current position : " + posPlayer);
                    }

                }
                else if (CheckOption == SNAKE)
                {
                    if (posPlayer - CheckDie <= 0)   //Checking if the dice goes below zero than come at starting position
                    {
                        posPlayer = 0;
                    }
                    else
                    {
                        posPlayer -= CheckDie;
                        Console.WriteLine("SNAKE");
                        Console.WriteLine("player current position : " + posPlayer);
                    }

                }
                else
                {
                    Console.WriteLine("NO Play");
                    posPlayer++;
                }
                // re-assign return variable
                if (currentPlayer == 1)
                {
                    posplayer1 = posPlayer;
                }
                else
                {
                    posplayer2 = posPlayer;
                }

                //Checking winner
                if (posplayer1 == 100)
                {
                    Console.WriteLine("player one winner");
                }
                else if(posplayer2 == 100)
                {
                    Console.WriteLine("player two is winner");
                }
                Console.WriteLine("number of rolls die"+ numOfDiceRolles);

            }

        }

        static void Main(string[] args)
        {
            Program.CheckOption();
            Console.ReadLine();
        }
    }
}