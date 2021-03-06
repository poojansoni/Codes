using System;
using System.IO;

namespace Product_FileReadnWrite
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Welcome to Purchase Product Site ***********");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            MemberCustomer m = new MemberCustomer();
            m.Dispay_Price_prod();
            m.Purchase();

            string writeline = "Customer name: " + name + "\nBill No: XYZ0123\n" + m.CalculatePrice();
            
            string filePath = @"D:/Capgemini/CodeC#/Poojan Soni/Day9/Test.txt";

            writeFile(writeline, filePath);

            Console.WriteLine(ReadFile(filePath));

            //functions to read and write
            void  writeFile(string str, string path)
            {
                try
                {
                    FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write);
                    
                    using (StreamWriter sw = new StreamWriter(file))
                    { 
                        sw.WriteLine(str);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while writing " + ex);
                }
            }

            string ReadFile(string str)
            {
                string res = null;
                try
                {
                    res = File.ReadAllText(str);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while reading " + ex);
                }
                return res;
            }

           
        }

    }
    abstract class Product
    {

        public string[] Products = { "Milk", "Chocolate", "Flour", "Apple", "Soup" };

        public string getProduct(int prodNo) { return this.Products[prodNo]; }

        public void Display_products()
        {

            Console.WriteLine("\n");
            for (int count = 0; count < 5; count++)
            {
                Console.Write("\nProducts " + count + " : ");
                Console.Write(this.Products[count]);
            }

        }
    }

    abstract class Price : Product
    {
        public int[] Prices = { 50, 100, 80, 30, 40 };

        public int GetPrice(int ProdNo) { return this.Prices[ProdNo]; }

        public abstract void Dispay_Price_prod();

        public abstract string CalculatePrice();
    }

    class Discount : Price
    {
        public void Show_Offer()
        {
            Console.WriteLine("\nYou get a discount of 40%\n");
        }

        public int calculatetotal(int[] quantity, int[] custProduct)
        {
            int total = 0;
            for (int count = 0; count < 5; count++)
            {
                total = quantity[count] * GetPrice(custProduct[count]) + total;
            }
            return total;
        }

        public override void Dispay_Price_prod()
        {
            Console.WriteLine("\n");
            for (int count = 0; count < 5; count++)
            {
                Console.Write("\nProducts " + count + " : ");
                Console.Write(Products[count] + " || Price : " + GetPrice(count));
            }
        }

        public override string CalculatePrice()
        {
            throw new NotImplementedException();
        }
    }

    class MemberCustomer : Price

    {
        int[] custProduct = new int[5];
        int[] quantity = new int[5];
        public override void Dispay_Price_prod()
        {

            Console.WriteLine("\n");
            for (int count = 0; count < 5; count++)
            {
                Console.Write("\nProducts " + count + " : ");
                Console.Write(Products[count]+" || Price : "+ GetPrice(count));
            }
           
        }
        int count = 0;
        public void Purchase()
        {

            
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


        public override string CalculatePrice()
        {

            Discount d = new Discount();
            d.Show_Offer();
            int total = d.calculatetotal(quantity, custProduct);
            double discount = 0.4 * total;
            string res = null;

            for (int i = 0; i< count; i++)
            {
                res = res + "Product: " + getProduct(custProduct[i]) + " || Quantity: "+ quantity[i]+"\n" ;
            }
            res = res + "\nYou saved: " + discount + "! from your total : " 
                + total + "/-\n"+ "\n********** You have to pay: "+ (total-discount) + "/- **********" ;
            return res;
        }
    }

    



    
}
    
