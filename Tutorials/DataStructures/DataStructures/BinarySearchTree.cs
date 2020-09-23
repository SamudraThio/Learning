﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinarySearchTree<T> Left;
        public BinarySearchTree<T> Right;

        public T Value;

        public BinarySearchTree(T value)
        {
            Value = value;
        }

        public void Add(T newValue)
        {
            if (newValue.CompareTo(Value) == 0) throw new DuplicateValueInSetException();

            if (newValue.CompareTo(Value) < 0)
            {
                if (Left == null)
                {
                    Left = new BinarySearchTree<T>(newValue);
                }
                else
                {
                    Left.Add(newValue);
                }

            }
            else
            {
                if (Right == null)
                {
                    Right = new BinarySearchTree<T>(newValue);
                }
                else
                {
                    Right.Add(newValue);
                }
            }

        }

        public List<T> ToList()
        {
            var list = new List<T>();

            if (Left != null)
                list.AddRange(Left.ToList());

            list.Add(Value);

            if (Right != null)
                list.AddRange(Right.ToList());

            return list;
        }

        public static void TestBST()
        {
            var bst = new BinarySearchTree<int>(69);
            bst.Add(42);
            bst.Add(14);
            bst.Add(37);
            bst.Add(46);
            bst.Add(13);
            bst.Add(53);
            bst.Add(78);
            bst.Add(1);
            bst.Add(51);
            bst.Add(5);
            bst.Add(18);
            bst.Add(8);

            bst.ToList().ForEach(Console.WriteLine);
        }
    }
}
