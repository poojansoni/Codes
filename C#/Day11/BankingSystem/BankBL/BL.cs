using System;
using Customer;
using Account;
namespace BankBL
{
    public class BL
    {

        private void addCustomer(ref Customer.Customer c)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            int id = generateRandomID();

            Console.WriteLine("Are you Individual/Company?: ");
            string type = Console.ReadLine();

            c.cust_id = id;
            c.cust_name = name;
            c.cust_type = type;
        }

        public Account.Account addAccount(ref Customer.Customer c)
        {
            Account.Account a = new Account.Account();

            if (!validateCustomer(c))
            {
                addCustomer(ref c);
            }

            int acc_id = generateRandomID();

            Console.WriteLine("Enter Balance to be deposited: ");
            int bal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select Account-type:\n* Deposit\n* Loan\n* Mortgage\n: ");
            string type = Console.ReadLine();

            a.account_id = acc_id;
            a.customer_balance = bal;
            a.account_type = type;
            a.interst_rate = CalculateInterest(c.cust_type, ref a);


            return a;

        }

        private double CalculateInterest(string cust_type, ref Account.Account a)
        {
            double rate = 15;
            switch (a.account_type)
            {
                case "Deposit":
                    if (a.customer_balance > 0 && a.customer_balance < 1000)
                    {
                        rate = 0;
                    }

                    break;

                case "Loan":
                    if (cust_type.Equals("Individual"))
                    {
                        rate = 0;
                        a.monthsValid = 3;
                    }
                    else
                    {
                        rate = 0;
                        a.monthsValid = 2;
                    }
                    break;

                case "Mortgage":
                    if (cust_type.Equals("Individual"))
                    {
                        rate = 0;
                        a.monthsValid = 6;
                    }
                    else
                    {
                        rate = rate / 2;
                        a.monthsValid = 12;
                    }
                    break;

                default: break;
            }
            return rate;
        }

        private int generateRandomID()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }


        private bool validateCustomer(Customer.Customer customer)
        {
            if (customer.cust_id == -1)
            {
                //Console.WriteLine("Invalid customer");
                return false;
            }
            return true;
        }



        public void selectOption(Account.Account account)
        {
            switch (account.account_type)
            {
                case "Deposit":
                    while (true)
                    {
                        Console.Write("Want to Deposit/Withdraw?: ");
                        string choice = Console.ReadLine();
                        if (choice.Equals("Deposit"))
                        {
                            deposit(ref account);
                        }
                        else if (choice.Equals("Withdraw"))
                        {
                            withdraw(ref account);
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;

                case "Loan":
                    while (true)
                    {

                        Console.Write("Want to Deposit?: ");
                        string choice1 = Console.ReadLine();

                        if (choice1.Equals("Deposit"))
                        {
                            deposit(ref account);
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;

                case "Mortgage":
                    while (true)
                    {
                        Console.Write("Want to Deposit?: ");
                        string choice2 = Console.ReadLine();

                        if (choice2.Equals("Deposit"))
                        {
                            deposit(ref account);
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
            }
            
        }

        private void withdraw(ref Account.Account account)
        {
            Console.WriteLine("Your balance is : " + account.customer_balance);
            Console.Write("How much you want to withdraw? ");
            int sum = Convert.ToInt32(Console.ReadLine());
            account.customer_balance = account.customer_balance - sum;
            Console.WriteLine(sum+" amount has been debited from your account\nYour Current Balance is : " + account.customer_balance);
        }

        private void deposit(ref Account.Account account)
        {
            Console.WriteLine("Your balance is : " + account.customer_balance);
            Console.Write("How much you want to deposit? ");
            int sum = Convert.ToInt32(Console.ReadLine());
            account.customer_balance = account.customer_balance + sum;
            Console.WriteLine("Current Balance is : " + account.customer_balance);
        }

        public void displayAccount(Account.Account a)
        {
            Console.WriteLine("Name | Customer ID | Account ID | Balance-left | Interest ");
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine(a.cust_name + " | " + a.cust_id + " | " + a.account_id + " | " + a.customer_balance + " | "+ a.interst_rate);
            Console.WriteLine("______________________________________________________________________");
        }
    }
}
