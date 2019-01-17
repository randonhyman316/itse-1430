/*
 *  Multi line comment 
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
        // Single line comment
        static void Main( string[] args)
        {
            string name;
            int hours = 8;
            double payRate = 8.25;
            int length = 10, width =12;
            char ch = 'X';
            bool result = true; //false
            //int counter;
            //nEVER INT A, B;

            Console.WriteLine(hours);
            //name = "Sue";
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            //string message = "Hello " + name;
            string message = "Hello ";
            message += name;

        }
    }
}
