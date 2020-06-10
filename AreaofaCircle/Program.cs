using System;

namespace AreaofaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius; // pi r square

            Console.WriteLine("\nThe Area of your Circle is:"+area);
          //  Console.ReadKey();

        }
        
    }
}
