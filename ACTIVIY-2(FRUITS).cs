using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grocery
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCost = 0.0; string otherItem;
            do
            { 
                 
                Console.WriteLine("Enter Item Name: ");
            string itemName = Console.ReadLine(); 
                 
                Console.WriteLine("Enter Item Quantity: "); 
            double quantity = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter Item Price: "); 
            double price = double.Parse(Console.ReadLine()); 
                 
                double ItemtotalCost = quantity * price; totalCost += ItemtotalCost; 
                Console.WriteLine("Do you want to enter other item? (yes/no)");
                otherItem = Console.ReadLine().Trim().ToLower(); } while (otherItem == "yes"); 
            double discount= calculateDiscount(totalCost); double finalAmount = totalCost - discount; 

            //DISPLAY
            Console.WriteLine("total cost before the discount: "+totalCost.ToString("F2")); 
            Console.WriteLine("discount applied:"+discount.ToString("F2")); 
            Console.WriteLine("final amount to be paid:"+finalAmount.ToString("F2"));
            Console.ReadKey();
        }
        static double calculateDiscount(double totalCost)
        {
            if (totalCost > 500)
            {
                return totalCost * 0.20;
            }
            else if (totalCost > 200)
            {
                return totalCost * 0.15;
            }
            else if (totalCost > 100)
            {
                return totalCost * 0.10;
            }
            else
            {
                return 0.00;
            }
        }
    }
}
