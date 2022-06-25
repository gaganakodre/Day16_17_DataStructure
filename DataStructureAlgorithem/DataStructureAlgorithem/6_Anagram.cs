using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithem
{
    class Anagram
    {

        static int NO_OF_CHARS = 256;

        // function to check if two strings
        // are anagrams of each other
        public static bool areAnagram(char[] str1,
                               char[] str2)
        {

            // If both strings are of different
            // Length. Removing this condition
            // will make the program fail for
            // strings like "aaca" and "aca"
            if (str1.Length != str2.Length)
                return false;

            // Create a count array and initialize
            // all values as 0
            int[] count = new int[NO_OF_CHARS];
            int i;

            // For each character in input strings,
            // increment count in the corresponding
            // count array
            for (i = 0; i < str1.Length; i++)
            {
                count[str1[i] - 'a']++;
                count[str2[i] - 'a']--;
            }

            // See if there is any non-zero
            // value in count array
            for (i = 0; i < NO_OF_CHARS; i++)
                if (count[i] != 0)
                {
                    return false;
                }

            return true;
        }
    }
}
//o/p:The two strings are anagram of each other