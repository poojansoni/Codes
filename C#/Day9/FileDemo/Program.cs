using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //step1
                FileStream file = new FileStream(@"D:\Capgemini\CodeC#\Poojan Soni\Day9", FileMode.Append, FileAccess.Write);

                StreamWriter sw = new StreamWriter(file);

                Console.WriteLine("Enter any sentence : ");
                string s = Console.ReadLine();

                sw.WriteLine(s);
                sw.Flush();
                sw.Close();
                file.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("Error while writing " + ex);
            }

            try
            {
                FileStream file = new FileStream(@"D:\Capgemini\CodeC#\Poojan Soni\Day9", FileMode.Append, FileAccess.Write);
                //using statement
                using (StreamWriter sw2 = new StreamWriter(file))
                {
                    Console.WriteLine("Enter any sentence : ");
                    string s2 = Console.ReadLine();

                    sw2.WriteLine(s2);
                    //no need to flush and close because using statement will do it
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while writing " + ex);
            }
        }
    }
}
