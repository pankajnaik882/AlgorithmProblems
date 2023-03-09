using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace AlgorithmProblemDemo
{
    public class Program
    {

        class Bank
        {
            string name, address;
            char acc_type;
            float balance;
            // Function to open the account
            public void open_account()
            {
                name = "Aman Jhurani";
                Console.WriteLine("Enter your full name: " + name);
                address = "Surat";
                Console.WriteLine("Enter your address: " + address);
                acc_type = 'S';
                Console.WriteLine(
                    "What type of account you want to open saving(S) or Current(C): "
                    + acc_type);
                balance = 8000;
                Console.WriteLine(
                    "Enter How much money you want to deposit: "
                    + balance);
                Console.WriteLine("Account Created Successfully");
            }

            // Function to deposit the account
            public void deposit_money()
            {
                int Amount = 9500;
                Console.WriteLine(
                    "Enter how much money you want to deposit: "
                    + Amount);
                balance += Amount;
                Console.WriteLine("\nAvailable Balance: "
                                  + balance);
            }

            // Function to withdraw the account
            public void withdraw_money()
            {
                float amount = 3200;
                Console.WriteLine(
                    "Enter how much money you want to withdraw: "
                    + amount);
                balance -= amount;
                Console.WriteLine("\nAvailable balance: "
                                  + balance);
            }

            // Function to display the account
            public void display_account()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Address: " + address);
                Console.WriteLine("Type: " + acc_type);
                Console.WriteLine("Balance: " + balance + "\n");
            }
        }
        public static void Main(string[] args)
        {
            int choice;
            // Creating Customer Object of Bank Class
            Bank customer = new Bank();

            Console.WriteLine("\n1) Open account\n\n");
            // Calling open_account() function through customer
            // object.
            customer.open_account();
            Console.WriteLine("------------------------\n");

            Console.WriteLine("\n2) Deposit account\n\n");
            // Calling deposit_money() function through customer
            // object.
            customer.deposit_money();
            Console.WriteLine("------------------------\n");

            Console.WriteLine("\n2) Withdraw money\n\n");
            // Calling withdraw_money() function through
            // customer object.
            customer.withdraw_money();
            Console.WriteLine("------------------------\n");

            Console.WriteLine("\n4) Display Account\n\n");
            // Calling display_account() function through
            // customer object.
            customer.display_account();
            Console.WriteLine("------------------------\n");

            Console.ReadKey();
        }
    }
}
           

        