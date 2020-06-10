using System;

namespace AnotherArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int Radius;
            double Circle;
            Console.WriteLine("Enter Radius");
            Radius = Convert.ToInt32(Console.ReadLine());
            Circle = Math.PI * Radius * Radius;

            Console.WriteLine("The area of the circle of the given radius is:"+Circle);
        }
    }
}
