using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithem
{

    public class InsertionSort
    {
        // void printArraystring(string,int);

        // Function to Sort the array of string
        // according to lengths. This function
        // implements Insertion Sort.
        public static void sort(String[] s, int n)
        {
            for (int i = 1; i < n; i++)
            {
                String temp = s[i];

                // Insert s[j] at its correct position
                int j = i - 1;
                while (j >= 0 && temp.Length < s[j].Length)
                {
                    s[j + 1] = s[j];
                    j--;
                }
                s[j + 1] = temp;
            }
        }
        public static void printArraystring(String[] str, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(str[i] + " ");
        }
    }

}
//o/p:I am from Bridgelabsz

