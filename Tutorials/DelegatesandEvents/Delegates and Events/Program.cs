using System;
using System.Linq;

namespace Delegates_and_Events
{
    class Program
    {

        static char Rot13(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                c -= 'a';
                c += (char)13;
                c %= (char)26;
                c += 'a';
            }

            return c;
        }

        private static void TestRot13()
        {
            Console.WriteLine("hello, world");
            Console.WriteLine("hello, world".Select(Rot13).ToArray());
            Console.WriteLine("hello, world".Select(Rot13).ToArray()) ;
        }

        static void AddOneToEachValueInIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }
        }

        static void AddTenToEachValueInIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 10;
            }
        }

        static void ModFiveToEachValueInIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] %= 5;
            }
        }

        static void DoSomethingToEachValueInIntArray(int[] array, IntToIntMethod Something)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Something(array[i]);
            }
        }

        private delegate int IntToIntMethod(int value);

        static void Main(string[] args)
        {
            TestRot13();

            var values = Enumerable.Range(1, 10).ToArray();

            AddOneToEachValueInIntArray(values);
            AddTenToEachValueInIntArray(values);
            ModFiveToEachValueInIntArray(values);

            foreach (var v in values)
            {
                Console.WriteLine(v);
            }
        }
    }
}
