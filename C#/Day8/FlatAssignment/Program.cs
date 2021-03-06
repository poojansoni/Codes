using System;
using System.Collections;
using System.Collections.Generic;

namespace FlatAssignment
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Welcome to ___ Apartment! **********");

           
            //creating Maintainence due
            Console.Write("\n_____________________Creating Maintainence Record_____________________________");
            Console.Write("\nEnter the number of Maintainence records : ");
            int noRecords = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the Block for current Flats : ");
            char block = Convert.ToChar(Console.ReadLine());

            //using non-generic ArrayList
            List<MaintainenceDue> rec = new List<MaintainenceDue>();

            //initializing constant value
            int maintainenceAmnt = 1000;
            int year = 2020;
            string mnth = "NOV";
            string collectedby = "Hariharan";
            string paydate = " / / ";

            for (int cnt = 0; cnt < noRecords ; cnt++)
            {
                Console.Write("\n~~~~~~~~~~For " + cnt + "th Maintainence records ~~~~~~~~~~~~~\n");

                Console.Write("\nEnter the flat-number : ");
                string flt_no = Console.ReadLine();

                Console.Write("\nEnter the floor : ");
                string floor = Console.ReadLine();

                Console.Write("\nEnter the Owner's Name : ");
                string name = Console.ReadLine();

                Console.Write("\nIs the flat Rented? : ");
                string isrented = Console.ReadLine();

                Console.Write("\nDoes it have a Tenent? : ");
                string tnt = Console.ReadLine();

                Console.Write("\nIs the amount Paid? : ");
                string ispaid = Console.ReadLine();

                if (ispaid.Equals("Yes")) 
                {
                    Console.Write("\nWhat was the paid date (dd/mm/yy): ");
                    paydate = Console.ReadLine();
                }
                else
                {
                    paydate = " / / ";
                }
                
                
                rec.Add(new MaintainenceDue()
                {
                    Block = block,
                    flatNo = flt_no,
                    floor_details = floor,
                    ownerName = name,
                    isRented = isrented,
                    tenent =tnt,
                    Year = year,
                    Month = mnth,
                    MaintanceAmount = maintainenceAmnt,
                    IsPaid = ispaid,
                    PaidDate = paydate,
                    CollectedBy = collectedby
                });
                
            }


            //*************************************************************************************


            //Output generation:
            Console.Write("\n____________________________________________________________________________________________\n");
            Console.WriteLine("| FlatNo | FlatMember |  Year  | Month | MaintainenceAmount | isPaid | PayDate | CollectedBy |");
            foreach ( MaintainenceDue obj in rec)
            {
                Console.Write("\n__________________________________________________________________________________________\n");
                Console.Write("|    "+ obj.flatNo);
                Console.Write("  |  " + obj.ownerName);
                Console.Write("  |  " + obj.Year);
                Console.Write("  |  " + obj.Month);
                Console.Write("  |        " + obj.MaintanceAmount);
                Console.Write("        |  " + obj.IsPaid);
                Console.Write("  |  " + obj.PaidDate);
                Console.Write("  |  " + obj.CollectedBy+"  |\n");
                Console.Write("____________________________________________________________________________________________\n");

            }
            Console.Write("\n\n\n");

        }
    }

    

    public class FlatDetails
    {
        public char Block { get; set; }
        public string flatNo { get; set; }
        public string floor_details { get; set; }

    }
    public class OwnerDetails: FlatDetails
    {
        public string tenent { get; set; }
        public string ownerName { get; set; }
        public string isRented { get; set; }
    }
    public class MaintainenceDue: OwnerDetails
    {

        public int Year { get; set; }
        public string Month { get; set; }
        public int MaintanceAmount { get; set; }
        public string IsPaid { get; set; }
        public string PaidDate { get; set; }
        public string CollectedBy { get; set; }
      
    }
}

/* //creating flats
            Console.Write("\n__________________Creating flats for the Apartment______________________");
            Console.Write("\nEnter the Block for current Flats : ");
            char block = Convert.ToChar(Console.ReadLine());

            Console.Write("\nEnter the number of Flats : ");
            int totalFlats = Convert.ToInt32(Console.ReadLine());

            //use of generic list
            List<FlatDetails> fl = new List<FlatDetails>();
            for(int cnt = 0; cnt < totalFlats; cnt++)
            {
                Console.Write("\n~~~~~~~~~~For "+cnt +" flat ~~~~~~~~~~~~~\n");
                Console.Write("\nEnter the flat-number : ");
                string flt_no = Console.ReadLine();

                Console.Write("\nEnter the floor : ");
                string floor = Console.ReadLine();

                fl.Add(new FlatDetails()
                {
                    Block = block,
                    flatNo = flt_no,
                    floor_details =  floor
                }) ;
            }
            Console.Write("\n_________*///________________________________________________________________\n");




//*************************************************************************************



//creating Owners
/*Console.Write("\n________________________Creating Owners for flats__________________________");
Console.Write("\nEnter the number of owners : ");
int ownNo = Convert.ToInt32(Console.ReadLine());

//using generic sortedlist
SortedList<int, OwnerDetails> owners = new SortedList<int, OwnerDetails>();

for (int cnt = 0; cnt < ownNo; cnt++)
{
    Console.Write("\n~~~~~~~~~~For " + cnt + " owner ~~~~~~~~~~~~~\n");
    Console.Write("\nEnter the Owner's Name : ");
    string name = Console.ReadLine();

    Console.Write("\nIs the flat Rented? : ");
    string isrented = Console.ReadLine();

    Console.Write("\nDoes it have a Tenent? : ");
    string tnt = Console.ReadLine();

    owners.Add(cnt, new OwnerDetails()
    {
        tenent = tnt,
        isRented = isrented,
        ownerName = name
    }) ;
}
Console.Write("\n_________________________________________________________________________\n");
*/




//*************************************************************************************

