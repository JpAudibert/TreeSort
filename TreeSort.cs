using System;

namespace tree_sort
{
    // defining TreeSort class
    class TreeSort
    {
        // defining TreeSort attributes
        public Node node;

        // constructing the object
        public TreeSort()
        {
            this.node = null;
        }

        //
        public void insert(int key)
        {
            // insert the values on the tree
            this.node = insertRecursive(node, key);
        }

        public Node insertRecursive(Node node, int key)
        {
            // verifies if the node exists
            if (node == null)
            {
                // if it doesn't, crates one and returns
                node = new Node(key);
                return node;
            }

            // if it exists it inserts recursively
            if (key < node.key)
            {
                // on the left if smaller than the previous node
                node.left = insertRecursive(node.left, key);
            }
            else if (key >= node.key)
            {
                // on the right if greater than the previous node
                node.right = insertRecursive(node.right, key);
            }

            // returns the node
            return node;
        }

        public void inorderRecursive(Node node)
        {
            if (node != null)
            {
                // it keeps going left from the central point, if needed
                inorderRecursive(node.left);
                // then, it writes the value
                Console.Write(node.key + " ");
                // in the last case, the program "goes right" and prints the value
                inorderRecursive(node.right);
            }
        }

        public void treeInsert(int[] array)
        {
            //iterates the values to build the tree
            for (int i = 0; i < array.Length; i++)
            {
                insert(array[i]);
            }
        }
    }
}