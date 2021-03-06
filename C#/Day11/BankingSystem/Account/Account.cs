using System;
using Customer;
namespace Account
{
    public class Account: Customer.Customer
    {
        public int account_id { get; set; }
        public double interst_rate { get; set; }
        public int customer_balance { get; set; }
        public int monthsValid { get; set; }
        public string account_type { get; set; }

        public Account()
        {
            account_id = -1;
            interst_rate = 0;
            customer_balance = 0;
            account_type = "";
            monthsValid = -1;
        }
        public Account(int id, int rate, int bal, string type)
        {
            account_id = id;
            interst_rate = rate;
            customer_balance = bal;
            account_type = type;
            monthsValid = 0;
        }
    }
}
