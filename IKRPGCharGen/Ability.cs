namespace IKRPGCharGen
{
    internal class Ability
    {
        public string name { get; set; }
        public int value { get; set; }
        public string effect { get; set; }

        public Ability(string name,int value,string effect)
        {
            this.name = name;
            this.value = value;
            this.effect = effect;
        }
    }
}