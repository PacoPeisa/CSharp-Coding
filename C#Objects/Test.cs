using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Objects
{
    public class TestEnvironment
    {
        public static void TestEnvironmentClass()
        {
            int sum = 0;
            int startTime = Environment.TickCount;

            for(int i = 0; i < 100000000; i++) 
            {
                sum++;
            }

            int endTime = Environment.TickCount;

            double result = (endTime - startTime) / 1000.0;

            Console.WriteLine($"The time elapsed is {result} sec.");

        }

        public static void MathTest(double a, double b, int angle)
        {
            double angleInRadians = Math.PI * angle / 180.0;
            Console.WriteLine("Area of the triangle: {0}", 0.5 * a * b * Math.Sin(angleInRadians));
        }

        public static void RandomTest()
        {
            Random random = new Random();

            for(int n = 1; n <= 6; n++) 
            {
                int randomNumber = random.Next(49) + 1;
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();
        }
    }
}
