namespace Designpattern_labb1.Meat
{
    public class Beef : IMeat
    {
        public string Type { get; set; }

        public bool IsOrganic { get; set; }

        public Beef()
        {
            Type = "nötkött";
            IsOrganic = false;
        }
    }
}
