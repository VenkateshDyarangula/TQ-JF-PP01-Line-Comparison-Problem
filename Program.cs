using System;

namespace UC1_Line_Using_Cartesian_System
{
    class Program
    {
        static double distance(int x1, int y1, int x2, int y2)
        {
            // Calculating Length
            return Math.Sqrt(Math.Pow(x2 - x1, 2) +
                          Math.Pow(y2 - y1, 2) * 1.0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr x1, y1 and x2, y2 Values");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Round(distance(x1, y1, x2, y2) * 100000.0) / 100000.0);
        }

    }
}
