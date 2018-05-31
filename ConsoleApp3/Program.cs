using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp3
{
    class Program
    {
    //    private static List<Student> list = new List<Student>();
        private static DBConnection connection = new DBConnection();

        public static void AddStudent()
        {
            var student = new Student();
            Console.WriteLine("rollNumber :");
            student.RollNumber = Console.ReadLine();
            Console.WriteLine("name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("email:");
            student.Email = Console.ReadLine();
    //        list.Add(student);
            connection.Insert(student);
        }

        public static void DisplayList()
        {
    //        connection.getData();
    //       foreach (var student in list)
    //        {
    //            Console.WriteLine(student.Name);
      //      }
          
        }

//        public static void SearchByName()
//        {
//            Console.WriteLine("Please enter name to search:");
//            var searchKey = Console.ReadLine();
//            foreach (var student in list)
//            {
//                if (searchKey.Equals(student.Name))
//                {
//                    Console.WriteLine("Found:");
//                    Console.WriteLine("RollNumber : " + student.RollNumber);
//                    Console.WriteLine("Name : " + student.Name);
//                    Console.WriteLine("Email : " + student.Email);
//                }
//            }
//        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----------------------Student------------------");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Display list student");
                Console.WriteLine("3. Search by name");
                Console.WriteLine("4. Exit");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Please enter the choice");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayList();
                        break;
                    case 3:
                    //    SearchByName();
                        break;
                    case 4:
                        Console.WriteLine("Exit.");
                        Environment.Exit(1);
                        break;
                }

                {
                }
            }
        }
    }
}