using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmProblemDemo
{

   
    public class Program
    {
        public static void Display(char[] arr)
        {
            foreach (char c in arr)
            {
                Console.WriteLine(c + " ");
            }
        }
        public static void Main(string[] args)
        {
            char[] arr = { 'e', 'c','d','e','f'};
            
            //For this method array will be sorted.
            Array.Sort(arr);

            Console.WriteLine("The Element of sorted array : ");

            Display(arr);

            object s = 'h';

            result(arr, s);

            object s1 = 'a';

            result(arr, s1);
            
        }

        public static void result(char[] arr2, object k)
        {
            int res = Array.BinarySearch(arr2, k);
            if (res < 0)
            {
                Console.WriteLine("\nThe element to search for "
                                + "({0}) is not found.",
                            k);
            }
            else
            {
                Console.WriteLine("The element to search for "
                                      + "({0}) is at index {1}.",
                                  k, res);
            }
        }

    }
}