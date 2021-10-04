using System;

namespace tree_sort
{
    class TreeSort
    {
        public Node node;

        public TreeSort()
        {
            this.node = null;
        }

        public void insert(int key)
        {
            this.node = insertRecursive(node, key);
        }

        public Node insertRecursive(Node node, int key)
        {
            if (node == null)
            {
                node = new Node(key);
                return node;
            }

            if (key < node.key)
            {
                node.left = insertRecursive(node.left, key);
            }
            else if (key >= node.key)
            {
                node.right = insertRecursive(node.right, key);
            }

            return node;
        }

        public void inorderRecursive(Node node)
        {
            if (node != null)
            {
                inorderRecursive(node.left);
                Console.Write(node.key + " ");
                inorderRecursive(node.right);
            }
        }

        public void treeins(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                insert(array[i]);
            }
        }
    }
}