using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_21_03
{
    class Girl : Human
    {
        public string Gender { get; set; }
        public Girl(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            Gender = "Girl";
        }
        public override void Action()
        {
            base.Action();
            Dance();
        }
        private void Dance()
        {
            Console.WriteLine("As a " + Gender + ", she also likes Вancing.");
        }
    }
}
