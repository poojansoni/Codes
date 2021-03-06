using System;
using System.Collections;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hashtable numberNames = new Hashtable();
             numberNames.Add(1, "One"); //adding a key/value using the Add() method
             numberNames.Add(2, "Two");
             numberNames.Add(3, "Three");

             //The following throws run-time exception: key already added.
             //numberNames.Add(3, "Three"); 

             foreach (DictionaryEntry de in numberNames)
                 Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

             //creating a Hashtable using collection-initializer syntax
             var cities = new Hashtable(){
                 {"UK", "London, Manchester, Birmingham"},
                 {"USA", "Chicago, New York, Washington"},
                 {"India", "Mumbai, New Delhi, Pune"}
             };

             foreach (DictionaryEntry de in cities)
                 Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);*/

            // value reference
            //int/bool/char..
            // refernce- string aarry list..
            /*5->"5", string->int(unboxing)
             int-*///>refe (boxing)

            /*int a = 5;
        object obj = (object)a;*/
            Console.WriteLine("Pre-increament:");
            for (int i = 1; i <= 5; )
            {
                Console.WriteLine(++i);
                
            }
            Console.WriteLine("\nPost-increament:");
            for (int i = 1; i <= 5; )
            {
                Console.WriteLine(i++);
                
            }
            try {
                try { }
                catch (Exception ex) { }
            }
            finally
            {
                
            }
            
        }
    }

    public class Try
    {
        int a = 0;
        virtual public int Add(int a, int b)
        {
            return a + b;
        }
    }

    abstract class abs
    {
        int a = 0;
        public int Add(int a, int b)
        {
            return a + b;
        }
        abstract public int sub(int a, int b);
    }
}
