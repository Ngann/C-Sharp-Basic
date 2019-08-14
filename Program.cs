using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Secret
            // var code = "";
            // while( code !="secret")
            // {
            //  Console.WriteLine("What is the pass code?");
            //  code = Console.ReadLine();

            //  if( code != "secret")
            //  {
            //      Console.WriteLine(" Not Authenticated");
            //  }

            //  Console.WriteLine("Authenticated");
            // }

            //Count while
            // var count = 1;

            // while ( count <= 10 ){
            //      Console.WriteLine(count);
            //      count++;
            // }

            //Count For Loop to 10 and back to 1, five times
            // for (int x = 1; x <= 5 ; x++){
            //     for (int i = 1 ; i <= 10 ; i++){
            //         Console.WriteLine(i);
            //     }

            //     for (int i = 10 ; i >= 1 ; i--){
            //         Console.WriteLine(i);
            //     }
            // }

            //SchoolTracker for each item display grade

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
            
            // Console.WriteLine("How many student in your class?");
            // var studentCount = int.Parse(Console.ReadLine());
            // var studentGrades = new int[10] { 12 ,35, 89, 99 , 10, 34, 45,33, 33, 22};
            // var studentNames = new string[studentCount];
            // var studentGrades = new int[studentCount];
            // for (int i = 0; i < studentCount; i++)
            // {
            //     Console.Write("Student Name: ");
            //     studentNames[i] =  Console.ReadLine();

            //     Console.Write("Student Grade: ");
            //     studentGrades[i] =  int.Parse(Console.ReadLine());
            // }
            
            // for (int i = 0; i < studentCount; i++)
            // {
            //     Console.WriteLine("Name: {0}, Grade:{1}", studentNames[i], studentGrades[i]);
            // }
            
           // Name Age Month 
        //    Console.Write("What is your name?");
        //    var name = TryAnswer();


        //    Console.Write("What is your age?");
        //    var age = TryAnswer();
    
        //    Console.Write("What is your month?");
        //    var month = TryAnswer();

        //    Console.WriteLine("Your name is: {0}", name);
        //    Console.WriteLine("Your age is: {0}, age");
        //    Console.WriteLine("Your birth month is: {0}", month);

        //     if ( month == "march")
        //     {
        //         Console.WriteLine("you are a Aries");
        //     }
        //     else if ( month == "april")
        //     {
        //         Console.WriteLine("you are a Taurus");
        //     }
        //     else if( month == "may")
        //     {
        //         Console.WriteLine("you are a gemini");
        //     }

//How many years of experience
            // Console.WriteLine("How many years of experience do you have?");

            // var years = int.Parse(Console.ReadLine());

            // switch(years)
            // {
            //     case 0:
            //         Console.WriteLine("Inexperience");
            //         break;
            //     case 1:
            //         Console.WriteLine("Junior");
            //         break;
            //     case 2:
            //         Console.WriteLine("Intermediate");
            //         break;
            //     case 3:
            //         Console.WriteLine("Advance");
            //         break;
            // }
            // if (years == 0)
            //     Console.WriteLine("Inexperience");
            // else if (years == 1)
            //     Console.WriteLine("Junior");
            // else if (years == 2)
            //     Console.WriteLine("Intermediate");
            // else if (years == 3)
            //     Console.WriteLine("Advanced");
            // else
            //     Console.WriteLine("Senior");

        }

         // Name Age Month 
        // static string TryAnswer()
        // {   
        //     var answer = Console.ReadLine();
        //     if(answer == "")
        //     {
        //         Console.WriteLine("You didn't write anything, please try again");
        //         return Console.ReadLine();
        //     }
        //     return answer;
        // }
    }
}
