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
        
        public decimal Total
        {
            get 
                {
                return pricecheck(s_total);
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

            Console.WriteLine("{0:N2}"," Cart Price: $" + newTotal + "\n");
            return 0;
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


        static void Pizza
            ( 
            ref string size,
            ref string meats,
            ref int amountm,
            ref int amountv,
            ref string vegies,
            ref string sauce,
            ref string cheese,
            ref string delivery,
            ref decimal subtotal
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

            // number holders
            int numVeggies = 0;

            int numMeats = 0;

            // booleans for each item
            bool BC,
                MyMushrooms,
                MyOnions,
                MyPeppers,
                MyBC,
                MyOregano, 
                MyGarlic,
                MyTraditional,
                MyRegular,
                MyExtra,
                MyTakeOut,
                MyDelivery,
                MyBacon,
                MyPepperoni,
                MySausage,
                MyHam;

            // Ordering criteria

            // size holder
            string userSize = "";
            
            // size type
            string pizza_size = "Small ($5),\n Medium ($6.25),\n Large ($8.75)";

            // meat type 
            string meat_Type = "($0.75)each\n Bacon,\n Ham, Pepperoni, Sausage";

            // meat holder 
            string usermeat = "";
            // amout of meats
            int amountmeats = 0;

            // veg type 
            string veg_Type = "($0.50)each\n Black Olives, \n Mushrooms, \n, Onions \n Peppers";

            // veg holder 
            string userveg = "";
            // amount of veggies
            int amountvegies = 0;

            // Sause type 
            string sause_Type = "Traditional($0),\n Garlic($1),\n Oregano($1)\n";

            // sause holder 
            string usersause = "";

            // Cheese type 
            string cheese_Type = "Regular ($0), Extra ($1.25)" ;

            // Cheese holder 
            string usercheese = "";

            // Delivery type 
            string delivery_Type ="Take Out ($0), Delivery ($2.50)";

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
            
            string skip = "";

            do
            {
            // taking the meats of the pizza
            // What Meats
            // what meats do you want to have?
            Console.WriteLine("What meats would you like?");
            Console.WriteLine("Or do you not care for any?: type 'Skip'");

            usermeat = Console.ReadLine();
            Console.WriteLine(meat_Type);

                // Computing the amout of meats 0 or more
                switch (usermeat)
                {
                case "Bacon":
                case "bacon":
                case "bac":
                case "b":
                MyBacon = true;
                    
                usermeat = "Bacon";
                Console.WriteLine("What other Meats?");
                Console.WriteLine("Or are You done?: Y/N?");
                Console.WriteLine(meat_Type);
                skip = Console.ReadLine();
                    switch (skip)
                    {
                        case "y":
                        case "Y":
                        case "Yes":
                        case "YES":

                        popout1 = true;

                        break;

                        case "n":
                        case "N":
                        case "No":
                        case "NO":

                        popout1 = false;

                        break;

                        default:

                        Console.WriteLine("Invalid Option");

                        break;
                    }

                        break;

                    case "Ham":
                    case "ham":
                    case "h":
                    MyHam = true;

                    usermeat = "Ham";
                    Console.WriteLine("What other Meats?");
                    Console.WriteLine("Or are You done?: Y/N?");
                    Console.WriteLine(meat_Type);
                    skip = Console.ReadLine();
                    switch (skip)
                    {
                        case "y":
                        case "Y":
                        case "Yes":
                        case "YES":

                        popout1 = true;

                        break;

                        case "n":
                        case "N":
                        case "No":
                        case "NO":

                        popout1 = false;

                        break;

                        default:

                        Console.WriteLine("Invalid Option");

                        break;
                        }

                        break;

                    case "Pepperoni":
                    case "pepperoni":
                    case "pep":
                    case "p":
                    MyPepperoni = true;

                    usermeat = "Pepperoni";
                    Console.WriteLine("What other Meats?");
                    Console.WriteLine("Or are You done?: Y/N?");
                    Console.WriteLine(meat_Type);

                    skip = Console.ReadLine();
                    switch (skip)
                    {
                        case "y":
                        case "Y":
                        case "Yes":
                        case "YES":

                        popout1 = true;

                        break;

                        case "n":
                        case "N":
                        case "No":
                        case "NO":

                        popout1 = false;

                        break;

                        default:

                        Console.WriteLine("Invalid Option");

                        break;
                    }

                        break;

                    case "Sausage":
                    case "sausage":
                    case "s":
                    MySausage = true;

                    usermeat = "Sausage";
                    Console.WriteLine("What other Meats?");
                    Console.WriteLine("Or are You done?: Y/N?");
                    Console.WriteLine(meat_Type);

                    skip = Console.ReadLine();
                    switch (skip)
                    {
                        case "y":
                        case "Y":
                        case "Yes":
                        case "YES":

                        popout1 = true;

                        break;

                        case "n":
                        case "N":
                        case "No":
                        case "NO":

                        popout1 = false;

                        break;

                        default:

                        Console.WriteLine("Invalid Option");
                        break;
                    }

                        break;

                    case "skip":
                    case "Skip":
                    popout1 = false;

                    break;

                    default:
                    Console.WriteLine("Invalid input.");
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
            Console.WriteLine("Or do you want to skip this step?: Y or N?");
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
                    Console.WriteLine("What other Meats?");
                    Console.WriteLine("Or are You done?: Y/N?");
                    Console.WriteLine(meat_Type);
                    skip2 = Console.ReadLine();
                    switch (skip2)
                        {
                            case "y":
                            case "Y":
                            case "Yes":
                            case "YES":

                            popout2 = true;

                            break;

                            case "n":
                            case "N":
                            case "No":
                            case "NO":

                            popout2 = false;

                            break;

                            default:

                            Console.WriteLine("Invalid Option");

                            break;
                        }
                        MyBC = true;
                        
                    break;

                    case "Mushrooms":
                    case "shrooms":
                    case "m":
                    userveg = "Mushrooms";
                    MyMushrooms = true;
                        
                    break;

                    case "Onions":
                    case "onions":
                    case "oni":
                    case "o":
                    userveg = "Onions";
                    MyOnions = true;
                        
                    break;

                    case "Peppers":
                    case "peppers":
                    case "p":
                    userveg = "Peppers";
                    MyPeppers = true;
                        
                    break;

                    case "skip":
                    case "Skip":
                    popout2 = false;
                    break;

                    default:
                    Console.WriteLine("Invalid input.");
                    break;
                }

            } while (popout2 == true);

        } // vegeies being taken

        {
            // user is busy again
            bool popout4 = true;

            do
            {
                // What Sause type

                Console.WriteLine("What type of sause would you like?");
                Console.WriteLine(sause_Type);

                usersause = Console.ReadLine();

                // Computing the size
                switch (usersause)
                {
                    case "Traditional":
                    case "Trad":
                    case "tr":
                    case "t":
                    usersause = "Traditional";
                    popout4 = false;

                    MyTraditional = true;
                    break;

                    case "Garlic":
                    case "garlic":
                    case "g":
                    usersause = "Garlic";

                    MyGarlic = true;
                    popout4 = false;
                    break;

                    case "Oregano":
                    case "oregano":
                    case "o":
                    usersause = "Oregano";

                    MyOregano = true;
                    popout4 = false;
                    break;

                    default:
                    Console.WriteLine("Invalid input.");
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

                // Computing the size
                switch (usercheese)
                {
                    case "Regular":
                    case "regular":
                    case "R":
                    case "r":
                    usercheese = "Regular";
                    popout3 = false;
                    break;

                    case "Extra":
                    case "Ex":
                    case "e":
                    usercheese = "Extra";
                    popout3 = false;
                    break;

                    default:
                    Console.WriteLine("Invalid input.");
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

                // Computing the size
                switch (userdelivery)
                {
                    case "Takeout":
                    case "Take Out":
                    case "TakeOut":
                    case "to":

                    MyTakeOut = true;
                    userdelivery = "Take Out";
                    popout5 = false;
                    break;

                    case "Delivery":
                    case "delivery":
                    case "d":

                    MyDelivery = true;
                    userdelivery = "Delivery";
                    popout5 = false;
                    break;

                    default:
                    Console.WriteLine("Invalid input.");
                    break;
                }

                    
            } while (popout5 == true);

        } // Delivery?

         Pizza
           (
           ref userSize,
           ref usermeat,
           ref amountmeats,
           ref amountvegies,
           ref userveg,
           ref usersause,
           ref usercheese,
           ref userdelivery,
           ref newTotal
           );
        }

        static void Tally
           (
           bool  Ham,
           bool Bacon, 
           bool Pepperoni, 
           bool Sausage,
           bool  Small,
           bool  Medium,
           bool  Large,
           bool  BlackOlives,
           bool  Mushrooms,
           bool  Onions,
           bool  Peppers,
           bool  Traditional,
           bool  Garlic,
           bool  Oregano,
           bool  Regular,
           bool  Extra,
           bool  TakeOut,
           bool  Delivery,
           decimal totaling,
           int numMeats,
           int numVeggies
           )
        {
            //Counting the totals

            {
                //all veggies and meats added
                if (Ham == true)
                {
                    //check the number of meats
                    if (numMeats > 1)
                    {
                        totaling += 0.75M;
                    } else
                    {
                        totaling += 0;
                    }
                }

                if (Bacon == true)
                {
                    //check the number of meats
                    if (numMeats > 1)
                    {
                        totaling += 0.75M;
                    } else
                    {
                        totaling += 0;
                    }
                }

                if (Pepperoni == true)
                {
                    //check the number of meats
                    if (numMeats > 1)
                    {
                        totaling += 0.75M;
                    } else
                    {
                        totaling += 0;
                    }
                }

                if (Sausage == true)
                {
                    //check the number of meats
                    if (numMeats > 1)
                    {
                        totaling += 0.75M;
                    } else
                    {
                        totaling += 0;
                    }
                }
            } //meat buisnes

            {
                if (BlackOlives == true)
                {
                    //check the number of veggies
                    if (numVeggies > 1)
                    {
                        totaling += 0.50M;
                    } else
                    {
                        totaling += 0;
                    }
                }

                if (Mushrooms == true)
                {
                    //check the number of veggies
                    if (numVeggies > 1)
                    {
                        totaling += 0.50M;
                    } else
                    {
                        totaling += 0;
                    }
                }

                if (Onions == true)
                {
                    //check the number of veggies
                    if (numVeggies > 1)
                    {
                       totaling += 0.50M;
                    } else
                    {
                       totaling += 0;
                    }
                }

                if (Peppers == true)
                {
                    //check the number of veggies
                    if (numVeggies > 1)
                    {
                        totaling += 0.50M;
                    } else
                    {
                        totaling += 0;
                    }
                }
            }// veggies

            //all the stuff being ordered are totaled here.
            //This is the Pizza method call for 
            //passing values to this outside method

            //this function here would work but it wouldn't be that neat.
            // pricecheck(totaling);

            //this is the Function that will sort out everything
            DisplayOrders
            ( 
                Ham,
             Bacon,
            Pepperoni,
             Sausage,
             Small,
             Medium,
             Large,
             BlackOlives,
             Mushrooms,
             Onions,
             Peppers,
             Traditional,
             Garlic,
             Oregano,
             Regular,
             Extra,
             TakeOut,
             Delivery,
            totaling,
            numMeats,
            numVeggies
            );

        }

        static void DisplayOrders
           ( 
           bool Ham,
           bool Bacon,
           bool Pepperoni,
           bool Sausage,
           bool Small,
           bool Medium,
           bool Large,
           bool BlackOlives,
           bool Mushrooms,
           bool Onions,
           bool Peppers,
           bool Traditional,
           bool Garlic,
           bool Oregano,
           bool Regular,
           bool Extra,
           bool TakeOut,
           bool Delivery,
           decimal totaling,
           int numMeats,
           int numVeggies 
           )
        {
            // displaying all orders
            Console.WriteLine("OK\n Your Total Is:\n\n");

            // size
            Console.WriteLine("Sizes");
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

            //cheese
            if (Regular == true)
            {
                Console.WriteLine("\tRegular\t\t $0.00\n");
            }

            if (Extra == true)
            {
                Console.WriteLine("\tExtra\t\t $1.25\n");
            }

            //sause
            if (Oregano == true)
            {
                Console.WriteLine("\tOregano \t\t $1.00\n");
            }

            if (Garlic == true)
            {
                Console.WriteLine("\tGarlic \t\t $1.00\n");
            }

            if (Traditional == true)
            {
                Console.WriteLine("\tTraditional \t\t $0.00\n");
            }

            Console.WriteLine("-----------------------\n");
            Console.WriteLine("Total\t\t " + totaling);

            pricecheck(totaling);
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

