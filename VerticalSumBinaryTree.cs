//Binary tree 1,2,3, 4,5,6,7 sum of vertical lines output 4 ,2 , 12, ,3,7        
//        1
//      /   \
//     2     3
//    / \   / \
//   4   5 6   7



using System;
using System.Collections.Generic;

class Program
{
    public class Node
    {
        public int Data;
        public Node Left, Right;

        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }
    public class VerticalSum
    {
        public static void VerticalSumBinaryTree(Node root)
        {
            Dictionary<int, int> hdSum = new Dictionary<int, int>();

            CalculateVerticalSum(root, 0, hdSum);

            foreach (var key in new SortedSet<int>(hdSum.Keys))
            {
                Console.WriteLine(hdSum[key]);
            }
        }

        private static void CalculateVerticalSum(Node node, int hd, Dictionary<int, int> hdSum)
        {
            if (node == null)
                return;
            if (!hdSum.ContainsKey(hd))
            {
                hdSum[hd] = 0;
            }
            hdSum[hd] += node.Data;

            CalculateVerticalSum(node.Left, hd - 1, hdSum);
            CalculateVerticalSum(node.Right, hd + 1, hdSum);
        }
    }

    static void Main()
    {
        Node root = new Node(1);
        root.Left = new Node(2);
        root.Right = new Node(3);
        root.Left.Left = new Node(4);
        root.Left.Right = new Node(5);
        root.Right.Left = new Node(6);
        root.Right.Right = new Node(7);

        VerticalSum.VerticalSumBinaryTree(root);
    }
}
