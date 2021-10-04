namespace tree_sort
{
    class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            this.key = item;
            this.left = this.right = null;
        }
    }
}