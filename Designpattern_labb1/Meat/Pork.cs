namespace Designpattern_labb1.Meat
{
    public class Pork : IMeat
    {
        public string Type { get; set; }

        public bool IsOrganic { get; set; }

        public Pork()
        {
            Type = "griskött";
            IsOrganic = false;
        }
    }
}
