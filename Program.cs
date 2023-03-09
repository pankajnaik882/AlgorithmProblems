using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace AlgorithmProblemDemo
{
    public class Program
    {
        public static void DisplayFname()
        {
            string inputString = "<<name>> First Name ";
            string firstName = "John"; // Replace with your first name

            string outputString = Regex.Replace(inputString, "<<name>>", firstName);

            Console.WriteLine(outputString);
        }
        public static void DisplayFullName()
        {
            string input = "Hello <<full name>>! How are you?";
            string fullName = "John Doe"; // Replace this with the actual full name

            string output = Regex.Replace(input, "<<full name>>", fullName);
            Console.WriteLine(output); // Outputs: Hello John Doe! How are you?

        }

        public static void DisplayMobile()
        {
            string input = "My mobile number is 91-9876543210. ";
            string contactNumber = "1234567890";

            string output = Regex.Replace(input, @"91-\d{10}", contactNumber);
            Console.WriteLine(output);
        }
        public static void DisplayCurrentDate()
        {
            string input = "Today's date is 02/28/2023";
            DateTime currentDate = DateTime.Now.Date;

            string output = Regex.Replace(input, @"\d{2}/\d{2}/\d{4}", currentDate.ToString("MM/dd/yyyy"));
            Console.WriteLine(output); // Outputs: Today's date is 02/28/2023. Please confirm the order by 02/28/2023.
        }

            static void Main(string[] args)
        {
            Program.DisplayFname();
            Program.DisplayFullName();
            Program.DisplayMobile();
            Program.DisplayCurrentDate();
        }

    }
}
           

        