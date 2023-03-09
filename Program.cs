using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmProblemDemo
{
    public class Program
    {
        public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Binary Sorted");
            foreach (var p in arr)
            {
                Console.WriteLine(p);
            }

        }
        static void Main(string[] args)
        {
            int[] a = { 78, 55, 45, 98, 13 };
            Program.BubbleSort(a);
        }

    }
}
           

        