namespace DataStructureAlgorithem
{
    class Program
    {
        public static void Main(String[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            String[] arr = { "contribute", "geeks", "ide", "practice" };
            String x = "ide";
            int result = BinaryTree.binarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                + "index " + result);
        }
    }
}