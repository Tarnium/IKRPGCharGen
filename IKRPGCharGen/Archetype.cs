using System;

namespace IKRPGCharGen
{
    public class Archetype
    {
        public string name { get; set; }
        public string effect { get; set; }

        Archetype(string name,string effect)
        {
            this.name = name;
            this.effect = effect;
        }

        Archetype(string name)
        {
            this.name = name;
            this.effect = getEffect(name);
        }

        private string getEffect(string name)
        {
            if (name == "Mighty") return "You gain an additional die on melee damage rolls.";
            else if (name == "Skilled") return "You can make additional attack each turn.";
            else if (name == "Intellectual") return "Characters following your orders gain +1 to attack and damage rolls";
            else if (name == "Gifted") return "You are able to cast magic and take magic-oriented careers";
            return "Not such archetype: " + name; 
        }
    }
}