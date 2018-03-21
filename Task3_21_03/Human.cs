using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_21_03
{
    class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public virtual void Action()
        {
            Console.WriteLine("This is " + FirstName + " " + LastName + ", " + Age + " years old. Abilities:");
            Run();
            Walk();
        }
        private void Run()
        {
            Console.WriteLine("This person can Run.");
        }
        private void Walk()
        {
            Console.WriteLine("This person can Walk.");
        }
    }
}
