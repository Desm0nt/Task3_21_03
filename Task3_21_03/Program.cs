using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_21_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("Vasya", "Pupkin", 19);
            Boy b = new Boy("Ivan", "Ivanov", 15);
            Girl g = new Girl("Ritsu", "Tainaka", 13);
            h.Action();
            Console.WriteLine("");
            b.Action();
            Console.WriteLine("");
            g.Action();
            Console.Read();
        }
    }
}
