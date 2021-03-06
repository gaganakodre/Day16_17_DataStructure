using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithem
{
    public class PrimeRange
    {
        public static void PrimeNumber()
        {
            int num, i, ctr, StartNum, LastNum;

            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.WriteLine("\n");
            

            Console.Write("Input starting number of range: ");
            StartNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            LastNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", StartNum, LastNum);

            for (num = StartNum; num <= LastNum; num++)
            {
                if(IsPrime(num))
                {
                    Console.Write(num);
                }


            }

            Console.Write("\n");

        }
        public static bool IsPrime(int num)
        {
           int  ctr = 0;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && num != 1)
                return true;
           
            else
                return false;
        }
    }
}
//o/p:Find the prime numbers within a range of numbers:
//---------------------------------------------------

//Input starting number of range: 2
//Input ending number of range : 1000
//The prime numbers between 2 and 1000 are :
//2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101
//103 107 109 113 127 131 137 139 149 151 157 163 167 173 179 181 191 193 197 199
//211 223 227 229 233 239 241 251 257 263 269 271 277 281 283 293 307 311 313 317 331 337
//347 349 353 359 367 373 379 383 389 397 401 409 419 421 431 433 439 443 449 457 461 463
//467 479 487 491 499 503 509 521 523 541 547 557 563 569 571 577 587 593 599 601 607 613
//617 619 631 641 643 647 653 659 661 673 677 683 691 701 709 719 727 733 739 743 751 757
//761 769 773 787 797 809 811 821 823 827 829 839 853 857 859 863 877 881 883 887 907 911
//919 929 937 941 947 953 967 971 977 983 991 997
