using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolregister
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string firstName, string lastName, string role, int personalNumber, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            PersonalNumber = personalNumber;
            Subject = subject;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Subject : {Subject}");
        }
    }

}
