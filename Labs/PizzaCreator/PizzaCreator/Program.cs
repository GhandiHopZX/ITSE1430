using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {

        // This is an order name.
        public string orderI;
        // this is the balance for said order.
        public decimal _displayBalance { get; set; }

        // This is the balance.
        private void Balance(ref decimal balance)
        {
          _displayBalance = balance;
        }
       
        static void Main( string[] args )
        {
            PizzaMan();
        }

        static void MainMenu()
        {
            Console.WriteLine("MAIN MENU");
        }

        static void Orders()
        {
            int x = 0;

            // what size is the Pizza
            
            //think
            // what Meats

            // what vegetables

            // what Sause amount

            // what cheese amount

            // what is it delvery or DiGiorno

        }

        static void PizzaMan()
        {
            do
            {
                Console.WriteLine("\n Would you like a Pizza?");
                Console.WriteLine("\n(Y = Yes, N = No)");
                string responce = Console.ReadLine().ToUpper();
                
                switch (responce)
                {
                    case "No":
                    case "no": 
                    Console.WriteLine("Ok");
                    MainMenu();
                    break;

                    case "Yes":
                    case "yes":
                    Console.WriteLine("Fantastic!");
                    Orders();
                    break;

                    default:
                    Console.WriteLine("Invalid responce");
                    break;

                }
            } while (true);


        }

        public void Pizza()
        {

            //Pizza orders.
            //Each object has a set of properties.
            //like every other unique pizza.

        }
    }
}

class PID
{
}