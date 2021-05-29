using System;
using System.Collections.Generic;

namespace SortMethods
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T data)
        {
            Data = data;
        }
    }

    public class BinaryTree<T>
        where T : IComparable<T>
    {
        private Node<T> _root;

        public void AddNode(T data)
        {
            if (_root == null)
                _root = new Node<T>(data);
            else
                AddToTree(data, _root);
        }

        private void AddToTree(T data, Node<T> current)
        {
            if (data.CompareTo(current.Data) < 0) ////
            {
                if (current.Left == null)
                    current.Left = new Node<T>(data);
                else
                {
                    AddToTree(data, current.Left);
                }
            }

            else
            {
                if (current.Right == null)
                    current.Right = new Node<T>(data);
                else
                {
                    AddToTree(data, current.Right);
                }
            }
        }

        public T[] GetData()
        {
            List<T> result = new List<T>();
            Recursive(result, _root);
            return result.ToArray();
        }

        private void Recursive(List<T> result, Node<T> current)
        {
            if (current == null) return;
            Recursive(result, current.Left);
            result.Add(current.Data);
            Recursive(result, current.Right);
        }
    }

    public static class BinaryTreeSort
    {
        public static void Sort<T>(ref T[] array)
            where T : IComparable<T>
        {
            BinaryTree<T> tree = new BinaryTree<T>();
            foreach (var num in array)
            {
                tree.AddNode(num);
            }

            array = tree.GetData();
        }
    }
}