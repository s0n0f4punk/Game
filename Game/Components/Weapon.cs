using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Components
{
    public class Weapon
    {
        public string Type { get; set; }
        public string Rarity { get; set; }
        public Weapon(string type, string rarity) 
        {
            Type = type;
            Rarity = rarity;
        }
    }
}
