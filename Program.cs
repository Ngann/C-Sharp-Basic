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

            // var student = new Student();
            // student.Name = "Jim";
            // Console.Write(student.Name);

            var studentNames = new List<string>();
            var studentGrades = new List<int>();
            var adding = true;

            while(adding)
            {
                Console.Write("Student Name: ");
                studentNames.Add(Console.ReadLine());

                Console.Write("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");

                if(Console.ReadLine() != "y");
                    adding = false;
            }

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade:{1}", studentNames[i], studentGrades[i]);
            }
            
        }
    }
}

class Student
{
    public string Name;
    public int Grade;
    public string Birthday;
    public string Address;
    public int Phone;

}