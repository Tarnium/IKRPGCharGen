using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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

        public Character()
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

        public void Serialize(string filename)
        {
            XmlSerializer xml = new XmlSerializer(this.GetType());
            TextWriter writer = new StreamWriter(filename);
            xml.Serialize(writer, this);
            writer.Close();

        }


    }
}
