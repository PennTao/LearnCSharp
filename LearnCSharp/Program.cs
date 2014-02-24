using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Program : testInterface, testInterface2
    {
        static void Main(string[] args)
        {
            Program tester = new Program();


        }

        void testInterface.print()
        {
            Console.WriteLine("Hello C#");
        }

        void testInterface2.print()
        {

                Console.WriteLine("Hello C#");

        }
    }
}
