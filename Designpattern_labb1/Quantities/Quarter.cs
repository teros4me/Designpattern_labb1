using System;

namespace Designpattern_labb1
{
    public class Quarter : IQuantity
    {
        public void Amount(string size)
        {
            Console.Write(size);
        }
    }
}
