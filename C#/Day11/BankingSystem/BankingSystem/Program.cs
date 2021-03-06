using System;
using BankBL;
using Customer;
using Account;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome to ___ Bank!**********");
            Console.Write("Do want to add Account? (y/n): ");
            char choice = Convert.ToChar(Console.ReadLine());

            Customer.Customer cust = new Customer.Customer();
            BL bl = new BL();
            Account.Account account = new Account.Account();

            if (choice.Equals('y') || choice.Equals('Y'))
            {
      
                account = bl.addAccount(ref cust);

            }
            else
            {
                //Console.WriteLine("Already have an account?\nEnter Account no: ");

            }

            bl.displayAccount(account);
            bl.selectOption(account);

        }
    }
}
