using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace AlgorithmProblemDemo
{
    public class Program
    {

        // HashSet to hold dictionary values
        private static HashSet<string> dictionary = new HashSet<string>();


        // Returns true if the word can be segmented into parts such
        // that each part is contained in dictionary
        public static bool wordBreak(string word)
        {
            int size = word.Length;

            // Base case
            if (size == 0)
                return true;

            // Else check for all words
            for (int i = 1; i <= size; i++)
            {
                // Divide the word into two parts, the prefix will have a length of i
                // and check if it is present in dictionary, if yes then we will check
                // for suffix of length size-i recursively. If both prefix and
                // suffix are present the word is found in dictionary.
                if (dictionary.Contains(word.Substring(0, i)) &&
                    wordBreak(word.Substring(i, size - i)))
                    return true;
            }

            // If all cases failed then return false
            return false;
        }
        static void Main(string[] args)
        {
            // Array of strings to be added in dictionary HashSet
            string[] temp_dictionary = { "mobile", "samsung", "sam", "sung",
                            "man", "mango", "icecream", "and",
                            "go", "i", "like", "ice", "cream" };

            // Loop to add all strings in dictionary HashSet
            foreach (string temp in temp_dictionary)
            {
                dictionary.Add(temp);
            }

            // Sample input cases
            Console.WriteLine(wordBreak("ilikesamsung"));
            Console.WriteLine(wordBreak("iiiiiiii"));
            Console.WriteLine(wordBreak(""));
            Console.WriteLine(wordBreak("ilikelikeimangoiii"));
            Console.WriteLine(wordBreak("samsungandmango"));
            Console.WriteLine(wordBreak("samsungandmangok"));
        }
    }
}
           

        