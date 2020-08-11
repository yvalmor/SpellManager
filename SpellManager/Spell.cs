using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpellManager
{
    public class Spell
    {
        public string Name { get; set; }
        public String Element { get; set; }
        public string[] Classes { get; set; }
        public int Level { get; set; }
        public int Mana_cost { get; set; }
        public int Hp_cost { get; set; }
        public int Magical_dmg { get; set; }
        public int Physical_dmg { get; set; }

        public Spell(string name, string element, string[] classes, int level, int manaCost, int hpCost, int magicalDmg, int physicalDmg)
        {
            Name = name;
            Element = element;
            Classes = classes;
            Level = level;
            Mana_cost = manaCost;
            Hp_cost = hpCost;
            Magical_dmg = magicalDmg;
            Physical_dmg = physicalDmg;
        }

        public Spell(String name, JObject jObject)
        {
            Name = name;
            Element = jObject["Element"]?.ToString();

            Classes = jObject["Classes"]?.ToObject<string[]>();
            
            Level = (int) jObject["Level"];
            Mana_cost = (int) jObject["Mana_cost"];
            Hp_cost = (int) jObject["Hp_cost"];
            Magical_dmg = (int) jObject["Magical_dmg"];
            Physical_dmg = (int) jObject["Physical_dmg"];
        }

        public override string ToString() => Name;

        public JObject ToJson()
        {
            var jsonData = new
            {
                Element = this.Element,
                Classes = this.Classes,
                Level = this.Level,
                Mana_cost = this.Mana_cost,
                Hp_cost = this.Hp_cost,
                Magical_dmg = this.Magical_dmg,
                Physical_dmg = this.Physical_dmg
            };

            string data = JsonConvert.SerializeObject(jsonData);
            
            return JObject.Parse(data);
        }
        
    }
}