using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmProblemDemo
{

    public class Program
    {
        public static void DisplayAnagram()
        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] chr1 = str1.ToLower().ToCharArray();
            char[] chr2 = str2.ToLower().ToCharArray();

            Array.Sort(chr1);
            Array.Sort(chr2);

            string val1 = new string(chr1);
            string val2 = new string(chr2);

            if (val1 == val2)
            {
                Console.WriteLine("This is Anagram");
            }
            else
            {
                Console.WriteLine("This is not Anagram");
            }
        }
        public static void Main(string[] args)
        {
            Program.DisplayAnagram();
        }
    }
}