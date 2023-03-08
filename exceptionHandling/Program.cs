using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x = 1;
            for(x=1;x<4;x++)
            {
                Console.WriteLine("Enter the Radius of the circle " + x);
                double r = double.Parse(Console.ReadLine());
                try
                {
                    Circle circle = new Circle(r);
                    Console.WriteLine(circle);
                }
                catch (InvalidRadiusException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
