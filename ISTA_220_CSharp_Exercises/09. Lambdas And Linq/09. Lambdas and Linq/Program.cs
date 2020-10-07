using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LambdasAndLinq
{
    class Program
    {

        delegate void Print();
        delegate int Increment(int x);
        delegate int XPowerOfY(int x, int y);
        delegate int Add(int x, int y);
        delegate string Append(string x, string y);

        static void Main(string[] args)
        {
            // Lambdas
            // An expression which takes no parameters and evaluates to the string "Hello, World".
            Print welcome = () => Console.WriteLine("Hello, World");
            welcome();

            // An expression which returns an integer, takes a single integer parameter, and adds the integer 1 to it.
            Increment increment = x => { return x + 1; };
            Console.WriteLine(increment(5));

            //An expression which returns an integer, takes two integer parameters, and raises the first parameter to the power of the second.
            XPowerOfY xPowerOfY = (x, y) => {return (int) Math.Pow(x, y); };
            Console.WriteLine(xPowerOfY(6, 2));

            // An expression which returns an integer, takes two integer parameters and sums them.
            Add add = (x, y) => x + y;
            Console.WriteLine(add(5, 6));

            // An expression which returns a string, takes two strings, and appends the first to the second.
            Append append = (x, y) => { return x + y; };
            Console.WriteLine(append("one", "word"));

            // LINQ
            // Declare a list of sequential integers with a method from the Enumerable class.
            var numbers = Enumerable.Range(1, 11);

            // Declare a list of dummy strings.
            string[] stringsList = new string[] { "hello", "darkness", "my", "old", "friend" };

            // Use #2 to add one to a list of integers individually.
            var incremented = from number in numbers
                              select number;
            foreach (var number in incremented)
            {
                Console.WriteLine(increment(number));
            }

            // Use #3 to raise a list of integers to the second power individually.
            var powerOfTwo = from number in numbers
                             select number;
            foreach (var number in powerOfTwo)
            {
                Console.WriteLine(xPowerOfY(number, 2));
            }

            // Use #4 to sum a list of integers.
            int x = 0;

            var addList = from number in numbers
                          select number;
            foreach (var number in addList)
            {
                x = add(x, number);
            }
            Console.WriteLine(x);

            // Use #5 to concatenate a list of strings, returning an empty string if given an empty list.
            string wordlist = "";

            var concatenate = from word in stringsList
                              select word;
            foreach(var word in concatenate)
            {
                wordlist = append(wordlist, word);
            }
            Console.WriteLine(wordlist);

            /* Use #3 and a method from the Enumerable class in a new lambda expression which returns an integer, 
            / takes two integer parameters (base and times), and which raises the base to its own value times times
            Evaluating your function with base of 2 and times of 4 should result in 65536. This is repeated exponentiation,
            also known as tetration, and is frequently expressed in Knuth's up-arrow notation (Links to an external site.) using double up-arrows. */
            XPowerOfY tetration = (x, y) => { return (int)Math.Pow((x * x), (y*x)); };
            Console.WriteLine(tetration(2, 4));
        }
        
    }
}
