/*
 * Solomon Pattee
 * 2/11/2019
 * ITSE 1430 Introduction to C# Programming
 */

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

        static decimal s_total;

        // here is the list of ingredients and dish orders to pull from
        static bool Ham = false;
        static bool Bacon = false;
        static bool Pepperoni = false;
        static bool Sausage = false;
        static bool Small = false;
        static bool Medium = false;
        static bool Large = false;
        static bool BlackOlives = false;
        static bool Mushrooms = false;
        static bool Onions = false;
        static bool Peppers = false;
        static bool Traditional = false;
        static bool Garlic = false;
        static bool Oregano = false;
        static bool Regular = false;
        static bool Extra = false;
        static bool TakeOut = false;
        static bool Delivery = false;
        static bool OrderSet = false;
        static decimal totalling = 0.00M;

        // Order check for the Modify function.
        static bool orderModifiedOnce = false;

        // Order to string 
        static string Ordersol;
        
      //  public decimal Total
       // {
        //    get {
        //        return pricecheck(s_total);
        //    }
      //  }

        static decimal pricecheck( decimal OK_added )
        {
            decimal newTotal = 0.00M;

            if (OK_added > 0.00m)
            {
                newTotal += OK_added;
            } else
            {
                newTotal = 0.00M;
            }

            Console.WriteLine("{0:N2}", " Cart Price: $" + newTotal + "\n");
            return newTotal;
        }

        static void Main( string[] args )
        {
            MainMenu();
        }
        
        static void MainMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            pricecheck(s_total);

            // General menu
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
                    CLS();
                    PizzaMan();
                    userpopM = false;

                    break;

                    case "2":
                    case "two":
                    CLS();
                    Modify
                        (
                        ref Ham,
                        ref Bacon,
                        ref Pepperoni,
                        ref Sausage,
                        ref Small,
                        ref Medium,
                        ref Large,
                        ref BlackOlives,
                        ref Mushrooms,
                        ref Onions,
                        ref Peppers,
                        ref Traditional,
                        ref Garlic,
                        ref Oregano,
                        ref Regular,
                        ref Extra,
                        ref TakeOut,
                        ref Delivery,
                        ref OrderSet
                        );
                    userpopM = false;

                    break;

                    case "3":
                    case "three":
                    CLS();
                    DisplayOrders2
                        (
                        ref Ham,
                        ref Bacon,
                        ref Pepperoni,
                        ref Sausage,
                        ref Small,
                        ref Medium,
                        ref Large,
                        ref BlackOlives,
                        ref Mushrooms,
                        ref Onions,
                        ref Peppers,
                        ref Traditional,
                        ref Garlic,
                        ref Oregano,
                        ref Regular,
                        ref Extra,
                        ref TakeOut,
                        ref Delivery,
                        ref OrderSet
                        );
                    userpopM = false;

                    break;

                    //Exits by default
                    case "4":
                    case "four":
                    CLS();
                    userpopM = false;

                    break;

                    default:

                    Console.WriteLine("Invalid input.");
                    CLS();
                    break;

                }
            } while (userpopM == true);
        }

        public static void Orders()
        {
            // Prompting the user if the order has been set
            if (OrderSet == true)
            {
                Console.WriteLine("Do you want to Start over?");

                string prompt = Console.ReadLine();
                //bool popper = false;
                switch (prompt)
                {
                    case "yes":
                    case "Yes":
                    case "y":
                    totalling = 0.00M;
                    break;

                    case "no":
                    case "No":
                    case "n":
                    MainMenu();
                    break;

                    default:

                    break;
                }
            } 

            // booleans for each item
            bool MyMushrooms = false;
            bool MyOnions = false;
            bool MyPeppers = false;
            bool MyBC = false;
            bool MyOregano = false;
            bool MyGarlic = false;
            bool MyTraditional = false;
            bool MyRegular = false;
            bool MyExtra = false;
            bool MyTakeOut = false;
            bool MyDelivery = false;
            bool MyBacon = false;
            bool MyPepperoni = false;
            bool MySausage = false;
            bool MyHam = false;
            bool MySmall = false;
            bool MyMedium = false;
            bool MyLarge = false;
            bool MyOrderSet = false;

            // Displaying CartPrice
            pricecheck(totalling);

            // Ordering criteria

            // size holder
            string userSize = "";

            // size type
            string pizza_size = " Small ($5),\n Medium ($6.25),\n Large ($8.75)";

            // meat type 
            string meat_Type = " ($0.75)each\n Bacon,\n Ham, Pepperoni, Sausage";

            // meat holder 
            string usermeat = "";

            // veg type 
            string veg_Type = " ($0.50)each\n Black Olives, \n Mushrooms, \n, Onions \n Peppers";

            // veg holder 
            string userveg = "";

            // Sause type 
            string sause_Type = " Traditional($0),\n Garlic($1),\n Oregano($1)\n";

            // sause holder 
            string usersause = "";

            // Cheese type 
            string cheese_Type = " Regular ($0), Extra ($1.25)";

            // Cheese holder 
            string usercheese = "";

            // Delivery type 
            string delivery_Type = " Take Out ($0), Delivery ($2.50)";

            // Delivery holder 
            string userdelivery = "";

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
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (userSize)
                    {
                        case "large":
                        case "Large":
                        case "lar":
                        case "l":
                        MyLarge = true;
                        Console.WriteLine("\n");
                        userSize = "Large";
                        userbusy = false;
                        break;

                        case "medium":
                        case "Medium":
                        case "med":
                        case "m":
                        MyMedium = true;
                        Console.WriteLine("\n");
                        userSize = "Medium";
                        userbusy = false;
                        break;

                        case "small":
                        case "Small":
                        case "sml":
                        case "s":
                        MySmall = true;
                        Console.WriteLine("\n");
                        userSize = "Small";
                        userbusy = false;
                        break;

                        default:

                        Console.WriteLine("Invalid input.");
                        break;
                    }
                } while (userbusy == true);

            } // size

            {
                // user is busy again
                bool popout1 = true;

                string skip = "";

                do
                {
                    // taking the meats of the pizza
                    // What Meats
                    // what meats do you want to have?
                    Console.WriteLine("What meats would you like?");
                    Console.WriteLine("Or do you not care for any?: type 'Skip'");
                    Console.WriteLine(meat_Type);

                    usermeat = Console.ReadLine();
                    Console.WriteLine("\n");

                    // Computing the amout of meats 0 or more
                    switch (usermeat)
                    {
                        case "Bacon":
                        case "bacon":
                        case "bac":
                        case "b":
                        MyBacon = true;
                        Console.WriteLine("\n");
                        usermeat = "Bacon";
                        Console.WriteLine("What other Meats?");
                        Console.WriteLine("Or are You done?: type skip if done");
                        Console.WriteLine(meat_Type);
                        skip = Console.ReadLine();
                        switch (skip)
                        {
                            case "Skip":
                            case "skip":
                            case "s":

                            popout1 = false;
                            Console.WriteLine("\n");
                            break;

                            case "Bacon":
                            case "bacon":
                            case "bac":
                            case "b":
                            MyBacon = true;
                            Console.WriteLine("\n");
                            break;

                            case "Ham":
                            case "ham":
                            case "h":
                            MyHam = true;
                            Console.WriteLine("\n");
                            break;

                            case "Pepperoni":
                            case "pepperoni":
                            case "pep":
                            case "p":
                            MyPepperoni = true;
                            Console.WriteLine("\n");
                            break;

                            case "Sausage":
                            case "sausage":
                            case "sus":
                            MySausage = true;
                            Console.WriteLine("\n");
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }

                        break;

                        case "Ham":
                        case "ham":
                        case "h":
                        MyHam = true;
                        Console.WriteLine("\n");
                        usermeat = "Ham";
                        Console.WriteLine("What other Meats?");
                        Console.WriteLine("Or are You done?: type skip if done");
                        Console.WriteLine(meat_Type);
                        skip = Console.ReadLine();
                        switch (skip)
                        {
                            case "Skip":
                            case "skip":
                            case "s":

                            popout1 = false;
                            Console.WriteLine("\n");
                            break;

                            case "Bacon":
                            case "bacon":
                            case "bac":
                            case "b":
                            MyBacon = true;
                            Console.WriteLine("\n");
                            break;

                            case "Ham":
                            case "ham":
                            case "h":
                            MyHam = true;
                            Console.WriteLine("\n");
                            break;

                            case "Pepperoni":
                            case "pepperoni":
                            case "pep":
                            case "p":
                            MyPepperoni = true;
                            Console.WriteLine("\n");
                            break;

                            case "Sausage":
                            case "sausage":
                            case "sus":
                            MySausage = true;
                            Console.WriteLine("\n");
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }

                        break;

                        case "Pepperoni":
                        case "pepperoni":
                        case "pep":
                        case "p":
                        MyPepperoni = true;
                        Console.WriteLine("\n");
                        usermeat = "Pepperoni";
                        Console.WriteLine("What other Meats?");
                        Console.WriteLine("Or are You done?: type skip if done");
                        Console.WriteLine(meat_Type);

                        skip = Console.ReadLine();
                        switch (skip)
                        {
                            case "Skip":
                            case "skip":
                            case "s":

                            popout1 = false;
                            Console.WriteLine("\n");
                            break;

                            case "Bacon":
                            case "bacon":
                            case "bac":
                            case "b":
                            MyBacon = true;
                            Console.WriteLine("\n");
                            break;

                            case "Ham":
                            case "ham":
                            case "h":
                            MyHam = true;
                            Console.WriteLine("\n");
                            break;

                            case "Pepperoni":
                            case "pepperoni":
                            case "pep":
                            case "p":
                            MyPepperoni = true;
                            Console.WriteLine("\n");
                            break;

                            case "Sausage":
                            case "sausage":
                            case "sus":
                            MySausage = true;
                            Console.WriteLine("\n");
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }

                        break;

                        case "Sausage":
                        case "sausage":
                        case "sus":
                        MySausage = true;
                        Console.WriteLine("\n");
                        usermeat = "Sausage";
                        Console.WriteLine("What other Meats?");
                        Console.WriteLine("Or are You done?: type skip if done");
                        Console.WriteLine(meat_Type);

                        skip = Console.ReadLine();
                        switch (skip)
                        {
                            case "Skip":
                            case "skip":
                            case "s":
                            Console.WriteLine("\n");
                            popout1 = false;

                            break;

                            case "Bacon":
                            case "bacon":
                            case "bac":
                            case "b":
                            Console.WriteLine("\n");
                            MyBacon = true;
                            break;

                            case "Ham":
                            case "ham":
                            case "h":
                            Console.WriteLine("\n");
                            MyHam = true;
                            break;

                            case "Pepperoni":
                            case "pepperoni":
                            case "pep":
                            case "p":
                            Console.WriteLine("\n");
                            MyPepperoni = true;
                            break;

                            case "Sausage":
                            case "sausage":
                            case "sus":
                            Console.WriteLine("\n");
                            MySausage = true;
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }

                        break;

                        case "skip":
                        case "Skip":
                        Console.WriteLine("\n");
                        popout1 = false;

                        break;

                        default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("\n");
                        break;
                    }
                    // go back to the top

                } while (popout1 == true);

            } // Neat Meats being eat(taken)

            {
                // user is busy again
                bool popout2 = true;

                string skip2 = "";

                do
                {
                    // What vegetables

                    Console.WriteLine("What vegetables would you like?");
                    Console.WriteLine("Or are You done?: type skip if done");
                    Console.WriteLine(veg_Type);

                    userveg = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (userveg)
                    {
                        case "Black Olives":
                        case "blackolives":
                        case "BlackOlives":
                        case "bo":
                        Console.WriteLine("\n");
                        userveg = "Black Olives";
                        Console.WriteLine("What other Veggies?");
                        Console.WriteLine("Or are You done?: Type 'Skip'");
                        Console.WriteLine(veg_Type);
                        skip2 = Console.ReadLine();
                        switch (skip2)
                        {
                            case "Black Olives":
                            case "blackolives":
                            case "BlackOlives":
                            case "bo":
                            Console.WriteLine("\n");
                            MyBC = true;
                            break;

                            case "Mushrooms":
                            case "shrooms":
                            case "m":
                            Console.WriteLine("\n");
                            MyMushrooms = true;
                            break;

                            case "Onions":
                            case "onions":
                            case "oni":
                            case "o":
                            Console.WriteLine("\n");
                            MyOnions = true;
                            break;

                            case "Skip":
                            case "skip":
                            case "s":
                            Console.WriteLine("\n");
                            popout2 = false;

                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }
                        MyBC = true;

                        break;

                        case "Mushrooms":
                        case "shrooms":
                        case "m":
                        userveg = "Mushrooms";
                        Console.WriteLine("\n");
                        Console.WriteLine("What other Veggies?");
                        Console.WriteLine("Or are You done?: Type 'Skip'");
                        Console.WriteLine(veg_Type);
                        skip2 = Console.ReadLine();
                        switch (skip2)
                        {
                            case "Black Olives":
                            case "blackolives":
                            case "BlackOlives":
                            case "bo":
                            MyBC = true;
                            Console.WriteLine("\n");
                            break;

                            case "Mushrooms":
                            case "shrooms":
                            case "m":
                            MyMushrooms = true;
                            Console.WriteLine("\n");
                            break;

                            case "Onions":
                            case "onions":
                            case "oni":
                            case "o":
                            MyOnions = true;
                            Console.WriteLine("\n");
                            break;

                            case "Skip":
                            case "skip":
                            case "s":

                            popout2 = false;
                            Console.WriteLine("\n");
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }
                        MyMushrooms = true;
                        Console.WriteLine("\n");
                        break;

                        case "Onions":
                        case "onions":
                        case "oni":
                        case "o":
                        userveg = "Onions";
                        Console.WriteLine("\n");
                        Console.WriteLine("What other Veggies?");
                        Console.WriteLine("Or are You done?: Type 'Skip'");
                        Console.WriteLine(veg_Type);
                        skip2 = Console.ReadLine();
                        switch (skip2)
                        {
                            case "Black Olives":
                            case "blackolives":
                            case "BlackOlives":
                            case "bo":
                            Console.WriteLine("\n");
                            MyBC = true;
                            break;

                            case "Mushrooms":
                            case "shrooms":
                            case "m":
                            Console.WriteLine("\n");
                            MyMushrooms = true;
                            break;

                            case "Onions":
                            case "onions":
                            case "oni":
                            case "o":
                            Console.WriteLine("\n");
                            MyOnions = true;
                            break;

                            case "Skip":
                            case "skip":
                            case "s":
                            Console.WriteLine("\n");
                            popout2 = false;

                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }
                        MyOnions = true;

                        break;

                        case "Peppers":
                        case "peppers":
                        case "p":
                        userveg = "Peppers";
                        Console.WriteLine("What other Veggies?");
                        Console.WriteLine("Or are You done?: Type 'Skip'");
                        Console.WriteLine(veg_Type);
                        skip2 = Console.ReadLine();
                        switch (skip2)
                        {
                            case "Black Olives":
                            case "blackolives":
                            case "BlackOlives":
                            case "bo":
                            Console.WriteLine("\n");
                            MyBC = true;
                            break;

                            case "Mushrooms":
                            case "shrooms":
                            case "m":
                            Console.WriteLine("\n");
                            MyMushrooms = true;
                            break;

                            case "Onions":
                            case "onions":
                            case "oni":
                            case "o":
                            Console.WriteLine("\n");
                            MyOnions = true;
                            break;

                            case "Skip":
                            case "skip":
                            case "s":
                            Console.WriteLine("\n");
                            popout2 = false;

                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }
                        MyPeppers = true;

                        break;

                        case "skip":
                        case "Skip":
                        Console.WriteLine("\n");
                        popout2 = false;
                        break;

                        default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("\n");
                        break;
                    }

                } while (popout2 == true);

            } // veggeies being taken

            {
                // user is busy again
                bool popout4 = true;

                do
                {
                    // What Sause type

                    Console.WriteLine("What type of sause would you like?");
                    Console.WriteLine(sause_Type);

                    usersause = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (usersause)
                    {
                        case "Traditional":
                        case "traditional":
                        case "tr":
                        case "t":
                        Console.WriteLine("\n");
                        usersause = "Traditional";
                        MyTraditional = true;
                        popout4 = false;
                        break;

                        case "Garlic":
                        case "garlic":
                        case "g":
                        Console.WriteLine("\n");
                        usersause = "Garlic";
                        MyGarlic = true;
                        popout4 = false;
                        break;

                        case "Oregano":
                        case "oregano":
                        case "o":
                        Console.WriteLine("\n");
                        usersause = "Oregano";
                        MyOregano = true;
                        popout4 = false;
                        break;

                        default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("\n");
                        break;
                    }

                } while (popout4 == true);

            } // sause being taken

            {
                // user is busy again
                bool popout3 = true;

                do
                {
                    // What Cheese type

                    Console.WriteLine("Extra cheese or Regular amount?");
                    Console.WriteLine(cheese_Type);

                    usercheese = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (usercheese)
                    {
                        case "Regular":
                        case "regular":
                        case "R":
                        case "r":
                        MyRegular = true;
                        Console.WriteLine("\n");
                        usercheese = "Regular";
                        popout3 = false;
                        break;

                        case "Extra":
                        case "extra":
                        case "Ex":
                        case "e":
                        MyExtra = true;
                        Console.WriteLine("\n");
                        usercheese = "Extra";
                        popout3 = false;
                        break;

                        default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("\n");
                        break;
                    }

                } while (popout3 == true);

            } // Cheese being taken

            {
                // user is busy again
                bool popout5 = true;

                do
                {
                    // Delivery or Takout

                    Console.WriteLine("Takeout or Delivery?");
                    Console.WriteLine(delivery_Type);

                    userdelivery = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (userdelivery)
                    {
                        case "Takeout":
                        case "Take Out":
                        case "TakeOut":
                        case "takeout":
                        case "to":
                        Console.WriteLine("\n");
                        MyTakeOut = true;
                        userdelivery = "Take Out";
                        popout5 = false;
                        break;

                        case "Delivery":
                        case "delivery":
                        case "d":
                        Console.WriteLine("\n");
                        MyDelivery = true;
                        userdelivery = "Delivery";
                        popout5 = false;
                        break;

                        default:
                        Console.WriteLine("\n");
                        Console.WriteLine("Invalid input.");
                        break;
                    }


                } while (popout5 == true);

            } // Delivery?

            Tally
            (
            ref MyHam,
            ref MyBacon,
            ref MyPepperoni,
            ref MySausage,
            ref MySmall,
            ref MyMedium,
            ref MyLarge,
            ref MyBC,
            ref MyMushrooms,
            ref MyOnions,
            ref MyPeppers,
            ref MyTraditional,
            ref MyGarlic,
            ref MyOregano,
            ref MyRegular,
            ref MyExtra,
            ref MyTakeOut,
            ref MyDelivery,
            ref MyOrderSet
            );
            
            MainMenu();

        }
        
        public static void Modify
            (
            ref bool Ham,
            ref bool Bacon,
            ref bool Pepperoni,
            ref bool Sausage,
            ref bool Small,
            ref bool Medium,
            ref bool Large,
            ref bool BlackOlives,
            ref bool Mushrooms,
            ref bool Onions,
            ref bool Peppers,
            ref bool Traditional,
            ref bool Garlic,
            ref bool Oregano,
            ref bool Regular,
            ref bool Extra,
            ref bool TakeOut,
            ref bool Delivery,
            ref bool OrderSet
            )
        {
            // Check if the order has been modified
        orderModifiedOnce = false;

        if (OrderSet == false)
        {
            Console.WriteLine("No order has been set...");
            Console.WriteLine("Error...");
            MainMenu();
        } 
        else
        {
            // Booleans needed for change creating the list
            // displaying all orders
            Console.WriteLine("Here is your previous order..");

            {
                // size
                Console.WriteLine("Sizes\n");
                if (Small == true)
                {
                    Console.WriteLine("\tSmall\t\t $5.00\n");
                }
                if (Medium == true)
                {
                    Console.WriteLine("\tMedium\t\t $6.25\n");
                }
                if (Large == true)
                {
                    Console.WriteLine("\tLarge\t\t $8.75\n");
                }
                Console.WriteLine("\n");

            } // Sizes

            {
                // delivery_type
                if (Delivery == true)
                {
                    Console.WriteLine("Delivery\n");
                }

                if (TakeOut == true)
                {
                    Console.WriteLine("Take Out\n");
                }
                Console.WriteLine("\n");
            } // Delivery

            {
                //vegetables
                if (Onions == true)
                {
                    Console.WriteLine("\tOnions\t\t $0.50\n");
                }

                if (Mushrooms == true)
                {
                    Console.WriteLine("\tMushrooms\t\t $0.50\n");
                }

                if (Peppers == true)
                {
                    Console.WriteLine("\tPeppers\t\t $0.50\n");
                }

                if (BlackOlives == true)
                {
                    Console.WriteLine("\tBlackOlives\t\t $0.50\n");
                }
                Console.WriteLine("\n");

            } // Veggies

            {
                //meats
                if (Bacon == true)
                {
                    Console.WriteLine("\tBacon\t\t $0.75\n");
                }

                if (Ham == true)
                {
                    Console.WriteLine("\tHam\t\t $0.75\n");
                }

                if (Pepperoni == true)
                {
                    Console.WriteLine("\tPepperoni\t\t $0.75\n");
                }

                if (Sausage == true)
                {
                    Console.WriteLine("\tSausage\t\t $0.75\n");
                }
                Console.WriteLine("\n");

            } // meats

            {
                //cheese
                if (Regular == true)
                {
                    Console.WriteLine("\tRegular\t\t $0.00\n");
                }

                if (Extra == true)
                {
                    Console.WriteLine("\tExtra\t\t $1.25\n");
                }
            } // chesee

            {
                //sause
                if (Oregano == true)
                {
                    Console.WriteLine("\n\tOregano \t\t $1.00\n");
                }

                if (Garlic == true)
                {
                    Console.WriteLine("\n\tGarlic \t\t $1.00\n");
                }

                if (Traditional == true)
                {
                    Console.WriteLine("\n\tTraditional \t\t $0.00\n");
                }
                Console.WriteLine("\n");

            } // sause

            Console.WriteLine("-----------------------\n");
            Console.WriteLine("Total\t\t " + pricecheck(totalling));

            // Here is where you confirm what your order looks like...
            Console.WriteLine("Order Ok?: Yes/No");

            // Reading in the user's input for modifications...
            string input_man = Console.ReadLine();
            switch (input_man)
            {
                case "Yes":
                case "yes":
                CLS();
                MainMenu();
                break;
                
                case "No":
                case "no":
                CLS();
                Orders2
                (
                ref Ham,
                ref  Bacon,
                ref  Pepperoni,
                ref  Sausage,
                ref  Small,
                ref  Medium,
                ref  Large,
                ref BlackOlives,
                ref  Mushrooms,
                ref  Onions,
                ref Peppers,
                ref Traditional,
                ref Garlic,
                ref  Oregano,
                ref Regular,
                ref Extra,
                ref  TakeOut,
                ref  Delivery,
                ref  OrderSet
                );
                break;

            }
        }
        }

        public static void Orders2
        (
        ref bool Ham,
        ref bool Bacon,
        ref bool Pepperoni,
        ref bool Sausage,
        ref bool Small,
        ref bool Medium,
        ref bool Large,
        ref bool BlackOlives,
        ref bool Mushrooms,
        ref bool Onions,
        ref bool Peppers,
        ref bool Traditional,
        ref bool Garlic,
        ref bool Oregano,
        ref bool Regular,
        ref bool Extra,
        ref bool TakeOut,
        ref bool Delivery,
        ref bool OrderSet
        )
        {
            //Order has been modified check
            orderModifiedOnce = true;

            // Total
            decimal totalZMod = 0.00M;

            // Displaying CartPrice unchanged
            pricecheck(s_total);

            // Ordering criteria

            // size holder
            string userSize = "";

            // size type
            string pizza_size = "Small ($5),\n Medium ($6.25),\n Large ($8.75)";

            // meat type 
            string meat_Type = "($0.75)each\n Bacon,\n Ham, Pepperoni, Sausage";

            // meat holder 
            string usermeat = "";

            // veg type 
            string veg_Type = "($0.50)each\n Black Olives, \n Mushrooms, \n, Onions \n Peppers";

            // veg holder 
            string userveg = "";

            // Sause type 
            string sause_Type = "Traditional($0),\n Garlic($1),\n Oregano($1)\n";

            // sause holder 
            string usersause = "";

            // Cheese type 
            string cheese_Type = "Regular ($0), Extra ($1.25)";

            // Cheese holder 
            string usercheese = "";

            // Delivery type 
            string delivery_Type = "Take Out ($0), Delivery ($2.50)";

            // Delivery holder 
            string userdelivery = "";

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
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (userSize)
                    {
                        case "large":
                        case "Large":
                        case "lar":
                        case "l":
                        Large = true;
                        Console.WriteLine("\n");
                        userSize = "Large";
                        userbusy = false;
                        break;

                        case "medium":
                        case "Medium":
                        case "med":
                        case "m":
                        Medium = true;
                        Console.WriteLine("\n");
                        userSize = "Medium";
                        userbusy = false;
                        break;

                        case "small":
                        case "Small":
                        case "sml":
                        case "s":
                        Small = true;
                        Console.WriteLine("\n");
                        userSize = "Small";
                        userbusy = false;
                        break;

                        default:

                        Console.WriteLine("Invalid input.");
                        break;
                    }
                } while (userbusy == true);

            } // size

            {
                // user is busy again
                bool popout1 = true;

                string skip = "";

                do
                {
                    // taking the meats of the pizza
                    // What Meats
                    // what meats do you want to have?
                    Console.WriteLine("What meats would you like?");
                    Console.WriteLine("Or do you not care for any?: type 'Skip'");
                    Console.WriteLine(meat_Type);

                    usermeat = Console.ReadLine();
                    Console.WriteLine("\n");

                    // Computing the amout of meats 0 or more
                    switch (usermeat)
                    {
                        case "Bacon":
                        case "bacon":
                        case "bac":
                        case "b":
                        Bacon = true;
                        Console.WriteLine("\n");
                        usermeat = "Bacon";
                        Console.WriteLine("What other Meats?");
                        Console.WriteLine("Or are You done?: type skip if done");
                        Console.WriteLine(meat_Type);
                        skip = Console.ReadLine();
                        switch (skip)
                        {
                            case "Skip":
                            case "skip":
                            case "s":

                            popout1 = false;
                            Console.WriteLine("\n");
                            break;

                            case "Bacon":
                            case "bacon":
                            case "bac":
                            case "b":
                            Bacon = true;
                            Console.WriteLine("\n");
                            break;

                            case "Ham":
                            case "ham":
                            case "h":
                            Ham = true;
                            Console.WriteLine("\n");
                            break;

                            case "Pepperoni":
                            case "pepperoni":
                            case "pep":
                            case "p":
                            Pepperoni = true;
                            Console.WriteLine("\n");
                            break;

                            case "Sausage":
                            case "sausage":
                            case "sus":
                            Sausage = true;
                            Console.WriteLine("\n");
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }

                        break;

                        case "Ham":
                        case "ham":
                        case "h":
                        Ham = true;
                        Console.WriteLine("\n");
                        usermeat = "Ham";
                        Console.WriteLine("What other Meats?");
                        Console.WriteLine("Or are You done?: type skip if done");
                        Console.WriteLine(meat_Type);
                        skip = Console.ReadLine();
                        switch (skip)
                        {
                            case "Skip":
                            case "skip":
                            case "s":

                            popout1 = false;
                            Console.WriteLine("\n");
                            break;

                            case "Bacon":
                            case "bacon":
                            case "bac":
                            case "b":
                            Bacon = true;
                            Console.WriteLine("\n");
                            break;

                            case "Ham":
                            case "ham":
                            case "h":
                            Ham = true;
                            Console.WriteLine("\n");
                            break;

                            case "Pepperoni":
                            case "pepperoni":
                            case "pep":
                            case "p":
                            Pepperoni = true;
                            Console.WriteLine("\n");
                            break;

                            case "Sausage":
                            case "sausage":
                            case "sus":
                            Sausage = true;
                            Console.WriteLine("\n");
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }

                        break;

                        case "Pepperoni":
                        case "pepperoni":
                        case "pep":
                        case "p":
                        Pepperoni = true;
                        Console.WriteLine("\n");
                        usermeat = "Pepperoni";
                        Console.WriteLine("What other Meats?");
                        Console.WriteLine("Or are You done?: type skip if done");
                        Console.WriteLine(meat_Type);

                        skip = Console.ReadLine();
                        switch (skip)
                        {
                            case "Skip":
                            case "skip":
                            case "s":

                            popout1 = false;
                            Console.WriteLine("\n");
                            break;

                            case "Bacon":
                            case "bacon":
                            case "bac":
                            case "b":
                            Bacon = true;
                            Console.WriteLine("\n");
                            break;

                            case "Ham":
                            case "ham":
                            case "h":
                            Ham = true;
                            Console.WriteLine("\n");
                            break;

                            case "Pepperoni":
                            case "pepperoni":
                            case "pep":
                            case "p":
                            Pepperoni = true;
                            Console.WriteLine("\n");
                            break;

                            case "Sausage":
                            case "sausage":
                            case "sus":
                            Sausage = true;
                            Console.WriteLine("\n");
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }

                        break;

                        case "Sausage":
                        case "sausage":
                        case "sus":
                        Sausage = true;
                        Console.WriteLine("\n");
                        usermeat = "Sausage";
                        Console.WriteLine("What other Meats?");
                        Console.WriteLine("Or are You done?: type skip if done");
                        Console.WriteLine(meat_Type);

                        skip = Console.ReadLine();
                        switch (skip)
                        {
                            case "Skip":
                            case "skip":
                            case "s":
                            Console.WriteLine("\n");
                            popout1 = false;

                            break;

                            case "Bacon":
                            case "bacon":
                            case "bac":
                            case "b":
                            Console.WriteLine("\n");
                            Bacon = true;
                            break;

                            case "Ham":
                            case "ham":
                            case "h":
                            Console.WriteLine("\n");
                            Ham = true;
                            break;

                            case "Pepperoni":
                            case "pepperoni":
                            case "pep":
                            case "p":
                            Console.WriteLine("\n");
                            Pepperoni = true;
                            break;

                            case "Sausage":
                            case "sausage":
                            case "sus":
                            Console.WriteLine("\n");
                            Sausage = true;
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }

                        break;

                        case "skip":
                        case "Skip":
                        Console.WriteLine("\n");
                        popout1 = false;

                        break;

                        default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("\n");
                        break;
                    }
                    // go back to the top

                } while (popout1 == true);

            } // Neat Meats being eat(taken)

            {
                // user is busy again
                bool popout2 = true;

                string skip2 = "";

                do
                {
                    // What vegetables

                    Console.WriteLine("What vegetables would you like?");
                    Console.WriteLine("Or are You done?: type skip if done");
                    Console.WriteLine(veg_Type);

                    userveg = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (userveg)
                    {
                        case "Black Olives":
                        case "blackolives":
                        case "BlackOlives":
                        case "bo":
                        Console.WriteLine("\n");
                        userveg = "Black Olives";
                        Console.WriteLine("What other Veggies?");
                        Console.WriteLine("Or are You done?: Type 'Skip'");
                        Console.WriteLine(veg_Type);
                        skip2 = Console.ReadLine();
                        switch (skip2)
                        {
                            case "Black Olives":
                            case "blackolives":
                            case "BlackOlives":
                            case "bo":
                            Console.WriteLine("\n");
                            BlackOlives = true;
                            break;

                            case "Mushrooms":
                            case "shrooms":
                            case "m":
                            Console.WriteLine("\n");
                            Mushrooms = true;
                            break;

                            case "Onions":
                            case "onions":
                            case "oni":
                            case "o":
                            Console.WriteLine("\n");
                            Onions = true;
                            break;

                            case "Skip":
                            case "skip":
                            case "s":
                            Console.WriteLine("\n");
                            popout2 = false;

                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }
                        BlackOlives = true;

                        break;

                        case "Mushrooms":
                        case "shrooms":
                        case "m":
                        userveg = "Mushrooms";
                        Console.WriteLine("\n");
                        Console.WriteLine("What other Veggies?");
                        Console.WriteLine("Or are You done?: Type 'Skip'");
                        Console.WriteLine(veg_Type);
                        skip2 = Console.ReadLine();
                        switch (skip2)
                        {
                            case "Black Olives":
                            case "blackolives":
                            case "BlackOlives":
                            case "bo":
                            BlackOlives = true;
                            Console.WriteLine("\n");
                            break;

                            case "Mushrooms":
                            case "shrooms":
                            case "m":
                            Mushrooms = true;
                            Console.WriteLine("\n");
                            break;

                            case "Onions":
                            case "onions":
                            case "oni":
                            case "o":
                            Onions = true;
                            Console.WriteLine("\n");
                            break;

                            case "Skip":
                            case "skip":
                            case "s":

                            popout2 = false;
                            Console.WriteLine("\n");
                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }
                        Mushrooms = true;
                        Console.WriteLine("\n");
                        break;

                        case "Onions":
                        case "onions":
                        case "oni":
                        case "o":
                        userveg = "Onions";
                        Console.WriteLine("\n");
                        Console.WriteLine("What other Veggies?");
                        Console.WriteLine("Or are You done?: Type 'Skip'");
                        Console.WriteLine(veg_Type);
                        skip2 = Console.ReadLine();
                        switch (skip2)
                        {
                            case "Black Olives":
                            case "blackolives":
                            case "BlackOlives":
                            case "bo":
                            Console.WriteLine("\n");
                            BlackOlives = true;
                            break;

                            case "Mushrooms":
                            case "shrooms":
                            case "m":
                            Console.WriteLine("\n");
                            Mushrooms = true;
                            break;

                            case "Onions":
                            case "onions":
                            case "oni":
                            case "o":
                            Console.WriteLine("\n");
                            Onions = true;
                            break;

                            case "Skip":
                            case "skip":
                            case "s":
                            Console.WriteLine("\n");
                            popout2 = false;

                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }
                        Onions = true;

                        break;

                        case "Peppers":
                        case "peppers":
                        case "p":
                        userveg = "Peppers";
                        Console.WriteLine("What other Veggies?");
                        Console.WriteLine("Or are You done?: Type 'Skip'");
                        Console.WriteLine(veg_Type);
                        skip2 = Console.ReadLine();
                        switch (skip2)
                        {
                            case "Black Olives":
                            case "blackolives":
                            case "BlackOlives":
                            case "bo":
                            Console.WriteLine("\n");
                            BlackOlives = true;
                            break;

                            case "Mushrooms":
                            case "shrooms":
                            case "m":
                            Console.WriteLine("\n");
                            Mushrooms = true;
                            break;

                            case "Onions":
                            case "onions":
                            case "oni":
                            case "o":
                            Console.WriteLine("\n");
                            Onions = true;
                            break;

                            case "Skip":
                            case "skip":
                            case "s":
                            Console.WriteLine("\n");
                            popout2 = false;

                            break;

                            default:

                            Console.WriteLine("Invalid Option");
                            Console.WriteLine("\n");
                            break;
                        }
                        Peppers = true;

                        break;

                        case "skip":
                        case "Skip":
                        Console.WriteLine("\n");
                        popout2 = false;
                        break;

                        default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("\n");
                        break;
                    }

                } while (popout2 == true);

            } // veggeies being taken

            {
                // user is busy again
                bool popout4 = true;

                do
                {
                    // What Sause type

                    Console.WriteLine("What type of sause would you like?");
                    Console.WriteLine(sause_Type);

                    usersause = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (usersause)
                    {
                        case "Traditional":
                        case "traditional":
                        case "tr":
                        case "t":
                        Console.WriteLine("\n");
                        usersause = "Traditional";
                        Traditional = true;
                        popout4 = false;
                        break;

                        case "Garlic":
                        case "garlic":
                        case "g":
                        Console.WriteLine("\n");
                        usersause = "Garlic";
                        Garlic = true;
                        popout4 = false;
                        break;

                        case "Oregano":
                        case "oregano":
                        case "o":
                        Console.WriteLine("\n");
                        usersause = "Oregano";
                        Oregano = true;
                        popout4 = false;
                        break;

                        default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("\n");
                        break;
                    }

                } while (popout4 == true);

            } // sause being taken

            {
                // user is busy again
                bool popout3 = true;

                do
                {
                    // What Cheese type

                    Console.WriteLine("Extra cheese or Regular amount?");
                    Console.WriteLine(cheese_Type);

                    usercheese = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (usercheese)
                    {
                        case "Regular":
                        case "regular":
                        case "R":
                        case "r":
                        Regular = true;
                        Console.WriteLine("\n");
                        usercheese = "Regular";
                        popout3 = false;
                        break;

                        case "Extra":
                        case "extra":
                        case "Ex":
                        case "e":
                        Extra = true;
                        Console.WriteLine("\n");
                        usercheese = "Extra";
                        popout3 = false;
                        break;

                        default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("\n");
                        break;
                    }

                } while (popout3 == true);

            } // Cheese being taken

            {
                // user is busy again
                bool popout5 = true;

                do
                {
                    // Delivery or Takout

                    Console.WriteLine("Takeout or Delivery?");
                    Console.WriteLine(delivery_Type);

                    userdelivery = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Computing the size
                    switch (userdelivery)
                    {
                        case "Takeout":
                        case "Take Out":
                        case "TakeOut":
                        case "takeout":
                        case "to":
                        Console.WriteLine("\n");
                        TakeOut = true;
                        userdelivery = "Take Out";
                        popout5 = false;
                        break;

                        case "Delivery":
                        case "delivery":
                        case "d":
                        Console.WriteLine("\n");
                        Delivery = true;
                        userdelivery = "Delivery";
                        popout5 = false;
                        break;

                        default:
                        Console.WriteLine("\n");
                        Console.WriteLine("Invalid input.");
                        break;
                    }


                } while (popout5 == true);

            } // Delivery?
            // Displaying CartPrice
            pricecheck(totalZMod);

            Tally
                (
                ref Ham,
                ref Bacon,
                ref Pepperoni,
                ref Sausage,
                ref Small,
                ref Medium,
                ref Large,
                ref BlackOlives,
                ref Mushrooms,
                ref Onions,
                ref Peppers,
                ref Traditional,
                ref Garlic,
                ref Oregano,
                ref Regular,
                 ref Extra,
                 ref TakeOut,
                ref Delivery,
                ref OrderSet
                );
            orderModifiedOnce = true;
            CLS();

            DisplayOrders2
                (
                ref Ham,
                ref Bacon,
                ref Pepperoni,
                ref Sausage,
                ref Small,
                ref Medium,
                ref Large,
                ref BlackOlives,
                ref Mushrooms,
                ref Onions,
                ref Peppers,
                ref Traditional,
                ref Garlic,
                ref Oregano,
                ref Regular,
                 ref Extra,
                 ref TakeOut,
                ref Delivery,
                ref OrderSet
                );

        }

          public static void Tally
          (
          ref bool Ham,
          ref bool Bacon,
          ref bool Pepperoni,
          ref bool Sausage,
          ref bool Small,
          ref bool Medium,
          ref bool Large,
          ref bool BlackOlives,
          ref bool Mushrooms,
          ref bool Onions,
          ref bool Peppers,
          ref bool Traditional,
          ref bool Garlic,
          ref bool Oregano,
          ref bool Regular,
          ref bool Extra,
          ref bool TakeOut,
          ref bool Delivery,
          ref bool OrderSet
          ) // Tab is here
        {
            //all the stuff being ordered are totaled here.
            //Counting the totals

            {
                // sizes
                if (Small == true)
                {
                    totalling += 5.00M;
                }

                if (Medium == true)
                {
                    totalling += 6.25M;
                }

                if (Large == true)
                {
                    totalling += 8.75M;
                }

            }// size buisness

            {
                if (Traditional == true)
                {
                    totalling += 0.00M;
                }

                if (Garlic == true)
                {
                    totalling += 1.00M;
                }

                if (Oregano == true)
                {
                    totalling += 1.00M;
                }

            }// Sause

            {
                if (Regular == true)
                {
                    totalling += 0.00M;
                }

                if (Extra == true)
                {
                    totalling += 1.25M;
                }
            }// Cheese

            {
                //meats added
                if (Ham == true)
                {
                    totalling += 0.75M;
                }

                if (Bacon == true)
                {
                    totalling += 0.75M;
                }

                if (Pepperoni == true)
                {
                    totalling += 0.75M;
                }

                if (Sausage == true)
                {
                    totalling += 0.75M;
                }
            }// meat buisness

            {
                if (BlackOlives == true)
                {
                    totalling += 0.50M;
                }

                if (Mushrooms == true)
                {
                    totalling += 0.50M;
                }

                if (Onions == true)
                {
                    totalling += 0.50M;
                }

                if (Peppers == true)
                {
                    totalling += 0.50M;
                }

            }// veggies

            {
                if (TakeOut == true)
                {
                    totalling += 0.00M;
                }

                if (Delivery == true)
                {
                    totalling += 2.50M;
                }
            }// Delivery

            
            //This is the Pizza method call for 
            //passing values to this outside method
            

            // this is the Function that will sort out everything
            OrderSet = true;

            DisplayOrders2
            (
            ref Ham,
            ref Bacon,
            ref Pepperoni,
            ref Sausage,
            ref Small,
            ref Medium,
            ref Large,
            ref BlackOlives,
            ref Mushrooms,
            ref Onions,
            ref Peppers,
            ref Traditional,
            ref Garlic,
            ref Oregano,
            ref Regular,
            ref Extra,
            ref TakeOut,
            ref Delivery,
            ref OrderSet
            );
        }

        public static void CLS()
        {
            Console.Clear();
        }

        static string DisplayOrders2
            (
            ref bool Ham,
            ref bool Bacon,
            ref bool Pepperoni,
            ref bool Sausage,
            ref bool Small,
            ref bool Medium,
            ref bool Large,
            ref bool BlackOlives,
            ref bool Mushrooms,
            ref bool Onions,
            ref bool Peppers,
            ref bool Traditional,
            ref bool Garlic,
            ref bool Oregano,
            ref bool Regular,
            ref bool Extra,
            ref bool TakeOut,
            ref bool Delivery,
            ref bool OrderSet 
            )
        {
            if (OrderSet == true)
            {
                // displaying all orders
                Console.WriteLine("Here is your latest order..");

                {
                    // size
                    Console.WriteLine("Sizes\n");
                    if (Small == true)
                    {
                        Console.WriteLine("\tSmall\t\t $5.00\n");
                    }
                    if (Medium == true)
                    {
                        Console.WriteLine("\tMedium\t\t $6.25\n");
                    }
                    if (Large == true)
                    {
                        Console.WriteLine("\tLarge\t\t $8.75\n");
                    }
                    Console.WriteLine("\n");

                } // Sizes

                {
                    // delivery_type
                    if (Delivery == true)
                    {
                        Console.WriteLine("Delivery\n");
                    }

                    if (TakeOut == true)
                    {
                        Console.WriteLine("Take Out\n");
                    }
                    Console.WriteLine("\n");
                } // Delivery

                {
                    //vegetables
                    if (Onions == true)
                    {
                        Console.WriteLine("\tOnions\t\t $0.50\n");
                    }

                    if (Mushrooms == true)
                    {
                        Console.WriteLine("\tMushrooms\t\t $0.50\n");
                    }

                    if (Peppers == true)
                    {
                        Console.WriteLine("\tPeppers\t\t $0.50\n");
                    }

                    if (BlackOlives == true)
                    {
                        Console.WriteLine("\tBlackOlives\t\t $0.50\n");
                    }
                    Console.WriteLine("\n");

                } // Veggies

                {
                    //meats
                    if (Bacon == true)
                    {
                        Console.WriteLine("\tBacon\t\t $0.75\n");
                    }

                    if (Ham == true)
                    {
                        Console.WriteLine("\tHam\t\t $0.75\n");
                    }

                    if (Pepperoni == true)
                    {
                        Console.WriteLine("\tPepperoni\t\t $0.75\n");
                    }

                    if (Sausage == true)
                    {
                        Console.WriteLine("\tSausage\t\t $0.75\n");
                    }
                    Console.WriteLine("\n");

                } // meats

                {
                    //cheese
                    if (Regular == true)
                    {
                        Console.WriteLine("\tRegular\t\t $0.00\n");
                    }

                    if (Extra == true)
                    {
                        Console.WriteLine("\tExtra\t\t $1.25\n");
                    }
                } // chesee

                {
                    //sause
                    if (Oregano == true)
                    {
                        Console.WriteLine("\n\tOregano \t\t $1.00\n");
                    }

                    if (Garlic == true)
                    {
                        Console.WriteLine("\n\tGarlic \t\t $1.00\n");
                    }

                    if (Traditional == true)
                    {
                        Console.WriteLine("\n\tTraditional \t\t $0.00\n");
                    }
                    Console.WriteLine("\n");

                } // sause

                Console.WriteLine("-----------------------\n");
                Console.WriteLine("Total\t\t " + pricecheck(totalling));

                // Here is where you confirm what your order looks like...
                Console.WriteLine("Order Ok?");
                string watchFK = Console.ReadLine();

                Pause();
            } 
            
            else
            {
                Console.WriteLine("No Order Exists...");
                Console.WriteLine("Would you like to start a new one?");

                PizzaMan();
            }

            string orderWritten = DisplayOrders2

            (
            ref Ham,
            ref Bacon,
            ref Pepperoni,
            ref Sausage,
            ref Small,
            ref Medium,
            ref Large,
            ref BlackOlives,
            ref Mushrooms,
            ref Onions,
            ref Peppers,
            ref Traditional,
            ref Garlic,
            ref Oregano,
            ref Regular,
            ref Extra,
            ref TakeOut,
            ref Delivery,
            ref OrderSet
            );
            
            // clear the console
            CLS();

            Ordersol = orderWritten;
            return orderWritten;
        }

        public static void PizzaMan()
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
                    case "N":
                    case "n":
                    Console.WriteLine("Ok");
                    CLS();
                    MainMenu();
                    break;

                    case "Yes":
                    case "yes":
                    case "Y":
                    case "y":
                    Console.WriteLine("Fantastic!");
                    CLS();
                    Orders();
                    break;

                    default:
                    Console.WriteLine("Invalid responce");
                    break;

                }
            } while (true);


        }

        public static void Pause()
        {
            string Enter = Console.ReadLine();
            MainMenu();
        }
    }
}

