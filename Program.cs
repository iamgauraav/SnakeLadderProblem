using System;

namespace SnakeLadder
{/// <summary>
/// UC2- The player rolls the die to get a number between 1 to 6
/// </summary>

    class Program
    {
        //Generating a random no. using Random method()
        public static void CheckDice()
        {
            Random random = new Random();
            int CheckDie = random.Next(1, 7);
            Console.WriteLine("Dice number: " + CheckDie);
        }
       
        static void Main(string[] args)
        {
            Program.CheckDice();
            Console.ReadLine();
        }
    }
}
