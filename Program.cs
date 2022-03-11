using System;

namespace SnakeLadder
{
    class Program
    {
        public static void position()
        {
            int position = 0;
            Console.WriteLine( "Player is at start position : " + position);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sinlge player");
            Program.position();
            Console.ReadLine();
        }
    }
}
