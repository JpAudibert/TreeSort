namespace tree_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeSort tree = new TreeSort();
            int[] array = {16, 18, 1, 10, 12};
            tree.treeins(array);
            tree.inorderRecursive(tree.node);
        }
    }
}
