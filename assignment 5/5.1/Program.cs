using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            student();

        }

        static void student()
        {
            Student newStudent = new Student(1, "Bob", "555-5555");
            Student newStudent2 = new Student(2, "Rick", "555-5566");


            DayTimeStudent Bob = new DayTimeStudent();
            Bob.Id = 1;
            Bob.Name = "Bob";
            Bob.PhoneNumber = "555-5555";
            Bob.sectionNumber = 10;
            Bob.lockerNumber = 2;

            EveningStudent Rick = new EveningStudent();
            Rick.Id = 2;
            Rick.Name = "Rick";
            Rick.PhoneNumber = "555-5566";
            Rick.roomNumber = 2;
            Rick.courseName = "Physics";

            //Console.WriteLine("  ");
            //Console.WriteLine("Student in the system... Name: " + Bob.Name); 
            //Console.WriteLine("Id Number: " + Bob.Id);
            //Console.WriteLine("Section Number: " + Bob.sectionNumber);
            //Console.WriteLine(" ");
                      
        }

        // display student method
       

    }
}
