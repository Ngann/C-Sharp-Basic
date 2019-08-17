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

                
                newStudent.Name = Util.Console.Ask("Student Name:");
                newStudent.Grade = int.Parse(Util.Console.Ask("Student Name:"));
                newStudent.Birthday = Util.Console.Ask("Student Birthday:");
                newStudent.Address = Util.Console.Ask("Student Address:");

                
                newStudent.Phone = int.Parse(Util.Console.Ask("Student Phone:"));

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count:{0}", Student.Count);

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
        static public int Count = 0;
        // cannot have var keyword for class variables, because blue prints need to have details defined. Type safety.
        //fields
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        // properties
        public int Phone
        {
            set { phone = value;}
        }

        public void SetPhone(int number)
        {
            phone = number;
        }

    }
}

namespace Util
{
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
    }
}