using System;

namespace Thio_EX_2A
{
    class CalculatingAverages
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application will accept 10 numbers from 0 to 100 and report their sum.");
            double sumInput = 0.0;
            double currentSum = 0.0;

            for (int i = 1; i <= 10; i++)
            {
            sumloop:
                Console.Write($"{i}. Input a number between 0 and 100 to be added: ");

                sumInput = double.Parse(Console.ReadLine());
                if (sumInput < 0 || sumInput > 100)

                {
                    Console.WriteLine("The input is out of range");
                    goto sumloop;
                }

                currentSum = sumInput + currentSum;
            }
            Console.WriteLine($"The sum is {currentSum}");

            Console.WriteLine("This application will now accept 10 numbers from 0 to 100, average them, then report a letter grade.");
            double inputNumber = 0.0;
            double avg = 0.0;
            double currentTotal = 0.0;

            for (int i = 1; i <= 10; i++)
            {
            avgloop:
                Console.Write($"{i}. Input 10 numbers between 0 and 100 to be added: ");

                inputNumber = double.Parse(Console.ReadLine());
                if (inputNumber < 0 || inputNumber > 100)

                {
                    Console.WriteLine("The input is out of range");
                    goto avgloop;
                }
                currentTotal = inputNumber + currentTotal;
            }
            avg = currentTotal / 10.0;
            {
                if (avg >= 90.0)
                {
                    Console.WriteLine($"The average grade is {avg}% and the letter grade is A");
                }
                else if (avg >= 80.0)
                {
                    Console.WriteLine($"The average grade is {avg}% and the letter grade is B");
                }
                else if (avg >= 70.0)
                {
                    Console.WriteLine($"The average grade is {avg}% and the letter grade is C");
                }
                else if (avg >= 60.0)
                {
                    Console.WriteLine($"The average grade is {avg}% and the letter grade is D");
                }
                else if (avg >= 0.0)
                {
                    Console.WriteLine($"The average grade is {avg}% and the letter grade is F");
                }

            }

            Console.WriteLine("The application will now accept an arbitary number test scores specified by you between 0 to 100, average them, and report a letter grade.");
        InitialLoop:
            Console.Write("Number of tests scores you would like to submit: ");
            int j = int.Parse(Console.ReadLine());
            if (j <= 0)
            {
                Console.WriteLine("The input is out of range");
                goto InitialLoop;
            }
            double arbitaryInput = 0.0;
            double arbitaryAvg = 0.0;
            double arbitaryTotal = 0.0;

            for (int i = 1; i <= j; i++)
            {
            arbitaryloop:
                Console.Write($"{i}. Input {j} numbers between 0 and 100 to be added: ");

                arbitaryInput = double.Parse(Console.ReadLine());
                if (arbitaryInput < 0 || arbitaryInput > 100)

                {
                    Console.WriteLine("The input is out of range");
                    goto arbitaryloop;
                }
                arbitaryTotal = arbitaryInput + arbitaryTotal;
            }
            arbitaryAvg = arbitaryTotal / j;
            {
                if (arbitaryAvg >= 90.0)
                {
                    Console.WriteLine($"The average grade is {arbitaryAvg}% and the letter grade is A");
                }
                else if (arbitaryAvg >= 80.0)
                {
                    Console.WriteLine($"The average grade is {arbitaryAvg}% and the letter grade is B");
                }
                else if (arbitaryAvg >= 70.0)
                {
                    Console.WriteLine($"The average grade is {arbitaryAvg}% and the letter grade is C");
                }
                else if (arbitaryAvg >= 60.0)
                {
                    Console.WriteLine($"The average grade is {arbitaryAvg}% and the letter grade is D");
                }
                else if (arbitaryAvg >= 0.0)
                {
                    Console.WriteLine($"The average grade is {arbitaryAvg}% and the letter grade is F");
                }
            }
            Console.WriteLine("The application will accept multiple test scores specified between 0 to 100, average them, and report a letter grade.");
            double userInput = 0.0;
            double userAvg = 0.0;
            double userTotal = 0.0;
            int k = 0;

            for (; ; )
            {
            userloop:
                Console.Write("Input numbers between 0 and 100 to be added, if you would like to finish enter \"1337\": ");

                userInput = double.Parse(Console.ReadLine());
                if (userInput == 1337.0)
                    break;
                else if (userInput < 0 || userInput > 100)
                {
                    Console.WriteLine("The input is out of range");
                    goto userloop;
                }
                else if (userInput >= 0 || userInput <= 100)
                {
                    userTotal = userInput + userTotal;
                    k++;
                }

            }
            userAvg = userTotal / k;
            {
                if (userAvg >= 90.0)
                {
                    Console.WriteLine($"The average grade is {userAvg}% and the letter grade is A");
                }
                else if (userAvg >= 80.0)
                {
                    Console.WriteLine($"The average grade is {userAvg}% and the letter grade is B");
                }
                else if (userAvg >= 70.0)
                {
                    Console.WriteLine($"The average grade is {userAvg}% and the letter grade is C");
                }
                else if (userAvg >= 60.0)
                {
                    Console.WriteLine($"The average grade is {userAvg}% and the letter grade is D");
                }
                else if (userAvg >= 0.0)
                {
                    Console.WriteLine($"The average grade is {userAvg}% and the letter grade is F");
                }
            }
        }
    }
}
