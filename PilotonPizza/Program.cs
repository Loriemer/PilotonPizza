using System;

namespace PilotonPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            string Diameter = null;
            int Slices;
            const double SliceSize = 14.13;
            double Radius;
            double Area;

            Console.WriteLine("Enter diameter of pizza");
            Diameter = Console.ReadLine();
            double Diameter1 = Convert.ToDouble(Diameter);

            Radius = Diameter1 / 2;
            Area = Math.PI * Math.Pow(Radius, 2);
            Slices = (int)(Area / SliceSize);

            Console.WriteLine("A Diameter\" pizza will yield {0:no} slices", Slices);

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}