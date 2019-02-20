
//ITSE 1430
//Randon Hyman
//2/11/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PizzaCreator
{
    class Program
    {
        class PizzaCreator
        {
            private static void Main(string[] args)
            {
                bool PizzaUI;
                do
                {
                    PizzaUI = DisplayMenu();
                } while (PizzaUI);
            }

            private static int uiSize;
            private static bool Bacon;
            private static bool Ham;
            private static bool Pepperoni;
            private static bool Sausage;
            private static bool blackOlives;
            private static bool Mushrooms;
            private static bool Onions;
            private static bool Peppers;
            private static int uiSauce;
            private static int uiMeats;
            private static int uiVegetables;
            private static int uiCheese;
            private static int uiDelivery;
            private static bool orderSystem = false;

            private static void NewOrder()
            {
                Size();
                Meats();
                Vegetables();
                Sauce();
                Cheese();
                Delivery();
                DisplayOrder();
            }

            private static bool DisplayMenu()
            {
                while (true)
                {
                    Console.WriteLine("\t1. New Order");
                    Console.WriteLine("\t2. Modify Order");
                    Console.WriteLine("\t3. Display Order");
                    Console.WriteLine("\t4. Quit");

                    string input = Console.ReadLine();
                    switch (input[0])
                    {
                        case '1': NewOrder();
                            return true;

                        case '2': ModifyOrder();
                            return true;

                        case '3': DisplayOrder();
                            return true;

                        case '4':
                            return false;

                        default:
                            Console.WriteLine("Enter a valid value.");
                            break;
                    }
                }
            }

            private static void ModifyOrder()
            {
                if (!orderSystem)
                {
                    Console.WriteLine("There are no orders currently.");
                }
                else
                    Console.WriteLine("\tPlease select the valid options.\n");
                NewOrder();
            }


            private static void DisplayOrder()
            {
                if (!orderSystem)
                {
                    Console.WriteLine("There are no orders currently.");
                }
                else
                {
                    Console.WriteLine("------------------------------------------\n");
                    Console.WriteLine("\tYour Pizza Order Summary\n");
                    switch (uiSize)
                    {
                        case 1:
                            Console.WriteLine("\tSmall Pizza\t\t$5.00");
                            break;

                        case 2:
                            Console.WriteLine("\tMedium Pizza\t\t$6.25");
                            break;

                        case 3:
                            Console.WriteLine("\tLarge Pizza\t\t$8.25");
                            break;
                    }

                    switch (uiDelivery)
                    {
                        case 1:
                            Console.WriteLine("\tTake Out");
                            break;

                        case 2:
                            Console.WriteLine("\tDelivery\t\t$2.50");
                            break;
                    }

                    Console.WriteLine("\tMeats");

                    if (Bacon)
                        Console.WriteLine("\t\t Bacon\t\t$0.75");

                    if (Ham)
                        Console.WriteLine("\t\t Ham\t\t$0.75");

                    if (Pepperoni)
                        Console.WriteLine("\t\t Pepperoni\t$0.75");

                    if (Sausage)
                        Console.WriteLine("\t\t Sausage\t$0.75");

                    Console.WriteLine("\tVegetables");

                    if (blackOlives)
                        Console.WriteLine("\t\t BlackOlives\t$0.50");

                    if (Mushrooms)
                        Console.WriteLine("\t\t Mushrooms\t$0.50");

                    if (Onions)
                        Console.WriteLine("\t\t Onions\t\t$0.50");

                    if (Peppers)
                        Console.WriteLine("\t\t Peppers\t$0.50");

                    Console.WriteLine("\tSauce");

                    switch (uiSauce)
                    {
                        case 1:
                            Console.WriteLine("\t\t Traditional");
                            break;

                        case 2:
                            Console.WriteLine("\t\t Garlic\t\t$1.00");
                            break;

                        case 3:
                            Console.WriteLine("\t\t Oregano\t$1.00");
                            break;
                    }

                    Console.WriteLine("\tCheese");

                    switch (uiCheese)
                    {
                        case 1:
                            Console.WriteLine("\t\t Regular");
                            break;

                        case 2:
                            Console.WriteLine("\t\t Extra\t\t$1.25");
                            break;
                    }

                    Console.WriteLine("\tTotal\t\t\t$" + CalculateTotal());
                    Console.WriteLine("\n------------------------------------------\n");
                }
            }

            private static int ReadInt32(int minValue, int maxValue)
            {
                while (true)
                {

                    var input = Console.ReadLine();

                    if (int.TryParse(input, out var result))
                    {
                        if (result >= minValue && result <= maxValue)
                            return result;
                    };
                    Console.WriteLine($"You must enter a valid option between {minValue} and {maxValue}");
                };
            }

            private static void Size()
            {
                Console.WriteLine("\tPizza Size (Pick One).");
                Console.WriteLine("\t1. Small Pizza ($5.00) {0}", uiSize == 1 ? "Selected" : " ");
                Console.WriteLine("\t2. Medium Pizza ($6.25) {0}", uiSize == 2 ? "Selected" : " ");
                Console.WriteLine("\t3. Large Pizza ($8.25) {0}", uiSize == 3 ? "Selected" : " ");
                uiSize = ReadInt32(1, 3);
                orderSystem = true;
            }

            private static void Meats()
            {
                while (true)
                {
                    bool selectedBacon = false;
                    bool selectedHam = false;
                    bool selectedPepperoni = false;
                    bool selectedSausage = false;
                    Console.WriteLine("\tAdd Meats ($0.75 Each)");
                    Console.WriteLine("\t1. Bacon {0}", selectedBacon ? "Selected" : " ");
                    Console.WriteLine("\t2. Ham {0}", selectedHam ? "Selected" : " ");
                    Console.WriteLine("\t3. Pepperoni {0}", selectedPepperoni ? "Selected" : " ");
                    Console.WriteLine("\t4. Sausage {0}", selectedSausage ? "Selected" : " ");
                    Console.WriteLine("\t5. Done");
                    uiMeats = ReadInt32(1, 5);
                    switch (uiMeats)
                    {
                        case 1:
                            selectedBacon = true;
                            Bacon = !Bacon;
                            break;

                        case 2:
                            selectedHam = true;
                            Ham = !Ham;
                            break;

                        case 3:
                            selectedPepperoni = true;
                            Pepperoni = !Pepperoni;
                            break;

                        case 4:
                            selectedSausage = true;
                            Sausage = !Sausage;
                            break;

                        case 5:
                            return;
                    }
                }
            }

            private static void Vegetables()
            {
                while (true)
                {
                    bool selectedOlives = false;
                    bool selectedMushrooms = false;
                    bool selectedOnions = false;
                    bool selectedPeppers = false;
                    uiVegetables = ReadInt32(1, 5);
                    Console.WriteLine("\tAdd Vegetables ($0.50 Each)");
                    Console.WriteLine("\t1. Black olives {0}", selectedOlives == true ? "Selected" : " ");
                    Console.WriteLine("\t2. Mushrooms {0}", selectedMushrooms == true ? "Selected" : " ");
                    Console.WriteLine("\t3. Onions {0}", selectedOnions == true ? "Selected" : " ");
                    Console.WriteLine("\t4. Peppers {0}", selectedPeppers == true ? "Selected" : " ");
                    Console.WriteLine("\t5. Next");                    
                    switch (uiVegetables)
                    {
                        case 1:
                            selectedOlives = true;
                            blackOlives = !blackOlives;
                            break;

                        case 2:
                            selectedMushrooms = true;
                            Mushrooms = !Mushrooms;
                            break;

                        case 3:
                            selectedOnions = true;
                            Onions = !Onions;
                            break;

                        case 4:
                            selectedPeppers = true;
                            Peppers = !Peppers;
                            break;

                        case 5:
                            return;
                    }
                }
            }

            private static void Sauce()
            {
                Console.WriteLine("\tPizza Sauce (Pick One).");
                Console.WriteLine("\t1. Traditional ($0.00) {0}", uiSauce == 1 ? "Selected" : " ");
                Console.WriteLine("\t2. Garlic ($1.00) {0}", uiSauce == 2 ? "Selected" : " ");
                Console.WriteLine("\t3. Oregano ($1.00) {0}", uiSauce == 3 ? "Selected" : " ");

                uiSauce = ReadInt32(1, 3);
            }

            private static void Cheese()
            {
                Console.WriteLine("\tHow much Cheese? (Pick One). ");
                Console.WriteLine("\t1. Regular ($0.00) {0}", uiCheese == 1 ? "Selected" : " ");
                Console.WriteLine("\t2. Extra ($1.25) {0}", uiCheese == 2 ? "Selected" : " ");

                uiCheese = ReadInt32(1, 2);

            }

            private static void Delivery()
            {
                Console.WriteLine("\tDelivery (Pick One).");
                Console.WriteLine("\t1. Take Out ($0.00) {0}", uiDelivery == 1 ? "Selected" : " ");
                Console.WriteLine("\t2. Delivery ($2.50) {0}", uiDelivery == 2 ? "Selected" : " ");

                uiDelivery = ReadInt32(1, 2);
            }
       
            private static decimal CalculateTotal()
            {
                var vegetablePrice = 0.50m;
                var meatPrice = 0.75m;
                var totalPrice = 0m;
                switch (uiSize)
                {
                    case 1:
                        totalPrice += 5;
                        break;

                    case 2:
                        totalPrice += 6.25m;
                        break;

                    case 3:
                        totalPrice += 8.75m;
                        break;
                };

                if (Bacon)
                    totalPrice += meatPrice;
                if (Ham)
                    totalPrice += meatPrice;
                if (Pepperoni)
                    totalPrice += meatPrice;
                if (Sausage)
                    totalPrice += meatPrice;
                if (blackOlives)
                    totalPrice += vegetablePrice;
                if (Mushrooms)
                    totalPrice += vegetablePrice;
                if (Onions)
                    totalPrice += vegetablePrice;
                if (Peppers)
                    totalPrice += vegetablePrice;

                switch (uiSauce)
                {
                    case 1:
                        totalPrice += 0;
                        break;

                    case 2:
                        totalPrice += 1m;
                        break;

                    case 3:
                        totalPrice += 1m;
                        break;
                }

                switch (uiCheese)
                {
                    case 1:
                        totalPrice += 0;
                        break;

                    case 2:
                        totalPrice += 1.25m;
                        break;
                }

                switch (uiDelivery)
                {
                    case 1:
                        totalPrice += 0;
                        break;

                    case 2:
                        totalPrice += 2.50m;
                        break;
                }
                return totalPrice;
            }
        }
    }
}