using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thio_Lab_3C
{
    class Program
    {
        static void Main(string[] args)
        {
            MonteCarloMethod();
        }

        private static void MonteCarloMethod()
        {
            Console.WriteLine("How many times do you want this to itertate? ");
            int iterations = int.Parse(Console.ReadLine());

            int inside = 0;
            Random randomX = new Random();

            for (int i = 0; i < iterations; i++)
            {

                var (x, y) = GenerateXYPair(randomX);
                var newHypotenuse = CalculateHypotenuse(x, y);

                if (newHypotenuse <= 1.0)
                {
                    inside += 1;
                }
            }

            double estimate = 4.0 * inside / iterations;
            Console.WriteLine($"Pi estimate is: {estimate}");

            double finalResult = Math.Abs(estimate - Math.PI);
            Console.WriteLine($"Difference between estimated pi and actual pi: {finalResult}");
        }

        public static (double, double) GenerateXYPair(Random rand)
        {
            Coordinates point = new Coordinates(rand);
            return (point.xCoord, point.yCoord);
        }
        public static double CalculateHypotenuse(double x, double y)
        {
            Coordinates hypotenuse = new Coordinates(x, y);
            var underSqrt = Math.Pow(hypotenuse.xCoord, 2) + Math.Pow(hypotenuse.yCoord, 2);
            return Math.Sqrt(underSqrt);
        }
    }
    struct Coordinates
    {
        public double xCoord, yCoord;

        public Coordinates(double x, double y)
        {
            xCoord = x;
            yCoord = y;
        }
        public Coordinates(Random rand)
        {
            xCoord = rand.NextDouble();
            yCoord = rand.NextDouble();
        }
    }

}
// Questions
// 1. Why do we multiply the value from step 5 above by 4? The circle has 4 quadrants and we are only representing values from one until we multiply by four.
// 2. What do you observe in the output when running your program with parameters of increasing size? The value becomes more accurate.
// 3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not? No because the system.random generates random tests and outputs different numbers.
// 4. Find a parameter that requires multiples seconds of run time.  What is that parameter? 1,000,000
// 5. How accurate is the estimated value of pi? The more iterations that run, the more accurate the vale is to pi.
// 6. Research one other use of Monte-Carlo methods.  Record it in your exercise submission and be prepared to discuss it in class.