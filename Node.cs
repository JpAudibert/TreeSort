namespace tree_sort
{
    // defining class Node
    class Node
    {
        // defining Node attributes
        public int key;
        public Node left, right;

        // constructing the object
        public Node(int item)
        {
            this.key = item;
            this.left = this.right = null;
        }
    }
}