using System;

namespace SnakeLadder
{/// <summary>
 /// UC7- Play the game with two player if player gets ladder then plays again and check which won.
 /// </summary>

    class Program
    {
        //constant
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;

        static void Main(string[] args)
        {
            int positionOne = 0;
            int positionTwo = 0;
            int loopCount = 0;
            int currentPlayer = 1;
            int currentPlayerPos = 0;
            Random random = new Random();

            //While loop
            while (positionOne < 100 && positionTwo < 100)
            {
                loopCount++;
                //initilize loops variable
                if (currentPlayer == 1)
                {
                    currentPlayerPos = positionOne;
                }
                else
                {
                    currentPlayerPos = positionTwo;
                }

                //in-play
                int diceNum = random.Next(0, 7);    //O-initial number , 6-final number
                int result = random.Next(0, 3);     //1-Ladder, 2-Snake , 0-No-play

                if (result == LADDER)
                {
                    if (currentPlayerPos + diceNum <= 100)
                    {
                        currentPlayerPos += diceNum;
                    }
                }
                else if (result == SNAKE)
                {
                    if (currentPlayerPos - diceNum >= 0)
                    {
                        currentPlayerPos -= diceNum;
                    }
                    else
                    {
                        currentPlayerPos = 0;
                    }
                }
                // Re-assign the play result to player
                if (currentPlayer == 1)
                {
                    positionOne = currentPlayerPos;
                    currentPlayer = 2;
                }
                else
                {
                    positionTwo = currentPlayerPos;
                    currentPlayer = 1;
                }
            }
            //Checking for winner
            if (positionOne == 100)
            {
                Console.WriteLine("Player One Wins the game..!!");
            }
            else if (positionTwo == 100)
            {
                Console.WriteLine("Player Two Wins the game..!!");
            }
            Console.WriteLine("Dice rolled :" + loopCount + "times");
            Console.ReadLine();
        }
    }
}