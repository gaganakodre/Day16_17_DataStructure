namespace DataStructureAlgorithem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(" 1.Permutation\n 2.BinarySearch\n 3.InsertionSort\n 4.Bubblesort\n 5.MergeSort\n 6.Anagram\n 7.PrimeRange\n 8.PrimePalindrome\n" +
                " 9.SearchSortGenerics\n 10.FindNumber\n 11.TaskDone\n 12.CustomMessage");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    PermutationsOfString permutationsofstring = new PermutationsOfString();
                    permutationsofstring.permutations();
                    break;
                case 2:
                    BinarySearchProb binarysearchprob = new BinarySearchProb();
                    binarysearchprob.binarySearch();
                    break;
                case 3:

                    String[] arr1 = { "Bridgelabsz", "I", "from", "am" };
                    int n = arr1.Length;

                    // Function to perform sorting
                    InsertionSort.sort(arr1, n);
                    // Calling the function to print result
                    break;
                case 4:
                    int[] arr2 = { 64, 34, 25, 12, 22, 11, 90 };
                    BubbleSort.bubbleSort(arr2);
                    Console.WriteLine("Sorted array");
                    BubbleSort.printArray(arr2);
                    break;
                case 5:
                    int[] arr3 = { 12, 11, 13, 5, 6, 7 };
                    Console.WriteLine("Given Array");
                    MergeSort.printArray(arr3);
                    MergeSort ob = new MergeSort();
                    ob.sort(arr3, 0, arr3.Length - 1);
                    Console.WriteLine("\nSorted array");
                    MergeSort.printArray(arr3);
                    break;
                case 6:
                    string str1 = "heart";
                    string str2 = "earth";

                    // Function call
                    if (Anagram.areAnagram(str1, str2))
                        Console.Write("The two strings are " +
                                      "anagram of each other");
                    else
                        Console.Write("The two strings are " +
                                      "not anagram of each other");
                    break;
                case 7:
                    PrimeRange.PrimeNumber();
                    break;
                case 8:
                    PrimePalindrome.countPal(100, 1000);
                    break;
                case 9:
                    SearchingAndSortingUsingGenerics searchingandsortingusinggenerics = new SearchingAndSortingUsingGenerics();
                    searchingandsortingusinggenerics.SearchingAndSorting();
                    break;
                case 10:
                    FindNumber1 findnumber = new FindNumber1();
                    FindNumber1.Find();
                    break;
                case 11:
                    TaskDoneByMaximumAmount taskdonebymaximumamount = new TaskDoneByMaximumAmount();
                    taskdonebymaximumamount.tasks();
                    break;
                case 12:
                    RegexClass.CustomMessageFirstNameRepalceMent();
                    RegexClass.CustomMessageFullNameRepalceMent();
                    RegexClass.CustomMessagePhoneNumberRepalceMent();
                    RegexClass.CustomMessagedateRepalceMent();
                    break;




            }
            
        }
    }
}
