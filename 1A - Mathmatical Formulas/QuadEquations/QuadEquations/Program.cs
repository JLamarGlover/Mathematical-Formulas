using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double x2;
            double x1;

            Console.Write("What is side a   ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("What is side b   ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("What is side c   ");
            int c = int.Parse(Console.ReadLine());

            x = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            x1 = a * (x * x) + (b * x) + c;

            Console.WriteLine("Answer is   " + x);
            Console.WriteLine("Answer is   " + x2);
            Console.WriteLine("Answer is   " + x1);

           Console.ReadLine();
        }
    }
}
