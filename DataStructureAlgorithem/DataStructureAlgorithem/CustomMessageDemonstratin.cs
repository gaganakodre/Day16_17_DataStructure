using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DataStructureAlgorithem
{
    
    public class RegexClass
    {
        
        public static void CustomMessageFirstNameRepalceMent()
        {
            string input = "Shreegowri koder";
            string pattern = "\\s[a-z]+";
            string replacement = "";
            string FirstNameresult = System.Text.RegularExpressions.Regex.Replace(input, pattern, replacement);

            //Console.WriteLine("Original String: {0}", input);
            //Console.WriteLine("Replacement String: {0}", FirstNameresult);
            Console.WriteLine("Hello {0}:", FirstNameresult);
        }
        public static void CustomMessageFullNameRepalceMent()
        {
            string input = "Shreegowri koder";
            string pattern = "\\s+";
            string replacement = "";
            string FullNameresult = System.Text.RegularExpressions.Regex.Replace(input, pattern, replacement);

            //Console.WriteLine("Original String: {0}", input);
            //Console.WriteLine("Replacement String: {0}", FullNameresult);
            Console.WriteLine("We have your fullname as {0}:in our system",FullNameresult);
        }
        public static void CustomMessagePhoneNumberRepalceMent()
        {
            string input = "91_ 9154684655";
            string pattern = "[_]+";
            string replacement = "";
            string Phoneresult = System.Text.RegularExpressions.Regex.Replace(input, pattern, replacement);

            //Console.WriteLine("Original String: {0}", input);
            //Console.WriteLine("Replacement String: {0}", Phoneresult);
            Console.WriteLine("your contact number is {0}:",Phoneresult);
        }
        public static void CustomMessagedateRepalceMent()
        {
            string input = "01-/01-/-2016";
            string pattern = "[-]+";
            string replacement = "";
            string Dateresult = System.Text.RegularExpressions.Regex.Replace(input, pattern, replacement);

            //Console.WriteLine("Original String: {0}", input);
            //Console.WriteLine("Replacement String: {0}", Dateresult);
            Console.WriteLine("Please, let us know in case of any clarification Thank you BridgeLabz {0}:",Dateresult);
        }

        

        

    }
}

