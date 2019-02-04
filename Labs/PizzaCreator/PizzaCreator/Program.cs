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
            MainMenu();
        }

        static void MainMenu()
        {
            string menuDisplay = 

                { "MAIN MENU\n\n",
                "1. New Order\n",
                "2. Modify Order\n",
                "3. Display Order\n",
                "4. Quit"};
            

        }

        static void Orders()
        {
            // number holder
            int x = 0;

            // Ordering criteria

            // size holder
            string userSize= "";

            // size type
            string pizza_size = {"Small ($5),\n ","Medium ($6.25),\n ",
            "Large ($8.75)"};

            // meat type 
            string meat_Type = {"($0.75)each\n Bacon,\n ","Ham, ",
            "Pepperoni, ","Sausage"};

            // meat holder
            string usermeat = "";

            // veg type 
            string veg_Type = {"($0.50)each\n Black Olives,", "\n Mushrooms,",
            "\n, Onions,", "\n Peppers"};

            // veg holder 
            string userveg = "";

            // Sause type 
            string sause_Type = {"Traditional($0),\n",
            "Garlic($1),\n", "Oregano($1)\n"};

            // sause holder 
            string userveg = "";

            // Cheese type 
            string veg_Type = {"Regular ($0)", "Extra ($1.25)"};

            // Cheese holder 
            string usercheese = "";

            // delivery type 
            string delivery_Type = {"Take Out ($0)", "Delivery ($2.50)"};

            // veg holder 
            string userveg = "";

            // what size is the Pizza

            Console.WriteLine("What size of a Pizza would you like?");
            Console.WriteLine(pizza_size);
            
            // taking the size of the pizza

            userSize = Console.ReadLine();
            
            // what Meats
            // what meats do you want to have?
            Console.WriteLine("What meats would you like?");
            Console.WriteLine(meat_Type);
            
            usermeat = Console.ReadLine();

            // what vegetables

            Console.WriteLine("What vegetables would you like?");
            Console.WriteLine(veg_Type);
            
            userveg = Console.ReadLine();

            // what Sause amount

            Console.WriteLine("What sause would you like?");
            Console.WriteLine(sause_Type);
            
            usersause = Console.ReadLine();

            // what cheese amount

            Console.WriteLine("What kind of cheese(s) would you like?");
            Console.WriteLine(cheese_Type);
            
            usercheese = Console.ReadLine();

            // Delivery or takout>?

            Console.WriteLine("Delivery or Take Out?");
            Console.WriteLine(delivery_Type);
            
            userdelivery = Console.ReadLine();

            // Passing values and math stuff

            

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