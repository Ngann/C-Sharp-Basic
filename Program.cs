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

            // Import(); test if the import function works.
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();


                newStudent.Name = Util.Console.Ask("Student Name:");
                var result = int.TryParse(Util.Console.Ask("Student Name:"), out newStudent.Grade);
                if (!result)
                {
                    Console.WriteLine("please enter an int");
                }
                newStudent.Birthday = Util.Console.Ask("Student Birthday:");
                newStudent.Address = Util.Console.Ask("Student Address:");
                newStudent.Phone = int.Parse(Util.Console.Ask("Student Phone:"));

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count:{0}", Student.Count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y") ;
                adding = false;
            }
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade:{1}", student.Name, student.Grade);
            }
        }
        static void Import()
        {
            var importedStudent = new Student("jenny", 86, "birthday", "address", 2344);
            Console.WriteLine(importedStudent.Name);

        }
    }

   class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }

    class Student : Member
    {
        static public int Count = 0;

        public int Grade;
        public string Birthday;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }

    // class Teacher : Member
    // {
    //     public string Subject;
    // }

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