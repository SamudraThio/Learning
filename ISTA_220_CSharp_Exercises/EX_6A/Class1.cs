using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A
{
    class Exercise6A
    {

        public void Run()
        {
            int[] arrayA = { 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Average(arrayA);
            Average(arrayB);
            Average(arrayC);
            Reverse(arrayA);
            Reverse(arrayB);
            Reverse(arrayC);
            Rotate(-1, 2, arrayA);
            Rotate(1, 2, arrayB);
            Rotate(-1, 4, arrayC);
            Sort(arrayC);
        }

        private void Sort(int[] arg)
        {
            foreach (var num in arg)
            {
                for (int i = 0; i < arg.Length - 1; i++)
                {
                    if (arg[i] > arg[i + 1])
                    {
                        int temp = arg[i];
                        arg[i] = arg[i + 1];
                        arg[i + 1] = temp;
                    }
                }
            }
            Console.Write($"The array sorted is ");
            foreach (var num in arg)
            {
                Console.Write(num);
            }
            Console.WriteLine();

        }

        private void Rotate(int direction, int places, int[] arg)
        {
            if (direction == -1)
            {
                for (int i = 0; i < places; i++)
                {
                    int initial = arg[0];
                    for (int j = 0; j < arg.Length - 1; j++)
                    { 
                        int tempData = arg[j + 1];
                        arg[j] = tempData;
                    }
                    arg[arg.Length - 1] = initial;
                }
                Console.Write($"The array rotated {places} times to the left is ");
                foreach (var num in arg)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
            if (direction == 1)
            {
                for (int i = 0; i < places; i++)
                {
                    int last = arg[arg.Length-1];
                    for (int j = arg.Length-2; j >= 0; j--)
                    {
                        int tempData = arg[j];
                        arg[j+1] = tempData;
                    }
                    arg[0] = last;
                }
                Console.Write($"The array rotated {places} times to the right is ");
                foreach (var num in arg)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }

        private static void Average(int[] arg)
        {
            int arraySum = 0;

            foreach (var num in arg)
            {
                arraySum += num;
            }

            double arrayAverage = arraySum / arg.Count();
            Console.WriteLine($"The average of the array is {arrayAverage}.");
        }
        private void Reverse(int[] arg)
        {
            Console.Write($"The reverse of is ");
            for (int i = 1; i <= arg.Length; i++)
            {
                Console.Write($"{arg[arg.Length - i]}");
            }
            Console.WriteLine();
        }
    }
}
