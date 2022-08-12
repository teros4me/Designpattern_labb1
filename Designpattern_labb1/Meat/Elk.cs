namespace Designpattern_labb1.Meat
{
    public class Elk : IMeat
    {
        public string Type { get; set; }

        public bool IsOrganic { get; set; }

        public Elk()
        {
            Type = "älgkött";
            IsOrganic = true;
        }
    }
}
