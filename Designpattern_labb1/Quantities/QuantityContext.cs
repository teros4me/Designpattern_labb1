namespace Designpattern_labb1.Quantities
{
    // Strategy Pattern

    class QuantityContext
    {
        private IQuantity _quantity;

        public QuantityContext(IQuantity quantity)
        {
            _quantity = quantity;
        }

        public void SetQuantity(IQuantity quantity)
        {
            _quantity = quantity;
        }

        public void GetQuantity(string size)
        {
            _quantity.Amount(size);
        }
    }
}
