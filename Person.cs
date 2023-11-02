using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolregister
{
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int PersonalNumber { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Firstname: {FirstName} " +
                $"\nLastname: {LastName} " +
                $"\nRole: {Role}" +
                $"\nPersonalnumber: {PersonalNumber}");

        }
    }
}
