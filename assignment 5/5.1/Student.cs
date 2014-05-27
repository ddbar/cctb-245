using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Student
    {
        #region Properties and Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        #region Constructors
        public Student()
        {
        }

        public Student (int id, string name, string phoneNumber)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
        }
        #endregion

       // need to make a method that gets the values for the student information

         static virtual void displayStudent()
        {
            Console.WriteLine();
        }

        



    }
}



