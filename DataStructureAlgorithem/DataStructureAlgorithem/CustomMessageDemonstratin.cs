using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DataStructureAlgorithem
{
    //public class RegexClass
    //{
    //    public Regex FirstNameRegex = new Regex(@"^(A-Z)[1](A-Za-z)[3,]?$");
    //    public Regex FullNameRegex = new Regex(@"^(A-Z)[1](A-Za-z)[4,]?$");
    //    public Regex PhoneNumberRegex = new Regex(@"^(91){1}\s[0-9](10)?$");
    //    public void ValidateFullNameRegex(string FullName)
    //    {
    //        Console.WriteLine("\nName:" + FullName);
    //        if (FullNameRegex.IsMatch(FullName))
    //            Console.WriteLine("valid FullName");
    //        else
    //            Console.WriteLine("invalid Fullname");
    //    }
    //    public void ValidatePhoneNumberRegex(string PhoneNumber)
    //    {
    //        Console.WriteLine("\nPhoneNumber:" + PhoneNumber);
    //        if (FullNameRegex.IsMatch(PhoneNumber))
    //            Console.WriteLine("valid phonenumber");
    //        else
    //            Console.WriteLine("invalid phonenumbre");
    //    }
    //    public void ValidateFirstNameRegex(string FirstName)
    //    {
    //        Console.WriteLine("\nFirstName:" + FirstName);
    //        if (FirstNameRegex.IsMatch(FirstName))
    //            Console.WriteLine("valid FirstName");
    //        else
    //            Console.WriteLine("invalid Firstname");
    //    }


    //}
    public class RegexClass
    {
        public static void CustomMessageFullNameRepalceMent()
        {
            string input = "Shreegowri";
            string pattern = "(A - Z)[1](A - Za - z)[5 ,]/s(A - Za - z)[4 ,] ";
            string replacement = " Koder ";
            string result = Regex.Replace(input, pattern, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
        }
        //public static void CustomMessageFirstNameRepalceMent()
        //{
        //    string input = "Shreegowri";
        //    string pattern = "(A - Z)[1](A - Za - z)[5 ,]/s(A - Za - z)[4 ,] ";
        //    string replacement = " Koder ";
        //    string result = Regex.Replace(input, pattern, replacement);

        //    Console.WriteLine("Original String: {0}", input);
        //    Console.WriteLine("Replacement String: {0}", result);
        //}
        //public static void CustomMessagePhoneNumberRepalceMent()
        //{
        //    string input = "+919148902060";
        //    string pattern = "\\s+";
        //    string replacement = " ";
        //    string result = Regex.Replace(input, pattern, replacement);

        //    Console.WriteLine("Original String: {0}", input);
        //    Console.WriteLine("Replacement String: {0}", result);
        //}
    }
}

