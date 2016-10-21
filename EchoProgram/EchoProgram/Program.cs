using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence.");
            string echoPlease = Console.ReadLine();

            do
            {
                Console.WriteLine(echoPlease);
            } while (true);
            
        }
    }
}
