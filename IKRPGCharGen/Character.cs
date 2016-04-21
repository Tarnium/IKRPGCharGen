using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKRPGCharGen
{
    class Character
    {
        public string name { get; set; }
        public List<Stat> stats { get; set; }
        public List<Ability> abilities { get; set; }
        public List<ArchetypeBenefit> archb { get; set; }
        public List<Spell> spells { get; set; }
        public List<InvItem> inventory { get; set; }
        public Race race { get; set; }
        public Archetype arch { get; set; }
        public List<Career> careers { get; set; }

        Character()
        {
            name = "Unnamed";
            stats = new List<Stat>();
            abilities = new List<Ability>();
            archb = new List<ArchetypeBenefit>();
            spells = new List<Spell>();
            inventory = new List<InvItem>();
            race = null;
            arch = null;
            careers = new List<Career>();
        }

        public void SetRace(string race)
        {
            this.race = new Race(race);
        }


    }
}
