using System;

namespace Designpattern_labb1.Singleton
{
    //ErrorLog med Singleton pattern

    public class ErrorLog
    {
        private static ErrorLog instance = null;

        private ErrorLog() { }

        public static ErrorLog Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ErrorLog();
                }
                return instance; }
        }
           
        public void ErrorMsg()
        {
            Console.WriteLine("Fel inmatning, försök igen.");
        }
    }
}