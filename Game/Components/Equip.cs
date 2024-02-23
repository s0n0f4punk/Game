using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Components
{
    public class Equip
    {
        public string Type { get; set; }
        public string Rarity { get; set; }
        public Point Cor { get; set; }
        public string AddStats { get; set; }
        public Equip(string type, string rarity, Point cor, string addStats)
        {
            Type = type;
            Rarity = rarity;
            Cor = cor;
            AddStats = addStats;
        }
    }
}
