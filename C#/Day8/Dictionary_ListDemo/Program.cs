using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary_ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sNames = new List<string>();

            sNames.Add("Adwait");
            sNames.Add("Aniket");
            sNames.Add("Balaram");
            sNames.Add("Josh");
            sNames.Add("Sonal");
            sNames.Add("Yash");

            foreach (string str in sNames)
            {
                Console.WriteLine(str);
                Console.ReadLine();
            }

            List<int> numbers = new List<int>() { 5, 7, 9, 3, 6, 0 };

            int maxNum = numbers.Max();
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();


            List<Product> products = new List<Product>();

            Product product = new Product();
            product.prodId = 101;
            product.prodName = "Mobile";
            products.Add(product);

            Product product2 = new Product();
            product2.prodId = 101;
            product2.prodName = "TV";
            products.Add(product2);

            products.Add(new Product() { prodId = 103, prodName = "DVD Player" });
            products.Add(new Product() { prodId = 104, prodName = "laptop" });

            foreach (Product obj in products)

            {

                Console.WriteLine("Your Product details {0} , {1}", obj.prodId, obj.prodName);

            }


            Dictionary<int, string> assembleDetails = new Dictionary<int, string>();
            
            assembleDetails.Add(1, "Aravind");
            assembleDetails.Add(2, "Modi");
            assembleDetails.Add(3, "Mamtha");
            assembleDetails.Add(5, "Amit");

            foreach (int key in assembleDetails.Keys)

            {

                string res = string.Empty;

                assembleDetails.TryGetValue(key, out res);

                Console.WriteLine("Your Leader is " + res);

            }

        }
    }

    class Product

    { 
        public int prodId { get; set; }
        public string prodName { get; set; }
    }
}
