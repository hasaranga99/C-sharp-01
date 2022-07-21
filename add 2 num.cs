using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_2number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int num1;
             int num2;
             int ans;

             num1 = 32;
             num2 = 18;
             ans = num1+ num2;

             Console.WriteLine(num1+ "+" +num2 + "=" +ans);
             Console.ReadLine(); ($this is first work$) */

            Console.WriteLine("Enter the First number = ");
            String number1=Console.ReadLine();
            double num1=Convert.ToDouble(number1);

            Console.WriteLine("Enter the Second number = ");
            String number2=Console.ReadLine();
            double num2=Convert.ToDouble(number2);

            double Total = num1 + num2;
            Console.WriteLine("Total is = " + Total);

            double sub = num1 - num2;
            Console.WriteLine("subtraction is = " + sub);

            double multi = num1 * num2;
            Console.WriteLine("Multiplication is = " + multi);

            double div = num1 / num2;
            Console.WriteLine("Division  is = " + div);

            Console.ReadLine();
        }
    }
}
