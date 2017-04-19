using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treug
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter side a");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter side b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter side c");
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                Console.WriteLine("Side can't be less 0." + Environment.NewLine + "Repeat? (Y,N)");
                ConsoleKeyInfo rep = Console.ReadKey(true);
                if (rep.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
            else
            {
                if (Math.Abs(a * a + b * b - c * c) >= 0.01)
                {
                    Console.WriteLine("This triangle is not right." + Environment.NewLine + "Repeat? (Y,N)");
                    ConsoleKeyInfo rep = Console.ReadKey(true);
                    if (rep.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        Main();
                    }
                }
                else
                {
                    double p = (a + b + c) / 2;
                    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine("Squared of this triangle = " + s + Environment.NewLine + "Repeat? (Y,N)");
                    ConsoleKeyInfo rep = Console.ReadKey(true);
                    if (rep.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        Main();
                    }
                }
            }
        }
    }
}
