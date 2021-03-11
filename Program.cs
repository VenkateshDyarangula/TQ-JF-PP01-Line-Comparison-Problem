using System;

namespace UC3_Compare_Two_Lines
{
    class Program
    {
        static double distance(int x1, int y1, int x2, int y2)
        {
            // Calculating Length
            return Math.Sqrt(Math.Pow(x2 - x1, 2) +
                          Math.Pow(y2 - y1, 2) * 1.0);
        }
        static int readLines()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter for parameters (x1, y1, x2, y2 and x3, y3, x4, y4)Line 1 and Line 2");
            int x1 = readLines();
            int y1 = readLines();
            int x2 = readLines();
            int y2 = readLines();
            //line2
            int x3 = readLines();
            int y3 = readLines();
            int x4 = readLines();
            int y4 = readLines();
            double Line1 = (Math.Round(distance(x1, y1, x2, y2) * 100000.0) / 100000.0);
            //Console.WriteLine(Line1);
            double Line2 = (Math.Round(distance(x3, y3, x4, y4) * 100000.0) / 100000.0);
            Console.WriteLine(Line1);
            Console.WriteLine(Line2);
            if (Line1.Equals(Line2))
                Console.WriteLine("Two Lines are Equel");
             else if (Line1 > Line2)
                Console.WriteLine("Line 1 is Greater than Line 2");
            else if (Line1 < Line2)
                Console.WriteLine("Line 1 is Lesser than Line 2");            
 
             //UC4 merged here
            //CompareTo Method
             int status = Line1.CompareTo(Line2);
            if (status > 0)
                Console.WriteLine("Line1 is greater than Line2",
                                            Line1, Line2);
            else if (status < 0)
                Console.WriteLine("Line1 is Lesse than Line2",
                                         Line1, Line2);
            else
                Console.WriteLine("Two Lines are Equel",
                                        Line1, Line2);
        }
    }
}
