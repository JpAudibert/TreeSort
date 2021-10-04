namespace tree_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a TreeSort object
            TreeSort tree = new TreeSort();
            // creating an array of random
            int[] array = {16, 18, 1, 10, 12};
            // inserting values in the tree
            tree.treeInsert(array);
            // starting point
            tree.inorderRecursive(tree.node);
        }
    }
}
