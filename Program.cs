using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmProblemDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the N value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            for(i=0;i<N;i++)
            {
                var temp = (int)Math.Pow(2,i);
               // Console.WriteLine(temp);
                arr[i] = temp; 
                Console.WriteLine(arr[i]);
                //Console.WriteLine("Enter the Value to be Search in Array : ");
            }

            Console.WriteLine("Enter the Value to be Search in Array : ");
            int user = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == user)
                {
                    // Found the target number at index i
                    Console.WriteLine("Number is exist");
                    break;
                }

            }

        }

    }
}
           

        