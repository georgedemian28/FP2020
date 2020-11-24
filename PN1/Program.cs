using System;

namespace PN1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            
            Console.Write("a = ");
            string an = Console.ReadLine();
            Console.Write("b = ");
            string bn = Console.ReadLine();

            a = int.Parse(an);
            b = int.Parse(bn);
            b = b * -1;
            double x = (double)b / a;

            Console.WriteLine("ax = b = 0");
            Console.WriteLine($"=> {a}x + {-b} = 0");
            Console.WriteLine($"=> {a}x = {b}");
            Console.WriteLine($"=> x = {b} / {a}");
            Console.WriteLine($"=> x = {x}");
        }
    }
}
