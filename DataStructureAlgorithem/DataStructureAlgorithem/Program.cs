namespace DataStructureAlgorithem
{
    class Program
    {
        public static void Main(String[] args)
        {
            //uc2:BST
            ////BinaryTree binaryTree = new BinaryTree();
            ////String[] arr = { "contribute", "geeks", "ide", "practice" };
            ////String x = "ide";
            ////int result = BinaryTree.binarySearch(arr, x);

            ////if (result == -1)
            ////    Console.WriteLine("Element not present");
            ////else
            ////    Console.WriteLine("Element found at "
            ////                    + "index " + result);
            //uc3:Insertion SORT
            //String[] arr1 = { "Bridgelabsz", "I", "from", "am" };
            //int n = arr1.Length;

            //// Function to perform sorting
            //InsertionSort.sort(arr1, n);
            //// Calling the function to print result
            //InsertionSort.printArraystring(arr1, n);
            //uc4:BubbleSort
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort.bubbleSort(arr);
            Console.WriteLine("Sorted array");
            BubbleSort.printArray(arr);
        }
    }
}