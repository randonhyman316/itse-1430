using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        class Program
        {
            private static bool isOrderInProgress = false;
            private static decimal total = 0;
            private static string selectedItemUi = "[X]";
            private static string unselectedItemUi = "[ ]";

            private static bool baconOption = false;
            private static bool hamOption = false;
            private static bool pepperoniOption = false;
            private static bool sausageOption = false;

            private static string pizzaChoice;
            private static string sauceChoice;
            private static string deliveryChoice;
            private static string cheeseChoice;

            private static bool oliveOption = false;
            private static bool mushroomsOption = false;
            private static bool onionsOption = false;
            private static bool peppersOption = false;

            private static decimal pricePerMeat = .75M;
            private static decimal pricePerVeggie = .50M;

            static void Main( string[] args )
            {
                MenuChoice();
            }

            // Order Topics
            private static void StartOrder()
            {
                isOrderInProgress = true;
                PizzaSize();
                Meats();
                Vegetables();
                Sauce();
                Cheese();
                Delivery();

                total += CalculateTotal();
                DisplayOrder();
            }

            // Creates the order
            private static void NewOrder()
            {
                if (isOrderInProgress)
                {
                    Console.WriteLine("Order in Progress \n Start Over? (Y/N)");
                    string result = Console.ReadLine().ToUpper();
                    if (result == "Y")
                    {
                        ResetOrder();
                    }
                }

                if (!isOrderInProgress)
                {
                    StartOrder();
                }
            }

            // 1st switch statement 
            private static void MenuChoice()
            {
                bool userQuit = false;

                while (!userQuit)
                {
                    DisplayMenu();
                    var menuChoice = Console.ReadLine();
                    switch (menuChoice)
                    {
                        case "1":
                        NewOrder();
                        break;
                        case "2":
                        ModifyOrder();
                        break;
                        case "3":
                        DisplayOrder();
                        break;
                        case "4":
                        userQuit = true;
                        break;

                        default:
                            {
                                Console.WriteLine("Invalid Entry");
                                break;
                            }
                    }
                }
            }

            private static void ResetOrder()
            {
                isOrderInProgress = false;
                baconOption = false;
                hamOption = false;
                pepperoniOption = false;
                sausageOption = false;
                pizzaChoice = "";
                sauceChoice = "";
                deliveryChoice = "";
                cheeseChoice = "";
                oliveOption = false;
                mushroomsOption = false;
                onionsOption = false;
                peppersOption = false;
            }

            // Pizza size switch statement
            private static void PizzaSize()
            {
                bool selectedOne = false;
                while (!selectedOne)
                {
                    Console.WriteLine("What size of pizza do you want?\n");
                    MenuSelection("S = Small", pizzaChoice == "S");
                    MenuSelection("M = Medium", pizzaChoice == "M");
                    MenuSelection("L = Large", pizzaChoice == "L");
                    string result = Console.ReadLine().ToUpper();

                    switch (result)
                    {
                        case "S":
                        pizzaChoice = "S";
                        selectedOne = true;
                        break;
                        case "M":
                        pizzaChoice = "M";
                        selectedOne = true;
                        break;
                        case "L":
                        pizzaChoice = "L";
                        selectedOne = true;
                        break;
                        default:
                        Console.WriteLine("Please pick S,M, or L.");
                        break;
                    }
                }
            }

            // Pizza meats switch statement
            private static void Meats()
            {
                bool meatDone = false;

                while (!meatDone)
                {
                    Console.WriteLine("What kinda of Meats? $" + pricePerMeat + " Please pick one. \n");
                    MenuSelection("B = Bacon", baconOption);
                    MenuSelection("H = Ham", hamOption);
                    MenuSelection("P = Pepperoni", pepperoniOption);
                    MenuSelection("S = Sausage", sausageOption);
                    Console.WriteLine("D = Done");
                    string result = Console.ReadLine().ToUpper();
                    switch (result)
                    {
                        case "B":
                        baconOption = !baconOption;
                        break;
                        case "H":
                        hamOption = !hamOption;
                        break;
                        case "P":
                        pepperoniOption = !pepperoniOption;
                        break;
                        case "S":
                        sausageOption = !sausageOption;
                        break;
                        case "D":
                        meatDone = true;
                        break;
                        default:
                        Console.WriteLine("Please pick from menu");
                        break;
                    }
                }
            }

            // Pizza vegetables switch statement
            private static void Vegetables()
            {
                bool veggieDone = false;

                while (!veggieDone)
                {
                    Console.WriteLine("Which Vegetables do you want? $" + pricePerVeggie + " Pick one \n");
                    MenuSelection("B = Black Olives", oliveOption);
                    MenuSelection("M = Mushrooms", mushroomsOption);
                    MenuSelection("O = Onions", onionsOption);
                    MenuSelection("P = Peppers", peppersOption);
                    Console.WriteLine("D = Done");
                    string result = Console.ReadLine().ToUpper();
                    switch (result)
                    {
                        case "B":
                        oliveOption = !oliveOption;
                        break;
                        case "M":
                        mushroomsOption = !mushroomsOption;
                        break;
                        case "O":
                        onionsOption = !onionsOption;
                        break;
                        case "P":
                        peppersOption = !peppersOption;
                        break;
                        case "D":
                        veggieDone = true;
                        break;
                        default:
                        Console.WriteLine("Please pick from menu");
                        break;
                    }
                }
            }

            // Pizza sauce switch statement
            private static void Sauce()
            {

                bool selectedOne = false;
                while (!selectedOne)
                {

                    Console.WriteLine("What kind of sauce do you want?\n");
                    MenuSelection("T = Traditional", sauceChoice == "T");
                    MenuSelection("G = Garlic", sauceChoice == "G");
                    MenuSelection("O = Oregano", sauceChoice == "O");
                    string sauceResult = Console.ReadLine().ToUpper();

                    switch (sauceResult)
                    {
                        case "T":
                        sauceChoice = "T";
                        selectedOne = true;
                        break;
                        case "G":
                        sauceChoice = "G";
                        selectedOne = true;
                        break;
                        case "O":
                        sauceChoice = "O";
                        selectedOne = true;
                        break;
                        default:
                        Console.WriteLine("Please pick from menu");
                        break;
                    }
                }
            }

            // Pizza cheese switch statement
            private static void Cheese()
            {
                bool selectedOne = false;
                while (!selectedOne)
                {
                    Console.WriteLine("What kind of cheese do you want?\n");
                    MenuSelection("R = Regular", cheeseChoice == "R");
                    MenuSelection("E = Extra", cheeseChoice == "E");
                    string result = Console.ReadLine().ToUpper();
                    switch (result)
                    {
                        case "R":
                        selectedOne = true;
                        cheeseChoice = "R";
                        break;
                        case "E":
                        selectedOne = true;
                        cheeseChoice = "E";
                        break;
                        default:
                        Console.WriteLine("Please pick from menu");
                        break;
                    }
                }
            }

            // Pizza delivery switch statement
            private static void Delivery()
            {
                bool selectedOne = false;
                while (!selectedOne)
                {
                    Console.WriteLine("Do you want take out or delivery?\n");
                    MenuSelection("T = Take Out", deliveryChoice == "T");
                    MenuSelection("D = Delivery", deliveryChoice == "D");
                    string result = Console.ReadLine().ToUpper();
                    switch (result)
                    {
                        case "T":
                        deliveryChoice = "T";
                        selectedOne = true;
                        break;
                        case "D":
                        deliveryChoice = "D";
                        selectedOne = true;
                        break;
                        default:
                        Console.WriteLine("Please pick from menu");
                        break;
                    }
                }
            }

            // Allows to edit past orders made
            private static void ModifyOrder()
            {
                if (isOrderInProgress)
                {
                    StartOrder();

                } else
                {
                    Console.WriteLine("Order hasn't been process? Please try again");
                }
            }

            //Shows the orders made 
            private static void DisplayOrder()
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\tCurrent Order");
                switch (pizzaChoice)
                {
                    case "S":
                    Console.WriteLine("Small Pizza \t\t\t$" + CalculateSizeOfPizzaTotal());
                    break;
                    case "M":
                    Console.WriteLine("Medium Pizza \t\t\t$" + CalculateSizeOfPizzaTotal());
                    break;
                    case "L":
                    Console.WriteLine("Large Pizza \t\t\t$" + CalculateSizeOfPizzaTotal());
                    break;
                }
                switch (deliveryChoice)
                {
                    case "T":
                    Console.WriteLine("Take Out ");
                    break;
                    case "D":
                    Console.WriteLine("Delivery \t\t\t$" + CalculateDeliveryTotal());
                    break;
                }
                Console.WriteLine("Meats");

                if (baconOption)
                {
                    Console.WriteLine("\t Bacon\t\t\t$" + pricePerMeat);
                }
                if (hamOption)
                {
                    Console.WriteLine("\t Ham\t\t\t$" + pricePerMeat);
                }
                if (pepperoniOption)
                {
                    Console.WriteLine("\t Pepperoni\t\t$" + pricePerMeat);
                }
                if (sausageOption)
                {
                    Console.WriteLine("\t Sausage\t\t$" + pricePerMeat);
                }

                Console.WriteLine("Vegetables");

                if (oliveOption)
                {
                    Console.WriteLine("\t Black Olives\t\t$" + pricePerVeggie);
                }
                if (mushroomsOption)
                {
                    Console.WriteLine("\t Mushrooms\t\t$" + pricePerVeggie);
                }
                if (onionsOption)
                {
                    Console.WriteLine("\t Onions\t\t\t$" + pricePerVeggie);
                }
                if (peppersOption)
                {
                    Console.WriteLine("\t Peppers\t\t$" + pricePerVeggie);
                }

                switch (cheeseChoice)
                {
                    case "R":
                    Console.WriteLine("Regular Cheese \t\t\t");
                    break;
                    case "E":
                    Console.WriteLine("Extra Cheese \t\t\t$" + CalculateCheeseTotal());
                    break;
                }
                Console.WriteLine("Sauce");

                switch (sauceChoice)
                {
                    case "T":
                    Console.WriteLine("\t Traditional \t\t$" + CalculateSauceTotal());
                    break;
                    case "G":
                    Console.WriteLine("\t Garlic \t\t$" + CalculateSauceTotal());
                    break;
                    case "O":
                    Console.WriteLine("\t Oregano \t\t$" + CalculateSauceTotal());
                    break;
                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Total \t\t\t\t$" + total);
                Console.WriteLine("\n\n");
            }

            // Show which selection the user has made
            private static void MenuSelection( string displayLabel, bool hasOption )
            {
                Console.WriteLine(displayLabel + (hasOption ? selectedItemUi : unselectedItemUi));
            }

            // List pizza main menu
            private static void DisplayMenu()
            {
                Console.WriteLine("Pizza Creator");
                string cartString = String.Format(" -----------------------------\t |CART:{0:c}|", total);
                Console.WriteLine(cartString);
                Console.WriteLine("1.New Order");
                Console.WriteLine("2.Modify Order");
                Console.WriteLine("3.Display Order");
                Console.WriteLine("4.Quit");
            }

            // Calculate all topping and selections made throughtout the process
            private static decimal CalculateTotal()
            {
                decimal pizzaTotal = 0;
                pizzaTotal += CalculateSizeOfPizzaTotal();
                pizzaTotal += CalculateMeatTotal();
                pizzaTotal += CalculateVeggiesTotal();
                pizzaTotal += CalculateSauceTotal();
                pizzaTotal += CalculateCheeseTotal();
                pizzaTotal += CalculateDeliveryTotal();

                return pizzaTotal;
            }

            //Calculate price for each pizza size
            private static decimal CalculateSizeOfPizzaTotal()
            {
                switch (pizzaChoice)
                {
                    case "S":
                    return 5.00M;
                    case "M":
                    return 6.25M;
                    case "L":
                    return 8.75M;
                    default:
                    return 0;
                }
            }

            //Calculate price for each pizza meat selection
            private static decimal CalculateMeatTotal()
            {
                decimal total = 0;
                total += baconOption ? pricePerMeat : 0;
                total += hamOption ? pricePerMeat : 0;
                total += pepperoniOption ? pricePerMeat : 0;
                total += sausageOption ? pricePerMeat : 0;

                return total;
            }

            private static decimal CalculateVeggiesTotal()
            {
                decimal totalVeggies = 0;
                totalVeggies += oliveOption ? pricePerVeggie : 0;
                totalVeggies += mushroomsOption ? pricePerVeggie : 0;
                totalVeggies += onionsOption ? pricePerVeggie : 0;
                totalVeggies += peppersOption ? pricePerVeggie : 0;
                return totalVeggies;
            }
            // price switch for cheese
            private static decimal CalculateCheeseTotal()
            {
                switch (cheeseChoice)
                {
                    case "R":
                    return 0;
                    case "E":
                    return 1.25M;
                    default:
                    return 0;
                }
            }

            // price switch for sauce
            private static decimal CalculateSauceTotal()
            {
                switch (sauceChoice)
                {
                    case "T":
                    return 0;
                    case "G":
                    return 1;
                    case "O":
                    return 1;
                    default:
                    return 0;
                }
            }

            // price switch for delivery
            private static decimal CalculateDeliveryTotal()
            {
                switch (deliveryChoice)
                {
                    case "T":
                    return 0;
                    case "D":
                    return 2.50M;
                    default:
                    return 0;
                }
            }
        }
    }

}

