using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace AlgorithmProblemDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string string1, rev;
            Console.WriteLine("Enter the String to check is Palindrome or not ");
            string1 = Console.ReadLine();
            string s1 = string1.ToLower();
            char[] ch = s1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = s1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + string1 + " is not a Palindrome!");
            }
    

        }
    }
}
           

        