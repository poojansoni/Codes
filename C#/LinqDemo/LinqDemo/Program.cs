using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Numbers = { 2, 3, 4, 6, 7, 8, 12, 23, 45 };

            //IEnumerable<int> result = from alies in Numbers
            //                          where alies > 5
            //                          orderby alies descending
            //                          select alies ;

            //foreach (int val in result)
            //{
            //    Console.WriteLine(val);
            List<string> cities = new List<string>() { "Bangalore", "Udaipur", "Jaipur", "Chennai", "Pondicherry", "Gujarat", "Meghalaya" };
            var city = from c in cities
                       where c.Length >= 5
                       orderby c descending
                       select c;
            foreach (string val in cities)
            {
                Console.WriteLine("City: " + val);
            }

            Console.ReadLine();

            ProjectionOperatorSelectMany();

            SortingOperatorOrderBy();

            SortingOperatorThenBy();

            GroupOperatorGroupBy();

            StudentAgeGroupBy();
        }

        private static void ProjectionOperatorSelectMany()
        {
            List<Bouquet> bouquets = new List<Bouquet>() {
                new Bouquet { Flowers = new List<string> { "sunflower", "daisy", "daffodil", "larkspur" }},
                new Bouquet{ Flowers = new List<string> { "tulip", "rose", "orchid" }},
                new Bouquet{ Flowers = new List<string> { "gladiolis", "lily", "snapdragon", "aster", "protea" }},
                new Bouquet{ Flowers = new List<string> { "larkspur", "lilac", "iris", "dahlia" }}
            };

            var query = bouquets.Select(bq => bq.Flowers);

            var queryMany = bouquets.SelectMany(bq => bq.Flowers);

            foreach (string str in queryMany)
            {
                Console.WriteLine(str);
            }

        }


        /*private static void ProjectionOperatorSelectOP()
        {
            List<string> phrases = new List<string>() { "an apple a day", "the quick brown fox" };
                var query = from phrase in phrases;
            Console.WriteLine(s);
        }*/

        private static void SortingOperatorOrderBy()
        {
            List<string> cities = new List<string> { "Mumbai", "Agra", "Delhi", "Chennai", "Banagalore", "Pune", "Trichy" };
            //query for ascending ordering

            var query1 = from city in cities

                         orderby city

                         select city;             //query for descending ordering

            var query2 = from city in cities

                         orderby city descending

                         select city;
            Console.WriteLine("Cities in Ascending Order");

            foreach (string s in query1)

            {
                Console.Write(s + ", ");
            }
            Console.WriteLine("\nCities in Descending Order");

            foreach (string s in query2)
            {
                Console.Write(s + ", ");
            }

        }


        private static void SortingOperatorThenBy()
        {

            List<Student> studentList = new List<Student> {
        new Student(){StudentID = 1, StudentName = "John", Age = 18 },

        new Student(){StudentID = 2, StudentName = "Steve", Age = 15 },

        new Student(){StudentID = 3, StudentName = "Bill", Age = 25 },

        new Student(){StudentID = 4, StudentName = "Ram" , Age = 20 },

        new Student(){StudentID = 5, StudentName = "Ron" , Age = 19 },

        new Student(){StudentID = 6, StudentName = "Ram" , Age = 18} };
    

            //Bill,John,Ram,Ram,Ron

            var query1 = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age); 
            var query2 = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
            
            foreach (Student s in query1)
            {
                Console.Write("Student Name :{0},Age :{1}", s.StudentName, s.Age);
            }

            Console.WriteLine();

            foreach (Student s in query2)
            {
                Console.Write("Student Name : "+ s.StudentName+" , Age : "+ s.Age);
            }
        }

        private static void GroupOperatorGroupBy()
        {
            List<int> numbers = new List<int>() { 35, 44, 200, 84, 3987, 4, 199, 329, 446, 208 };
            IEnumerable<IGrouping<int, int>> query = from number in numbers
                                                     group number by number % 2;
            foreach (var group in query)
            {

                Console.WriteLine(group.Key == 0 ? "\nEven numbers:" : "\nOdd numbers:");

                foreach (int i in group)

                    Console.WriteLine(i);
            }
        }


        private static void StudentAgeGroupBy()
        {
            List<Student> studentList = new List<Student> {
        new Student(){StudentID = 1, StudentName = "John", Age = 18 },

        new Student(){StudentID = 2, StudentName = "Steve", Age = 15 },

        new Student(){StudentID = 3, StudentName = "Bill", Age = 25 },

        new Student(){StudentID = 4, StudentName = "Ram" , Age = 20 },

        new Student(){StudentID = 5, StudentName = "Ron" , Age = 19 },

        new Student(){StudentID = 6, StudentName = "Ram" , Age = 18} };

            IEnumerable<IGrouping<int, Student>> std = from res in studentList
                                                       group res by res.Age;
            foreach (var group in std)
            {
                Console.WriteLine("Age group: " + group.Key);
                foreach (Student i in group)

                    Console.WriteLine("Student name: "+i.StudentName);
            }
        }

        private static void ConversionOperatorsLinq()
        {
            //As Enum - if a collection only used for looping (with no operations)
            string[] names = { "John", "Suzy", "Dave" };

            var result = names.AsEnumerable();

            Console.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Console.WriteLine(name);

            //Cast
            List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };
            var resultCa = vegetables.Cast<string>();

            Console.WriteLine("List of vegetables casted to a simple string array:");
            foreach (string vegetable in resultCa)
                Console.WriteLine(vegetable);
            //Typeof
            object[] objects = { "Thomas", 31, 5.02, null, "Joey" };

            var resulttyp = objects.OfType<string>();

            Console.WriteLine("Objects being of type string have the values:");
            foreach (string str in resulttyp)
                Console.WriteLine(str);

            //ToArray
            int[] numbers = { 1, 2, 3, 4 };

            var resultArr = numbers.ToArray();

            Console.WriteLine("New array contains identical values:");
            foreach (int number in resultArr)
                Console.WriteLine(number);

        }

    }

    class Bouquet
    {
        public List<string> Flowers { get; set; }
    }

    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }



}
