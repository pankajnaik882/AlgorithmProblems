using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmProblemDemo
{
    public class Program
    {
        public static void PrimeNumber()
        {
            int num1, num2, i, j, flag;

            Console.WriteLine("Enter Lowest of value between 0 to 1000 : ");

            num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Lowest of value between 0 to 1000: ");


            num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Prime numbers between " +
                              "{0} and {1} are: ", num1, num2);


            for (i = num1; i <= num2; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                // flag variable to tell
                // if i is prime or not
                flag = 1;
                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
        public static void Main(string[] args)
        {
            Program.PrimeNumber();
        }
    }
}