using System;

namespace PN2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, c;

            Console.Write("a = ");
            string an = Console.ReadLine();
            Console.Write("b = ");
            string bn = Console.ReadLine();
            Console.Write("c = ");
            string cn = Console.ReadLine();

            a = int.Parse(an);
            double b = int.Parse(bn);
            c = int.Parse(cn);
            double dt = Math.Pow(b , 2) - 4 * a * c;
            double rad = Math.Sqrt(dt);

            if (rad >= 1)
            { double x1 = (double)(-b + rad) / (2 * a);
              double x2 = (double)(-b - rad) / (2 * a);
                Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
                Console.WriteLine($"=> x1 = ({-b} + {rad}) / 2 * {a}");
                Console.WriteLine($"=> x1 = {x1}");
                Console.WriteLine($"=> x2 = ({-b} - {rad}) / 2 * {a}");
                Console.WriteLine($"=> x2 = {x2}");
            }
            else
                if(rad == 0)
                { double x3 = (double)(-1 * b) / (2 * a);
                Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
                Console.WriteLine($"=> x = {-b} / 2 * {a}");
                Console.WriteLine($"=> x = {x3}");
                }
            else
                if(rad <= 0)
                { double x4 = (double)(-b) }
        }
    }
}
