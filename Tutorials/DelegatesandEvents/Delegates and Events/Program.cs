using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_and_Events
{ 
    static class Util
    {
        public static IEnumerable<TReturn> Map<T, TReturn>(this IEnumerable<T> values, Func<T, TReturn> func)
        {
            foreach (var v in values)
                yield return func(v);
        }

        public static TReturn Fold<T, TReturn>(this IEnumerable<T> values, TReturn startingValue, Func<TReturn, T, TReturn> func)
        {
            TReturn accum = startingValue;

            foreach(var v in values)
            {
                accum = func(accum, v);
            }

            return accum;
        }

        public static T Fold1<T>(this IEnumerable<T> values, Func<T, T, T> func) 
            => values.Skip(1).Fold(values.First(), func);
    }

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

        static int AddOne(int i) => i + 1;
        static int AddTen(int i) => i + 10;
        static int ModFive(int i) => i % 5;

        static void Main(string[] args)
        {
            #region old
            TestRot13();

            var values = Enumerable.Range(1, 10).ToArray();

            AddOneToEachValueInIntArray(values);
            AddTenToEachValueInIntArray(values);
            ModFiveToEachValueInIntArray(values);

            foreach (var v in values)
            {
                Console.WriteLine(v);
            }
            #endregion

            Console.WriteLine();
            var differentValues = Enumerable.Range(1, 10).ToArray();
            // DoSomethingToEachValueInIntArray(differentValues, i => i + 1);
            // DoSomethingToEachValueInIntArray(differentValues, AddTen);
            // DoSomethingToEachValueInIntArray(differentValues, ModFive);

            IntToIntMethod theMethod = i => ModFive(AddTen(AddOne(i)));

            DoSomethingToEachValueInIntArray(differentValues, theMethod);

            foreach(var v in differentValues)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(Enumerable.Range(1, 10)
                                        .Fold(0, (a, b) => a+ b));

            Console.WriteLine(Enumerable.Range(1, 10)
                                        .Fold(0, (a, b) => a * b));
        }
    }
}
