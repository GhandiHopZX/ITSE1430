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

            struct server
            {
            string _Myname;
            int 
            };
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
            var literal1 = "Hello \"Bob\"";
            var path = "C:\\Windows\\System32";
            path += "\\Temp";
            var path2 = @"C:\\Windows\\System32";

            //1. string format
            
            Console.WriteLine("Nane\t: " + name);

            //2. string format
            string str = string.Format("Price: {0:C}", price);
            Console.WriteLine(str);
            //Console.WriteLine("Price: " + price);

            //3. Function Overload - just calls String.Format
            //3. Function Overload - just calls String.Format
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Owned: " + owned);
           
            //4. Concatenation
            str = String.Concat("Owned?", " ", owned);
            Console.WriteLine(str);

            //5. Interpolation
            //Console.WriteLine("Completed? " + completed);
            //Console.WriteLine("Completed? {0}" + completed);
            Console.WriteLine($"Completed: {completed}");

            // Convert to a string 
            string strPrice = price.ToString("C");
            string strLiteral = "Hello".ToString();
            //ReadBoolean("Hello").ToString();
            10.ToString();

            //Is string empty
            string input = "";
            //int length = input.Length;
            bool isEmpty;

            // these all do the same thing

            //1.
            //if (input != null)
            //    isEmpty = input.Length == 0;
            //else 
            //    isEmpty = true;

            //2.
            isEmpty = (input != null) ? input.Length == 0 : true;

            //3.
            isEmpty = input == "";

            //4.
            isEmpty = input == String.Empty;

            //5.
            isEmpty = String.IsNullOrEmpty(input);

            //Comparison
            bool areEqual = "Hello" == "hello";
            areEqual = String.Compare("Hello", "hello", true) == 0;

            //Conversion
            input = input.ToUpper();
            input = input.ToLower();

            //Manipulation
            bool startsWith = input.StartsWith("http:");
            bool endsWith = input.EndsWith("/");

            input = input.TrimStart();
            input = input.TrimEnd();
            input = input.Trim();

            input = input.PadLeft(10);
            input = input.PadRight(10, '-');

        }

        private static bool ReadBoolean( string message )
        {
            do
            {
            Console.WriteLine(message);
            string result = Console.ReadLine().ToUpper();

            //Validate it is a boolean
            if (result == "Y")
                return true;
            if (result == "N")
                return false;

            switch (result)
            {
                case "Y":
                case "y": return true;
                
                case "N":
                case "n": return false;

                default: Console.WriteLine("Invalid choice");
                break;
            }

            // TODO Add Validation
            return false;
            } while (true);
        }

        // bool TryParse( string input, out decimal result );

        private static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string value = Console.ReadLine();

                //decimal result;
                //if (Decimal.TryParse(value, out result))
                if (Decimal.TryParse(value, out decimal result))
                    return result;

                Console.WriteLine("Enter a valid decimal value");
            };

            return 0;
        }

        private static void PlayWithArrays ()
        {
            // initialized and set as is. this can be refrenced
            //int size = 100;
            int[] prices = new int[100];
            string[] ingredients = {"pepperoni","black olives","mushrooms","bell peppers","steak"};
            for (var index = 0; index < prices.Length; ++index)
            {
                prices[index] = index + 1;
            };

            DisplayArray(prices);

            var input = "field1, field2, field3; field4 ,, field5";
            var fields = input.Split(',', ';');
        }

        private static void DisplayArray( int[] values/*, int count*/ )
        {
            //focuses on the enumeration 
            foreach (var item in values)
            {
                //Console.WriteLine(values[index]);
                Console.WriteLine(item);
            };
        }

        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;
    }
}
