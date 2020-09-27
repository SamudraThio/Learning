using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
                AreaofCircle();
                VolumeofHemisphere();
                AreaofTriangle();
                QuadraticEquation();
        }

        private static void QuadraticEquation()
        {
            Console.WriteLine("\nPart 4, solving a quadratic equation.");

            Console.WriteLine("Enter an integer for a: ");
            string strAVariable = Console.ReadLine();
            int intAVariable = (int.Parse(strAVariable));

            Console.WriteLine("Enter an integer for b: ");
            string strBVariable = Console.ReadLine();
            int intBVariable = int.Parse(strBVariable);

            Console.WriteLine("Enter an integer for c: ");
            string strCVariable = Console.ReadLine();
            int intCVariable = int.Parse(strCVariable);

            double positive_num = intBVariable * (-1) + Math.Sqrt(Math.Pow(intBVariable, 2) - 4 * intAVariable * intCVariable);
            double negative_num = intBVariable * (-1) - Math.Sqrt(Math.Pow(intBVariable, 2) - 4 * intAVariable * intCVariable);
            double denominator = 2 * intAVariable;

            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");
        }
        
        private static void AreaofTriangle()
        {
             Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            
             Console.WriteLine("Enter an integer for side a: ");
             string userInput = Console.ReadLine();
             int intASide = int.Parse(userInput);

             Console.WriteLine("Enter an integer for side b: ");
             userInput = Console.ReadLine();
             int intBSide = int.Parse(userInput);
            
             Console.WriteLine("Enter an integer for side c: ");
             userInput = Console.ReadLine();
             int intCSide = int.Parse(userInput);
            
             double p = ((intASide + intBSide + intCSide) / 2);
             double triangleArea = Math.Sqrt(p * (p - intASide) * (p - intBSide) * (p - intCSide));
            
             Console.WriteLine($"The Area is {triangleArea}");
        }

        public static void VolumeofHemisphere()
        {
            Console.WriteLine("\nPart 2, volume of a hemisphere");
            Console.WriteLine("Enter an integer for the radius: ");
            string userInput = Console.ReadLine();
            int intHemiRadius = int.Parse(userInput);

            double fraction1 = 4;
            double fraction2 = 3;
            
            double volume = (fraction1 / fraction2 * Math.PI * Math.Pow(intHemiRadius, 3)) / 2;
            
            Console.WriteLine($"The volume is {volume}");
        }

        private static void AreaofCircle()
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");

            Console.WriteLine("Enter an integer for the radius: ");
            string userInput = Console.ReadLine();
            int intradius = int.Parse(userInput);

            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            double area = Math.PI * Math.Pow(intradius, 2);
            Console.WriteLine($"The area is {area}");
        }
    }
}
