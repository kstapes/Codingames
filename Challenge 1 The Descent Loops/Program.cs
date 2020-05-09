using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/

namespace Challenge_1_The_Descent_Loops
{
    class Program
    {
        public static List<int> mountainHeights = new List<int>();
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 0; i < 8; i++)
                {
                    int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.

                    mountainHeights.Add(mountainH);
                }

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                // The index of the mountain to fire on.
                int highestMountain = mountainHeights.Aggregate(0, (largest, next) => next > largest ? next : largest);
                Console.WriteLine(mountainHeights.IndexOf(highestMountain));
                mountainHeights.Clear();
            }
        }
    }
}
