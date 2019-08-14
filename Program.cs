using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Hosting;
// using Microsoft.Extensions.Logging;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            //SchoolTracker for each item display grade

            var students = new List<Student>();

            var adding = true;

            while(adding)
            {
                var newStudent = new Student();

                Console.Write("Student Name:");
                newStudent.Name = Console.ReadLine();

                Console.Write("Student Grade:");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.Write("Student Birthday:");
                newStudent.Birthday = Console.ReadLine();

                Console.Write("Student Address:");
                newStudent.Address = Console.ReadLine();

                Console.Write("Student Phone:");
                newStudent.SetPhone = int.Parse(Console.ReadLine());

                students.Add(newStudent);

                Console.WriteLine("Add another? y/n");

                if(Console.ReadLine() != "y");
                    adding = false;
            }
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade:{1}", student.Name, student.Grade);
            }
            
        }
    }
    class Student
    {
        // cannot have var keyword for class variables, because blue prints need to have details defined. Type safety.
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        public void SetPhone(int number)
        {
            phone = number;
        }

    }
}

