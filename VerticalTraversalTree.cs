using System;
using System.Collections.Generic;



namespace TreeVertical
{
    public class Program
    {
        public static void Main()
        {
            Node root = new Node(5);
            root.left = new Node(2);
            root.right = new Node(4);
            root.left.left = new Node(1);
            root.left.right = new Node(7);

            TraversalVertical trav = new TraversalVertical();
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            dict = trav.TraversalVert(root, 0, dict);


            foreach (KeyValuePair<int, List<int>> item in dict)
            {
                foreach (var element in item.Value)
                {
                    Console.Write(element + ", ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }

    //traversal tree in the vertical level
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int value)
        {
            this.data = value;
            this.left = null;
            this.right = null;
        }
    }

    public class TraversalVertical
    {
        public void AddNodeToTree(int level, Node node, Dictionary<int, List<int>> dict)
        {
            if (node == null)
                return;

            if (dict.ContainsKey(level))
            {
                dict[level].Add(node.data);
            }
            else
            {
                List<int> list = new List<int>();
                list.Add(node.data);
                dict.Add(level, list);
            }
        }

        public Dictionary<int, List<int>> TraversalVert(Node root, int level, Dictionary<int, List<int>> dict)
        {
            if (root != null)
            {
                AddNodeToTree(level, root, dict);

                if (root.left != null)
                    this.TraversalVert(root.left, level - 1, dict);
                if (root.right != null)
                    this.TraversalVert(root.right, level + 1, dict);
            }
            return dict;
        }
    }
}


