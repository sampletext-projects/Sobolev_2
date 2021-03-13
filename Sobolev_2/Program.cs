using System;

namespace Sobolev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());

            double z;
            if (b > 8)
            {
                z = b;
            }
            else if (b == 8)
            {
                z = b * b * b;
            }
            else
            {
                z = Math.Pow(b, 4);
            }


            double a;
            if (b > 6)
            {
                a = b * b + Math.E;
            }
            else
            {
                a = b * b - Math.Cos(Math.E);
            }


            double Y;
            if (a * z > 15)
            {
                Y = 5;
            }
            else if (a * z == 15)
            {
                Y = b * Math.Cos(a);
            }
            else
            {
                Y = Math.Tan(a) + b * b;

            }


            Console.WriteLine(Y);
        }
    }
}
