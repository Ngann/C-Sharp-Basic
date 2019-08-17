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
        static void Import()
        {
            var importedStudent = new Student("jenny", 86, "birthday", "address" , 2344);
            Console.WriteLine(importedStudent.Name);

        }
    }

class Member
{
    public string Name;
    public string Address;
    private int phone;

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

        // constructor, how can you have two constructor with the same name?!!!!
        public Student()
        {

        }

        // constructor
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            // Console.WriteLine("constructor");
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address =address;
            Phone = phone;
        }
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

class Teacher
{
    public string Name;
    public string Address;
    private int Phone;
    public string Subject;
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