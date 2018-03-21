using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_21_03
{
    class Boy : Human
    {
        public string Gender { get; set; }
        public Boy(string firstName, string lastName, int age): base(firstName, lastName, age)
        {
            Gender = "Boy";
        }
        public override void Action()
        {
            base.Action();
            Play();
        }
        private void Play()
        {
            Console.WriteLine("As a " + Gender + ", he also likes to play StrikeBall and FootBall.");
        }
    }
}
