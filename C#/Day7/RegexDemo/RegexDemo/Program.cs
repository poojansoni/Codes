using System;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any string of 3 charachters : ");
            string val = Console.ReadLine();
            //gmail
            //string pattern = "^[a-zA-Z0-9]{1,10}@[a-zA-Z0-9]{1,10}.(com|edu|in)$";
            string pattern = "^[a]{3}";

            Console.WriteLine(val);
            Match match = Regex.Match(val, pattern);


            if (match.Success)
            {
                Console.WriteLine("Entered Value Matched to the Pattern");
            }
        }
    }
}
