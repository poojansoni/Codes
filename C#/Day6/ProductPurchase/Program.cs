using System;

namespace ProductPurchase
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Welcome to Purchase Product Site ***********");

            Console.Write("\nEnter your customer-type\n1: Member already?\n2: Not a member? => ");

            
            int ismember = Convert.ToInt32(Console.ReadLine());
            switch (ismember)
            {
                case 1:
                    MemberCustomer m = new MemberCustomer();
                    m.Dispay_Price_prod();
                    m.Purchase();
                    double price = m.CalculatePrice();
                    Console.Write("\n\n************ You have to pay: " + price + "************\n\n");

                    break;
                case 2:
                    Guest cus = new Guest();
                    cus.Dispay_Price_prod();
                    break;
                default:
                    Console.WriteLine("\nSorry it's not valid\n");
                    break;
            }

            
            
            

            //Show - Product / no of items / Price / GST / TotalPrice / Offer

        }

    }
    abstract class Product
    {

        string[] Products = { "Milk", "Chocolate", "Flour", "Apple", "Soup" };

        public string getProdcut(int prodNo) { return this.Products[prodNo]; }

        public void Display_products() 
        {

            Console.WriteLine("\n");
            for(int count =0; count <5;count++)
            {
                Console.Write("\nProducts " + count +" : ");
                Console.Write(this.Products[count]);
            }
            
        }
    }

    abstract class Price: Product
    {
        int[] Prices = { 50, 100, 80, 30, 40 };

        public int GetPrice(int ProdNo) { return this.Prices[ProdNo]; }

        public abstract void Dispay_Price_prod();

        public abstract double CalculatePrice();
    }

    class Discount: Price
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
            throw new NotImplementedException();
        }

        public override double CalculatePrice()
        {
            throw new NotImplementedException();
        }
    }

    class MemberCustomer : Price

    {
        int[] custProduct = new int[5];
        int[] quantity = new int[5];
        public override void Dispay_Price_prod() {

            Display_products();
            Console.Write("\nPrices : ");
            Console.Write("{ ");
            for (int count = 0; count < 4; count++)
            {
                Console.Write(GetPrice(count) + " ,");
            }
            Console.Write(GetPrice(4) + " }");
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
                int prd = Convert.ToInt32( Console.ReadLine() );
                if (prd.Equals(5))
                {
                    choice = false;
                    break;
                }
                custProduct[count] = prd;
                Console.Write("Enter the quantity: " );
                quantity[count] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                count++;
            }
            Console.Write("\n________________________________________________\n");
        }


        public override double CalculatePrice()
        {
           
            Discount d = new Discount();
            d.Show_Offer();
            int total = d.calculatetotal(quantity, custProduct);
            double discount = 0.4 * total;
            Console.Write("\n________________________________________________\n\n");
            Console.WriteLine("You saved: " + discount+ " from your total : "+ total+"\n");
            return total-discount;
        }
    }

    class Guest : Price
    {
        int qnt;
        public void Purchase(int qnt)
        {
            this.qnt = qnt;
        }
        public override double CalculatePrice()
        {
            int tax = 100;
            //int total = qnt * GetPrice(prodno);
            return  tax;
        }

        public override void Dispay_Price_prod()
        {
            Display_products();
            Console.Write("\nPrices : ");
            Console.Write("{ ");
            for (int count = 0; count < 4; count++)
            {
                Console.Write(GetPrice(count) + " ,");
            }
            Console.Write(GetPrice(4) + " }");
        }

        
    }
}


