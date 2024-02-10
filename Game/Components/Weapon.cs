using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game.Components
{
    public class Weapon
    {
        public string Type { get; set; }
        public string Rarity { get; set; }
        public Point Cor { get; set; }
        public Weapon(string type, string rarity, Point cor) 
        {
            Type = type;
            Rarity = rarity;
            Cor = cor;
        }
    }
}
