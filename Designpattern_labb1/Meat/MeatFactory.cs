using Designpattern_labb1.Meat;
using Designpattern_labb1.Methods;
using Designpattern_labb1.Singleton;
using System;

namespace Designpattern_labb1
{
    public class MeatFactory
    {
        // Factory Method används för att välja kött.

        public IMeat CreateMeat(string choice)
        {
            IMeat meat = null;

            if (choice == "1")
            {
                meat = new Beef();
            }
            else if (choice == "2")
            {
                meat = new Pork();
            }
            else if (choice == "3")
            {
                meat = new Lamb();
            }
            else if (choice == "4")
            {
                meat = new Reindeer();
            }
            else if (choice == "5")
            {
                meat = new Elk();
            }
            else
            {
                Console.Clear();

                //ErrorLog med Singleton pattern

                ErrorLog errorLog = ErrorLog.Instance;
                errorLog.ErrorMsg();

                MenuMethod.Menu();
            }
            return meat;
        }
    }
}
