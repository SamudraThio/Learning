using System;
using System.Drawing;
using System.Xml.Schema;

namespace EX_7A
{
    class Roulette
    {
        public void Run()
        {
            int[] numbers = { 00, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            string[] colors = new string[] { "Green", "Green", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red"};

            Random rand = new Random();

            var (userBet, userGuess) = Bet();
            int prize = Spin(rand, numbers);
            if (userGuess == prize)
            {
                Console.WriteLine("You win!");
            }
            Console.WriteLine();
            Winnings(prize, userBet, colors, numbers);
        }

        private void Winnings(int prize, int userBet, string[] colors, int[] numbers)
        {
            Console.WriteLine("Possible Winnings:");
            NumberWin(prize, userBet);
            OddOrEven(prize, userBet);
            ColorWin(prize, colors, userBet);
            LowOrHigh(prize, userBet);
            Dozens(prize, userBet);
            Columns(prize, userBet);
            Street(prize, userBet);
            DoubleRows(prize, userBet);
            Split(prize, userBet, numbers);
            Corner(prize, userBet, numbers);

        }

        private void Corner(int prize, int userBet, int[] numbers)
        {
            if (prize == 0)
            {
                Console.WriteLine("Can't corner with a 0. No winnings.");
            }
            else if (prize == 1)
            {
                Console.WriteLine($"Corner Options:");
                Console.WriteLine($"{prize}-{prize + 1}-{prize + 3}-{prize + 4} Corner: {userBet} * 9 = {userBet * 9}");
            }
            else if (prize == 34)
            {
                Console.WriteLine($"Corner Options:");
                Console.WriteLine($"{prize - 3}-{prize - 2}-{prize}-{prize + 1} Corner: {userBet} * 9 = {userBet * 9}");
            }
            else if ((prize + 2) % 3 == 0)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize - 3}-{prize - 2}-{prize}-{prize + 1} Corner: {userBet} * 9 = {userBet * 9}");
                Console.WriteLine($"{prize}-{prize + 1}-{prize + 3}-{prize + 4} Corner: {userBet} * 9 = {userBet * 9}");
            }
            else if (prize == 2)
            {
                Console.WriteLine($"Corner Options:");
                Console.WriteLine($"{prize}-{prize + 1}-{prize + 3}-{prize + 4} Corner: {userBet} * 9 = {userBet * 9}");
                Console.WriteLine($"{prize - 1}-{prize}-{prize + 2}-{prize + 3} Corner: {userBet} * 9 = {userBet * 9}");
            }
            else if (prize == 35)
            {
                Console.WriteLine($"Corner Options:");
                Console.WriteLine($"{prize - 3}-{prize - 2}-{prize}-{prize + 1} Corner: {userBet} * 9 = {userBet * 9}");
                Console.WriteLine($"{prize - 4}-{prize - 3}-{prize - 1}-{prize} Corner: {userBet} * 9 = {userBet * 9}");
            }
            else if ((prize + 1) % 3 == 0)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize - 4}-{prize - 3}-{prize - 1}-{prize} Corner: {userBet} * 9 = {userBet * 9}");
                Console.WriteLine($"{prize - 3}-{prize - 2}-{prize}-{prize + 1} Corner: {userBet} * 9 = {userBet * 9}");
                Console.WriteLine($"{prize - 1}-{prize}-{prize + 2}-{prize + 3} Corner: {userBet} * 9 = {userBet * 9}");
                Console.WriteLine($"{prize}-{prize + 1}-{prize + 3}-{prize + 4} Corner: {userBet} * 9 = {userBet * 9}");
            }
            else if (prize == 3)
            {
                Console.WriteLine($"Corner Options:");
                Console.WriteLine($"{prize - 1}-{prize}-{prize + 2}-{prize + 3} Corner: {userBet} * 9 = {userBet * 9}");
            }
            else if (prize == 36)
            {
                Console.WriteLine($"Corner Options:");
                Console.WriteLine($"{prize - 4}-{prize - 3}-{prize - 1}-{prize} Corner: {userBet} * 9 = {userBet * 9}");
            }
            else if ((prize + 1) % 3 == 0)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize - 4}-{prize - 3}-{prize - 1}-{prize} Corner: {userBet} * 9 = {userBet * 9}");
                Console.WriteLine($"{prize - 1}-{prize}-{prize + 2}-{prize + 3} Corner: {userBet} * 9 = {userBet * 9}");
            }
        }

            private void Split(int prize, int userBet, int[] numbers)
        {
            if (prize == 0)
            {
                Console.WriteLine("Can't split with a 0. No winnings.");
            }
            else if (prize == 1)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize}-{prize + 1} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize + 3} Split: {userBet} * 18 = {userBet * 18}");
            }
            else if (prize == 34)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize}-{prize + 1} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize - 3} Split: {userBet} * 18 = {userBet * 18}");
            }
            else if ((prize + 2) % 3 == 0)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize}-{prize + 1} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize + 3} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize - 3} Split: {userBet} * 18 = {userBet * 18}");
            }
            else if (prize == 2)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize}-{prize + 1} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize + 3} Split: {userBet} * 18 = {userBet * 18}");
            }
            else if (prize == 35)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize}-{prize + 1} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize - 3} Split: {userBet} * 18 = {userBet * 18}");
            }
            else if ((prize + 1) % 3 == 0)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize}-{prize + 1} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize + 3} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize - 3} Split: {userBet} * 18 = {userBet * 18}");
            }
            else if (prize == 3)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize}-{prize + 1} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize + 3} Split: {userBet} * 18 = {userBet * 18}");
            }
            else if (prize == 36)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize}-{prize + 1} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize - 3} Split: {userBet} * 18 = {userBet * 18}");
            }
            else if (prize % 3 == 0)
            {
                Console.WriteLine($"Split Options:");
                Console.WriteLine($"{prize}-{prize + 1} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize + 3} Split: {userBet} * 18 = {userBet * 18}");
                Console.WriteLine($"{prize}-{prize - 3} Split: {userBet} * 18 = {userBet * 18}");
            }
        }

        private void DoubleRows(int prize, int userBet)
        {
            if (prize == 0)
            {
                Console.WriteLine("0 is Not in any Double Row: No winnings.");
            }
            if (prize > 0 && prize <= 6)
            {
                Console.WriteLine($"Double Row 1-6: {userBet} * 6 = {userBet * 6}");

            }
            if (prize >= 4 && prize <= 9)
            {
                Console.WriteLine($"Double Row 4-9: {userBet} * 6 = {userBet * 6}");
            }
            if (prize >= 7 && prize <= 12)
            {
                Console.WriteLine($"Double Row 7-12: {userBet} * 6 = {userBet * 6}");
            }
            if (prize >= 10 && prize <= 15)
            {
                Console.WriteLine($"Double Row 10-15: {userBet} * 6 = {userBet * 6}");
            }
            if (prize >= 13 && prize <= 18)
            {
                Console.WriteLine($"Double Row 13-18: {userBet} * 6 = {userBet * 6}");
            }
            if (prize >= 16 && prize <= 21)
            {
                Console.WriteLine($"Double Row 16-21: {userBet} * 6 = {userBet * 6}");
            }
            if (prize >= 19 && prize <= 24)
            {
                Console.WriteLine($"Double Row 19-24: {userBet} * 6 = {userBet * 6}");
            }
            if (prize >= 22 && prize <= 27)
            {
                Console.WriteLine($"Double Row 22-27: {userBet} * 6 = {userBet * 6}");
            }
            if (prize >= 25 && prize <= 30)
            {
                Console.WriteLine($"Double Row 25-30: {userBet} * 6 = {userBet * 6}");
            }
            if (prize >= 28 && prize <= 33)
            {
                Console.WriteLine($"Double Row 28-33: {userBet} * 6 = {userBet * 6}");
            }
            if (prize >= 31 && prize <= 36)
            {
                Console.WriteLine($"Double Row 31-36: {userBet} * 6 = {userBet * 6}");
            }

        }

        private void Street(int prize, int userBet)
        {
            if (prize == 0)
            {
                Console.WriteLine("0 is Not in the Streets: No winnings.");
            }
            else if (prize <=3)
            {
                Console.WriteLine($"First Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 6)
            {
                Console.WriteLine($"Second Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 9)
            {
                Console.WriteLine($"Third Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 12)
            {
                Console.WriteLine($"Fourth Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 15)
            {
                Console.WriteLine($"Fifth Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 18)
            {
                Console.WriteLine($"Sixth Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 21)
            {
                Console.WriteLine($"Seventh Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 24)
            {
                Console.WriteLine($"Eight Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 27)
            {
                Console.WriteLine($"Ninth Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 30)
            {
                Console.WriteLine($"Tenth Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 33)
            {
                Console.WriteLine($"Eleventh Street: {userBet} * 12 = {userBet * 12}");
            }
            else if (prize <= 36)
            {
                Console.WriteLine($"Twelveth Street: {userBet} * 12 = {userBet * 12}");
            }
        }

        private void Columns(int prize, int userBet)
        {
            if (prize == 0)
            {
                Console.WriteLine("0 is Not in the Columns: No winnings.");
            }
            else if (prize % 3 == 0)
            {
                Console.WriteLine($"Third Column: {userBet} * 3 = {userBet * 3}");
            }
            else if ((prize +1) % 3 == 0)
            {
                Console.WriteLine($"Second Column: {userBet} * 3 = {userBet * 3}");
            }
            else
            {
                Console.WriteLine($"First Column: {userBet} * 3 = {userBet * 3}");
            }
        }

        private void Dozens(int prize, int userBet)
        {
            if (prize == 0)
            {
                Console.WriteLine("0 is Not in the Dozens: No winnings.");
            }
            else if (prize <= 12)
            {
                Console.WriteLine($"Between 1-12: {userBet} * 3 = {userBet * 3}");
            }
            else if (prize <= 24)
            {
                Console.WriteLine($"Between 13-24: {userBet} * 3 = {userBet * 3}");
            }
            else
            {
                Console.WriteLine($"Between 25-36: {userBet} * 3 = {userBet * 3}");
            }
        }

        private void LowOrHigh(int prize, int userBet)
        {
            if (prize == 0)
            {
                Console.WriteLine("0 is Neither Lows/Highs: No winnings.");
            }
            else if (prize <= 18)
            {
                Console.WriteLine($"Lows: {userBet} * 2 = {userBet * 2}");
            }
            else
            {
                Console.WriteLine($"Highs: {userBet} * 2 = {userBet * 2}");
            }
        }

        private void ColorWin(int prize, string[] colors, int userBet)
        {
            string result = colors[prize + 1];
            if (result == "Green")
            {
                Console.WriteLine("0 is Neither Red nor Black: No winnings.");
            }
            else if (result == "Red")
            {
                Console.WriteLine($"Red: {userBet} * 2 = {userBet * 2}");
            }
            else if (result == "Black")
            {
                Console.WriteLine($"Black: {userBet} * 2 = {userBet * 2}");
            }
        }

        public static void OddOrEven(int prize, int userBet)
        {
            if (prize == 0)
            {
                Console.WriteLine("0 is Neither Evens/Odds: No winnings.");
            }
            else if (prize % 2 == 0)
            {
                Console.WriteLine($"Evens: {userBet} * 2 = {userBet * 2}");
            }
            else
            {
                Console.WriteLine($"Odds: {userBet} * 2 = {userBet * 2}");
            }                    
        }

        private void NumberWin(int prize, int userBet)
        {
            if (prize == 0)
            {
                Console.WriteLine($"Numbers: {userBet} * 72 = {userBet * 72}");
            }
            else
                Console.WriteLine($"Numbers: {userBet} * 36 = {userBet * 36}");
        }

        private (int, int) Bet()
        {
            MoneyLoop:
            Console.WriteLine("How much would you like to bet(Max Bet = 100)? ");
            int moneyBet = int.Parse(Console.ReadLine());
            if (moneyBet < 0 || moneyBet > 100)
            {
                Console.WriteLine("Please enter a number from 0-36");
                goto MoneyLoop;
            }
            Console.WriteLine();
            BetLoop:
            Console.WriteLine("What number would you like to bet on (0-36)?");
            int binBet = int.Parse(Console.ReadLine());
            if (binBet < 0 || binBet > 36)
            {
                Console.WriteLine("Please enter a number from 0-36");
                goto BetLoop;
            }   
            Console.WriteLine();
            return (moneyBet, binBet);
        }

        public int Spin(Random rand, int[] numbers)
        {
            Console.WriteLine("Spinning...");
            int nextSpin = rand.Next(0, 38);
            if (nextSpin == 0)
            {
                Console.WriteLine($"The spin landed on 00.");
            }
            else
            {
                Console.WriteLine($"The spin landed on {numbers[nextSpin]}.");
                nextSpin = numbers[nextSpin];
            }
            return nextSpin;
        }
    }
}