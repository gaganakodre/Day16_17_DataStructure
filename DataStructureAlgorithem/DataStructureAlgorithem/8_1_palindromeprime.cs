using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithem
{
    class PrimePalindrome
    {

        // A function to check 
        // if n is palindrome 
        public static bool isPalindrome(int n)
        {

            // Find reverse of n 
            int rev = 0;
            for (int i = n; i > 0; i /= 10)
            {
                rev = rev * 10 + i % 10;
            }

            // If n and rev are same, 
            // then n is palindrome 
            return (n == rev) ? true : false;
        }

        // prints palindrome between 
        // min and max 
        public static void countPal(int min,
                                    int max)
        {
            
            for (int i = min; i <= max; i++)
            {
                if(PrimeRange.IsPrime(i)&& isPalindrome(i))
                {
                    Console.WriteLine(i);
                }
                
                //primenumber
                


            }
            




        }
    }
}

