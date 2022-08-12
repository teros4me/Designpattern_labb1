using System;

namespace Designpattern_labb1
{
    public class Half : IQuantity
    {
        public void Amount(string size)
        {
            Console.Write(size);
        }
    }
}
