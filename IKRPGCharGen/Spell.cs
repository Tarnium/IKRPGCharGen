namespace IKRPGCharGen
{
    public class Spell
    {
        public string name { get; set; }
        public string effect { get; set; }
        public int cost { get; set; }

        Spell(string name,string effect,int cost)
        {
            this.name = name;
            this.effect = effect;
            this.cost = cost;
        }
    }
}