
using System;

namespace VolumeOfCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            const double radius = 10;
            const double height = 50;
            const double pi = 3.14;

            double volume = pi * Math.Pow(radius, 2) * height;

            Console.WriteLine("Zapremina valjka sa poluprečnikom {0} i visinom {1} iznosi: {2}", radius, height, volume);

            Console.ReadKey();
        }
    }
}
