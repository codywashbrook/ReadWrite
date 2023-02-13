using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read/Write"); //needs to be zipped as Git ignores the build folders
            Console.WriteLine();

            string test;
            test = System.IO.File.ReadAllText("test.txt"); //read Program.cs to show all code
            Console.WriteLine(test);

            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
