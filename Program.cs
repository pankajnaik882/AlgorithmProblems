using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmProblemDemo
{
    public class Program
    {
      
        static void Main(string[] args)
        {
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            for(int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Prime Number : {0}",i);
                }
            }

            Console.WriteLine("Palindrome numbers in the range [{0}, {1}]:", start, end);

            for (int num = start; num <= end; num++)
            {
                if (IsPalindrome(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = reversedNum * 10 + digit;
                num /= 10;
            }

            return originalNum == reversedNum;
        }
    }
}

        