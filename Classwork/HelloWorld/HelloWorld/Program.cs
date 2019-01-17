/*
 * Multi line comment
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args )
        {
            string name;
            int hours = 8;
            double payRate = 8.25;
            int length = 10, width = 12;
            int areallealongidentifierthatisretardedlylong;
            char ch = 'X';
            bool result = true; // false

            //  int counter;
            // int a, b;

            // Never!!!!
            
            Console.WriteLine(hours);
            //name = "Sue";
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();


            //string message = "hello " + name;

            string message = "hello ";
            message += name;

            Console.WriteLine(message);
            Console.Write("Hello World!");
            Console.WriteLine(name);
        }
    }
}
