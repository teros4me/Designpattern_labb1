namespace Designpattern_labb1.Meat
{
    public class Lamb : IMeat
    {
        public string Type { get; set; }

        public bool IsOrganic { get; set; }

        public Lamb()
        {
            Type = "lammkött";
            IsOrganic = true;
        }
    }
}
