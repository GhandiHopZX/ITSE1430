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
           NewGame();
           DisplayGame();
        }

        private static void CSharpBasics()
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

        private static void NewGame ()
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();

            //Console.WriteLine("Do you own this? ");
            //string owned = Console.ReadLine();
            owned = ReadBoolean("Owned (Y/NY)?");

            //Console.WriteLine("Price? ");
            //string price = Console.ReadLine();
            price = ReadDecimal("price?");


            Console.WriteLine("Publisher? ");
            publisher = Console.ReadLine();

            //Console.WriteLine("Completed? ");
            //string completed = Console.ReadLine();
            completed = ReadBoolean("Completed (Y/N)?");

        }

        private static void DisplayGame()
        {
            string literal1 = "Hello \"Bob\"";
            string path = "C:\\Windows\\System32";
            path += "\\Temp";
            string path2 = @"C:\\Windows\\System32";

            Console.WriteLine("Nane\t: " + name);
            Console.WriteLine("Owned: " + owned);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Completed: " + completed);

        }

        private static bool ReadBoolean( string message )
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();

            //Validate it is a boolean
            if (result == "Y")
                return true;
            if (result == "y")
                return true;
            if (result == "N")
                return false;
            if (result == "n")
                return false;

            // TODO Add Validation
            return false;

        }

        // bool TryParse( string input, out decimal result );

        private static decimal ReadDecimal(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();

            //decimal result;
            //if (Decimal.TryParse(value, out result))
            if (Decimal.TryParse(value, out decimal result))
                return result;

            return 0;
        }

        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;
    }
}
