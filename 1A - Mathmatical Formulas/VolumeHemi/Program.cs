using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeHemi
{
    class Program
    {
        static void Main(string[] args)
        {
            double Radius;
            double Volume;
            double Pi = Math.PI;

            Console.WriteLine("Radius Here    ");

            Radius = double.Parse(Console.ReadLine());

            Volume = ((4 / 3) * (Pi * Radius * Radius * Radius)) / 2;

            Console.WriteLine("Volume is   " + Volume);

            Console.ReadLine();

        }
    }
}
