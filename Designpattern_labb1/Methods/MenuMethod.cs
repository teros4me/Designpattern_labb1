using Designpattern_labb1.Quantities;
using Designpattern_labb1.Singleton;
using System;

namespace Designpattern_labb1.Methods
{
    public class MenuMethod
    {
        public static void Menu()
        {
            // Factory Method används för att välja kött.

            Console.WriteLine("Välj vilket kött du vill beställa:\n" +
                "1 - nötkött\n" +
                "2 - griskött\n" +
                "3 - lammkött\n" +
                "4 - renkött\n" +
                "5 - älgkött");
            string meatChoice = Console.ReadLine();

            var meatFactory = new MeatFactory();
            var meat = meatFactory.CreateMeat(meatChoice);


            Console.WriteLine("Välj hur mycket du vill ha:\n" +
                "1 - En hel\n" +
                "2 - En halv\n" +
                "3 - En kvart");
            string quantityChoice = Console.ReadLine();

            Console.Clear();

            // Strategy pattern används för att bestämma storlek.

            var quantity = new QuantityContext(null);

            if (quantityChoice == "1")
            {
                quantity.SetQuantity(new Whole());
                quantity.GetQuantity("En hel bit ");
            }
            else if (quantityChoice == "2")
            {
                quantity.SetQuantity(new Half());
                quantity.GetQuantity("En halv bit ");
            }
            else if (quantityChoice == "3")
            {
                quantity.SetQuantity(new Quarter());
                quantity.GetQuantity("En kvarts bit ");
            }
            else
            {
                //ErrorLog med Singleton pattern
                ErrorLog errorLog = ErrorLog.Instance;
                errorLog.ErrorMsg();
                Menu();
            }
            Console.WriteLine(meat.Type + " är beställd.");
            Console.ReadLine();
        }
    }
}
