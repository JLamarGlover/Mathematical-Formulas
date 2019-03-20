using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double per;
            double area;

            Console.Write("What is side a   ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("What is side b   ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("What is side c   ");
            int c = int.Parse(Console.ReadLine());

            per = (a + b + c) / 2;
            area = Math.Sqrt((per * (per - a) * (per - b) * (per - c)));
            Console.WriteLine("The area is     " + area);
            Console.ReadLine();
        }
    }
}
