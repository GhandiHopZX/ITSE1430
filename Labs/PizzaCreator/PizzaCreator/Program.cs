using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
      
        // this is the balance for said order.
        // There's only one order so just pass these values and execute

        static decimal _total;
        
        public decimal Total
        {
            get 
                {
                return pricecheck(_total);
                }
        }

        static decimal pricecheck( decimal OK_added )
        {
            decimal newTotal = 0.00M;

            if (OK_added > 0.00m)
            {
                newTotal += OK_added;
            } 
            else
            {
                newTotal = 0.00M;
            }

            Console.WriteLine("Cart Price: $" + newTotal);
            return 0;
        }

        public void DisplayTotal(decimal NTotal)
        {
            Console.WriteLine("Cart Price: $" + NTotal);
        }

        static void Main( string[] args )
        {
            pricecheck(_total);
            MainMenu();
        }

        static void MainMenu()
        {
            string menuDisplay = 

                "MAIN MENU\n\n 1. New Order\n 2. Modify Order\n 3. Display Order\n 4. Quit";

            string mainInput = "";
            
            // Formating
            menuDisplay.PadLeft(10);

            // User is busy
            bool userpopM = true;

            // Display
            Console.WriteLine(menuDisplay);

            // Menu Loop
            do
            {
                // ask the user what he/she wants
                mainInput = Console.ReadLine();
                switch (mainInput)
                {
                    case "1":
                    case "one":
                    Orders();
                    userpopM = false;

                    break;

                    case "2":
                    case "two":
                    //DisplayOrders();
                    userpopM = false;

                    break;

                    case "3":
                    case "three":
                    //Modify();
                    userpopM = false;

                    break;

                    //Exits by default
                    case "4":
                    case "four":
                    userpopM = false;
                    
                    break;

                    default:

                    Console.WriteLine("Invalid input.");

                    break;

                }
            } while (userpopM == true);
        }

        static void DisplayOrders()
        {
            
        }

        static void Pizza
            ( 
            ref string size,
            ref string meats,
            ref int amountm,
            ref int amountv,
            ref string vegies,
            ref string sauce,
            ref string cheese,
            ref string delivery 
            )
        {
            //work on the quantity ref next bleeeeeehhhh...
            //Pizza orders.
            //Each object has a set of properties.
            //like every other unique pizza.

        }//Pizza values

        static void Orders()
        {
            // the total added
            decimal newTotal = 0.00M;

            // Displaying CartPrice
            pricecheck(newTotal);

            // number holder
            int x = 0;

            // Ordering criteria

            // size holder
            string userSize = "";
            
            // size type
            string pizza_size = "Small ($5),\n Medium ($6.25),\n Large ($8.75)";

            // meat type 
            string[] meat_Type = {"($0.75)each\n Bacon,\n ","Ham, ",
            "Pepperoni, ","Sausage"};

            // meat holder 
            string usermeat = "";
            // amout of meats
            int amountmeats = 0;

            // veg type 
            string[] veg_Type = {"($0.50)each\n Black Olives,", "\n Mushrooms,",
            "\n, Onions,", "\n Peppers"};

            // veg holder 
            string userveg = "";
            // amount of veggies
            int amountvegies = 0;

            // Sause type 
            string[] sause_Type = {"Traditional($0),\n",
            "Garlic($1),\n", "Oregano($1)\n"};

            // sause holder 
            string usersause = "";

            // Cheese type 
            string[] cheese_Type = { "Regular ($0)", "Extra ($1.25)" };

            // Cheese holder 
            string usercheese = "";

            // Delivery type 
            string[] delivery_Type = { "Take Out ($0)", "Delivery ($2.50)" };

            // Delivery holder 
            string userdelivery = "";
            
            // What Sause amount

            Console.WriteLine("What sause would you like?");
            Console.WriteLine(sause_Type);

            usersause = Console.ReadLine();

            // What cheese amount

            Console.WriteLine("What kind of cheese(s) would you like?");
            Console.WriteLine(cheese_Type);

            usercheese = Console.ReadLine();

            // Delivery or takout>?

            Console.WriteLine("Delivery or Take Out?");
            Console.WriteLine(delivery_Type);

            userdelivery = Console.ReadLine();
            // Passing values and math stuff
            // The user must make a selection therefore the user is busy

            {
                bool userbusy = true;

            do
            {
                // what size is the Pizza

                Console.WriteLine("What size of a Pizza would you like?");
                Console.WriteLine(pizza_size);
                // taking the size of the pizza

                userSize = Console.ReadLine();

                // Computing the size
                switch (userSize)
                {
                    case "large":
                    case "Large":
                    case "lar":
                    case "l":
                    userSize = "Large";
                    userbusy = false;
                    break;

                    case "medium":
                    case "Medium":
                    case "med":
                    case "m":
                    userSize = "Medium";
                    userbusy = false;
                    break;

                    case "small":
                    case "Small":
                    case "sml":
                    case "s":
                    userSize = "Small";
                    userbusy = false;
                    break;

                    default:

                    Console.WriteLine("Invalid input.");
                    break;
                }
            } while (userbusy == true);

        } 

        {
            // user is busy again
            bool popout1 = true;

            do
            {
                // taking the meats of the pizza
                
            // What Meats
            // what meats do you want to have?
            Console.WriteLine("What meats would you like?");
            
            usermeat = Console.ReadLine();
            Console.WriteLine(meat_Type);

                // Computing the amout of meats 0 or more
                switch (usermeat)
                {
                    case "Bacon":
                    case "bacon":
                    case "bac":
                    case "b":
                    
                    usermeat = "Bacon";
                    popout1 = false;
                    break;

                    case "Ham":
                    case "ham":
                    case "h":
                    usermeat = "Ham";
                    popout1 = false;
                    break;

                    case "Pepperoni":
                    case "pepperoni":
                    case "pep":
                    case "p":
                    usermeat = "Pepperoni";
                    popout1 = false;
                    break;

                    case "Sausage":
                    case "sausage":
                    case "s":
                    usermeat = "Sausage";
                    popout1 = false;
                    break;

                    default:
                    Console.WriteLine("Invalid input.");
                    break;
                }
            } while (popout1 == true);

        } // Neat Meats being eat(taken)

        {
            // user is busy again
            bool popout2 = true;

            do
            {
                // What vegetables

            Console.WriteLine("What vegetables would you like?");
            Console.WriteLine(veg_Type);

            userveg = Console.ReadLine();

                // Computing the size
                switch (userveg)
                {
                    case "Black Olives":
                    case "blackolives":
                    case "BlackOlives":
                    case "bo":
                    userveg = "Black Olives";
                    popout2 = false;
                    break;

                    case "Mushrooms":
                    case "shrooms":
                    case "m":
                    userveg = "Mushrooms";
                    popout2 = false;
                    break;

                    case "Onions":
                    case "onions":
                    case "oni":
                    case "o":
                    userveg = "Onions";
                    popout2 = false;
                    break;

                    case "Peppers":
                    case "peppers":
                    case "p":
                    userveg = "Peppers";
                    popout2 = false;
                    break;

                    default:
                    Console.WriteLine("Invalid input.");
                    break;
                }

            } while (popout2 == true);

        } // vegeies being taken

            Pizza(
                ref userSize, 
                ref usermeat,
                ref amountmeats,
                ref amountvegies, 
                ref userveg,
                ref usersause,
                ref usercheese, 
                ref userdelivery
                );

        }

        public void PizzaMan()
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
    }

    class PID
    {
        private decimal _order_price = 0.00M;

        public void Order(ref string size, 
            ref string meats, 
            ref string veg, 
            ref string sauce, 
            ref string cheese, 
            ref string delivery)
        {
            
            // Type
            switch (size)
            {
                case "tempfix":

                break;
                
            }

            // Pricing

            // Quantity

            // Order Object instantiation.
            
            return;
        }
    }
}

