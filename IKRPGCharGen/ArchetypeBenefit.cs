namespace IKRPGCharGen
{
    public class ArchetypeBenefit
    {
        public string name { get; set; }
        public string effect { get; set; }

        ArchetypeBenefit(string name,string effect)
        {
            this.effect = effect;
            this.name = name;
        }
    }
}