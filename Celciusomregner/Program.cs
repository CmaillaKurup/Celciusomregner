using System;

namespace Celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());
            double a = c * 0.8;
            double b = c * 1.8 + 32;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
