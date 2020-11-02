using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;

namespace AlgoritmosPesquisa
{
    public static class BinarySearchTree
    {
        public static Node NewNode(int value)
        {
            var root = new Node();
            root.value = value;
            root.left = null;
            root.right = null;
            return root;
        }

        public static Node InsertNode(Node root, int value)
        {
            if (root is null)
            {
                root = NewNode(value);
            }
            else if (value < root.value)
            {
                root.left = InsertNode(root.left, value);
            }
            else
            {
                root.right = InsertNode(root.right, value);
            }
            return root;
        }

        public static Node InsertNode(Node root, params int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                root = InsertNode(root, values[i]);
            }
            return root;
        }

        public static void InOrder(Node root)
        {
            if (root is null)
                return;
            InOrder(root.left);
            Console.Write($"{root.value}  ");
            InOrder(root.right);
        }

        public static bool Search(Node tree, int value)
        {
            if (tree is null)
            {
                return false;
            }
            else if (value == tree.value)
            {
                return true;
            }
            else if (value < tree.value)
            {
                return Search(tree.left, value);
            }
            else
            {
                return Search(tree.right, value);
            }
        }

        public static Dictionary<int, bool> Search(Node tree, params int[] values)
        {
            Dictionary<int, bool> numbersInTree = new Dictionary<int, bool>();
            for (int i = 0; i < values.Length; i++)
            {
                numbersInTree.Add(values[i], Search(tree, values[i]));
            }
            return numbersInTree;
        }
    }

    public class Node
    {
        public int value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
    }
}