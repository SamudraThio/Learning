using System;

namespace Conditional_statements
{
    class Program
    {
        static void TestOverloading()
        {
            Console.WriteLine("Called with no parameters");
        }

        static void TestOverloading(int i)
        {
            Console.WriteLine($"Called with integer {i}");
        }

        static void TestOverloading(string s)
        {
            Console.WriteLine($"Called with string \"{s}\"");
        }

        static void TestOverloading(double d)
        {
            Console.WriteLine($"Called with double {d}");
        }


        static void OptionalParameter(bool shouldPrint, int x = 0, int y = 0, int z = 0)
        {
            if (shouldPrint)
            {
                Console.WriteLine($"Received:\n\tx:\t{x}\n\ty:\t{y}\n\tz:\t{z}");
            }
            else
            {
                Console.WriteLine("Not printing");
            }
        }

        static void OverloadedParameter() => OverloadedParameter(0, 0, 0);

        static void OverloadedParameter(int x) => OverloadedParameter(x, 0, 0);

        static void OverloadedParameter(int x, int y) => OverloadedParameter(x, y, 0);

        static void OverloadedParameter(int x, int y, int z) =>
            Console.WriteLine($"Received:\n\tx:\t{x}\n\ty:\t{y}\n\tz:\t{z}");


        static void Main(string[] args)
        {
            OptionalParameter(true);
            OptionalParameter(true, 7);
            OptionalParameter(true, 7, 42);
            OptionalParameter(true, 7, 42, 75);

            OptionalParameter(true, z: 72, x: -5);

            OptionalParameter(false, y: -1203498, z: 72, x: -5);

            OverloadedParameter();
            OverloadedParameter(7);
            OverloadedParameter(7, 42);
            OverloadedParameter(7, 42, 75);

            //TestOverloading();

            //for (int i = 0; i < 10; i++)
            //{
            //    TestOverloading(i);
            //}

            //TestOverloading(Math.PI);
            //TestOverloading("Cat");
        }
    }
}
