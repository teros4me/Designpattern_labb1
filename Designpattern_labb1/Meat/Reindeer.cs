namespace Designpattern_labb1.Meat
{
    public class Reindeer : IMeat
    {
        public string Type { get; set; }

        public bool IsOrganic { get; set; }

        public Reindeer()
        {
            Type = "renkött";
            IsOrganic = true;
        }
    }
}
