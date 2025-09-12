// HW1a Sales Total

// Your Name: Christy Johnson
// Did you seek help ? If yes, specify the helper or web link here: no i used the sumof3 code and slides.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    { 
        static void Main(string[] args)
        {

            String num1;
            int num2;
            double num3;

         

            const double multiplier = 0.085;

   
            
            Console.WriteLine("What is the product of the item you are purchasing? ");
            string num1AsString = Console.ReadLine();

            Console.WriteLine("How many Football Ticket's do you want to buy? ");
            int num2AsString = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What is the price for each Football Ticket? ");
            double num3AsString = Convert.ToDouble(Console.ReadLine());

            num1 = num1AsString;
            num2 = num2AsString;
            num3 = num3AsString;

            double subtotal = num2 * num3;

            Console.WriteLine("Your subtotal for your bill is " + subtotal);

            double salesTax = subtotal * multiplier;

            Console.WriteLine("Your sales tax for your bill is " + salesTax);

            double total = subtotal + salesTax;

            Console.WriteLine("Your total for your bill is " + total);

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();

        }
    }
}
