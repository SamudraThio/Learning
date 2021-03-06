﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections_and_Enumerators
{
    public class MyList<T> : IEnumerable<T>
    {
        // Contains Ts
        T[] backingStore = new T[1];

        // Track the number of Ts currently stored
        public int Length { get; private set; } = 0;
        public int Capacity => backingStore.Length;

        // Grow the backing array when needed
        private void GrowBackingArrayIfNeeded()
        {
            // Determine whether the array needs to be grown
            if (Length == backingStore.Length)
            {
                // If so, make a new larger array
                var tmp = new T[backingStore.Length * 2];

                // Copy the values from the old array into the new array
                for (int i = 0; i < backingStore.Length; i++)
                {
                    tmp[i] = backingStore[i];
                }

                // Replace the old array  
                backingStore = tmp;
            }
        }

        // Indexer 
        public T this[int index]
        {
            // Get and set value at index
            get => index < Length ? backingStore[index] 
                                  : throw new IndexOutOfRangeException();
            set
            {
                if (index <= Length)
                {
                    backingStore[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void AddAtIndex(int index, T value)
        {
            //Only if the index is within the bounds of the current list
            if (index < Length)
            {
                // Move all elements in or after the index to the right
                GrowBackingArrayIfNeeded();

                for (int i = Length ; i > index ; i--)
                {
                    backingStore[i] = backingStore[i - 1];
                }
                // Put the new value in the array
                backingStore[index] = value;
                Length += 1;
            }
        }

        // Remove value

        // Add value to end
        public void Add(T value)
        {
            GrowBackingArrayIfNeeded();
            backingStore[Length++] = value;
        }
        
        // Remove value at index
        public void RemoveAtIndex(int index)
        {
            while (index + 1 < Length)
            {
                backingStore[index] = backingStore[index + 1];
                index += 1;
            }
            Length -= 1;
        }


        public void Shrink()
        {
            var tmp = new T[Length];

            Array.Copy(backingStore, tmp, Length);

            backingStore = tmp;
        }

        // Enumerable
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return backingStore[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }

    public class AllTheInts : IEnumerator<int>, IEnumerable<int>
    {
        public int Current { get; set; } = -1;

        object IEnumerator.Current => Current;

        public void Dispose()
        { }

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            Current++;

            if (Current < 10)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            Current = -1 ;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach(var v in list.Reverse())
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();

            var myEnum = list.GetEnumerator();

            while(myEnum.MoveNext())
            {
                var v = myEnum.Current;
                Console.WriteLine(v);
            }

            myEnum.Dispose();

            Console.WriteLine();

            var allTheInts = new AllTheInts();

            allTheInts.Reset();
            while(allTheInts.MoveNext())
            {
                Console.WriteLine(allTheInts.Current);
            }
            allTheInts.Dispose();

            Console.WriteLine();

            foreach (var v in allTheInts)
                Console.WriteLine(v);

            Console.WriteLine();

            allTheInts.Reset();
            allTheInts.Skip(4).Take(4).ToList().ForEach(Console.WriteLine);
        }
    }
}
