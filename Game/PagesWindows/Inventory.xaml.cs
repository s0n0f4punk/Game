using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Game.Components;

namespace Game.PagesWindows
{
    /// <summary>
    /// Логика взаимодействия для Inventory.xaml
    /// </summary>
    public partial class Inventory : Window
    {
        public Inventory()
        {
            InitializeComponent();
            List<Weapon> guns = new List<Weapon>()
            {
                new Weapon("GammaGun", "Common"),
                new Weapon("GammaGun", "Rare"),
                new Weapon("GammaGun", "Legendary"),
                new Weapon("CrowAxe", "Common"),
                new Weapon("CrowAxe", "Rare"),
                new Weapon("CrowAxe", "Legendary"),
                new Weapon("Ripper", "Common"),
                new Weapon("Ripper", "Rare"),
                new Weapon("Ripper", "Legendary"),
                new Weapon("ShishKebab", "Common"),
                new Weapon("ShishKebab", "Rare"),
                new Weapon("ShishKebab", "Legendary"),
                new Weapon("SuperHammer", "Common"),
                new Weapon("SuperHammer", "Rare"),
                new Weapon("SuperHammer", "Legendary"),
                new Weapon("NukaShredder", "Common"),
                new Weapon("NukaShredder", "Rare"),
                new Weapon("NukaShredder", "Legendary"),
            };
            foreach (Weapon gun in guns)
            {
                WeaponsWP.Children.Add(new WeaponUC(gun));
            }
        }

        private void InvCns_PreviewMouseMove(object sender, MouseEventArgs e)
        {

        }

        private void InvCns_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
