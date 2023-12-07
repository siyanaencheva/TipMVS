using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipMVS.View
{
    internal class Display
    {
        public double Amount { get; set; }//ide ot input
        public double Percent { get; set; }//tva sush e ot tam
        public double Tip { get; set; }//tva kum output
        public double Total { get; set; }//i tva na tam
        public void Input() 
        {
            Console.Write("Enter the amount of the meal: ");
            Amount=double.Parse(Console.ReadLine());
            Console.Write("Enter tip percent: ");
            Percent=double.Parse(Console.ReadLine());
        }

        public void Output() 
        {
            Console.WriteLine($"Your tip is: {Tip:C}");
            Console.WriteLine("The total will be: {0:C}",Total);
        }
    }
}
