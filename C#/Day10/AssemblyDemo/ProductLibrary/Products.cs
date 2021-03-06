using System;
using System.Collections.Generic;

namespace ProductLibrary
{
    public class Products
    {
        public Products()
        {
            products = new List<string> {"Laptop","Fridge","Monitor","SmartPhone","Keyboard" };
            prices = new List<int> {50000, 40000, 9000, 15000, 1000  };
        }

        List<int>custProduct = new List<int> {0,1,2,3,4};
        List <int >quantity = new List<int> {2, 1, 2, 3, 2  };

        public List<string> products { get; set; }
        public List<int> prices { get; set; }
        
        public void Display_Price_prod()
        {
            Console.WriteLine("\n");
            for (int count = 0; count < products.Count; count++)
            {
                Console.Write("\nProducts " + count + " : ");
                Console.Write(products[count] + " || Price : " + prices[count]);
            }
        }

        public void Purchase()
        {

            int count = 0;
            bool choice = true;
            Console.WriteLine("\n________________________________________________\n");
            Console.Write("Enter '5' to exit\n");
            while (choice)
            {
                Console.Write("Enter the product No: ");
                int prd = Convert.ToInt32(Console.ReadLine());
                if (prd.Equals(5))
                {
                    choice = false;
                    break;
                }
                custProduct[count] = prd;
                Console.Write("Enter the quantity: ");
                quantity[count] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                count++;
            }
            Console.Write("\n________________________________________________\n");
        }

        public string CalculatePrice()
        {
            int total = 0;
            for (int count = 0; count < custProduct.Count; count++)
            {
                total = quantity[count] * prices[custProduct[count]] + total;
            }
            
            string res = null;

            for (int i = 0; i < custProduct.Count; i++)
            {
                res = res + "Product: " + products[custProduct[i]] + " || Quantity: " + quantity[i] + "\n";
            }
            res = "\n********** You have to pay: " + total + "/- **********";
            return res;
        }
    }
}
