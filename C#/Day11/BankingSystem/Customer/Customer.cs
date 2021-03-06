using System;

namespace Customer
{
    public class Customer
    {
        public string cust_name { get; set; }
        public int cust_id { get; set; }
        public string cust_type { get; set; }


        public Customer()
        {
            cust_name = "";
            cust_id = -1;
            cust_type = "";

        }

        public Customer(string name, int id, string type)
        {
            cust_name = name;
            cust_id = id;
            cust_type = type;

        }


    }
}
