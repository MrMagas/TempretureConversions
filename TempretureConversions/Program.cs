using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempretureConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";

            Console.WriteLine("Please choose from the menu below:");
            Console.WriteLine("A) Celsius to Farenheit");
            Console.WriteLine("B) Farenheit to Celsius");

            option = Console.ReadLine();
            option = option.ToUpper();
            option = option.Trim();

            double tempreture;

            Console.WriteLine("Please enter the tempreture you want to convert");
            tempreture = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case "A":
                    tempreture = (tempreture  * 1.8) + 32;
                    break;
                case "B":
                    tempreture = (tempreture - 32) / 1.8;
                    break;
                }


            Console.WriteLine(tempreture);
            Console.ReadLine();
        }
    }
}
