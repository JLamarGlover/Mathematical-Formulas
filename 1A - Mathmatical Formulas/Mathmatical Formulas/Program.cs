using System;

namespace Mathmatical_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            double Radius;
            double pie = Math.PI;
            double Area, Cir, Dia;

            Console.Write("Enter radius of circle      ");

            Radius = double.Parse(Console.ReadLine());
            Area = pie * (Radius * Radius);
            Cir = 2 * pie + Radius;
            Dia = 2 * Radius;

            Console.WriteLine("the area   " + Area);
            Console.WriteLine("the circumference     " + Cir);
            Console.WriteLine("the diameter    " + Dia);

            Console.ReadKey();
        }
    }
}
