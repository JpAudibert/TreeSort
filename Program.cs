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
            // 
            tree.treeInsert(array);
            tree.inorderRecursive(tree.node);
        }
    }
}
