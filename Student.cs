using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolregister
{
    internal class Student : Person
    {
        public string Course { get; set; }
        public Student(string firstName, string lastName, string role, int personalNumber, string course)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            PersonalNumber = personalNumber;
            Course = course;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Course : {Course}");
        }
    }
}
