using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNUnit.Library;

namespace TestNUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program TestNUnit");
            Maths add = new Maths();
            Console.WriteLine(add.Add(1, 2));

            Console.ReadLine();

            
        }
    }
}
