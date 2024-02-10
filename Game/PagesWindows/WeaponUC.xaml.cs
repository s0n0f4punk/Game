using Game.Components;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game.PagesWindows
{
    /// <summary>
    /// Логика взаимодействия для WeaponUC.xaml
    /// </summary>
    public partial class WeaponUC : UserControl
    {
        public Weapon weapon;
        public WeaponUC(Weapon _weapon)
        {
            InitializeComponent();
            weapon = _weapon;
            GunType.Text = _weapon.Type;
            CorX.Text = _weapon.Cor.X.ToString();
            CorY.Text = _weapon.Cor.Y.ToString();
            if (weapon.Rarity == "Common")
            {
                RadialGradientBrush br = new RadialGradientBrush();
                br.GradientStops.Add(new GradientStop(Color.FromArgb(50, 55, 255, 0), 1));
                br.GradientStops.Add(new GradientStop(Color.FromArgb(20, 178, 255, 127), 0));
                Grid.Background = br;
            }
            else if (weapon.Rarity == "Rare")
            {
                RadialGradientBrush br = new RadialGradientBrush();
                br.GradientStops.Add(new GradientStop(Color.FromArgb(60, 0, 132, 255), 1));
                br.GradientStops.Add(new GradientStop(Color.FromArgb(35, 116, 243, 253), 0));
                Grid.Background = br;
            }
            else
            {
                RadialGradientBrush br = new RadialGradientBrush();
                br.GradientStops.Add(new GradientStop(Color.FromArgb(69, 255, 82, 0), 1));
                br.GradientStops.Add(new GradientStop(Color.FromArgb(50, 251, 196, 76), 0));
                Grid.Background = br;
            }
            switch (weapon.Type) 
            {
                case "GammaGun":
                    {
                        Image.Source = new BitmapImage(new Uri("C:\\Users\\212115\\Source\\Repos\\Game\\Game\\Resources\\Gamma gun.png"));
                        return;
                    }
                case "CrowAxe":
                    {
                        Image.Source = new BitmapImage(new Uri("C:\\Users\\212115\\Source\\Repos\\Game\\Game\\Resources\\Crow-Axe.png"));
                        return;
                    }
                case "Ripper":
                    {
                        Image.Source = new BitmapImage(new Uri("C:\\Users\\212115\\Source\\Repos\\Game\\Game\\Resources\\Ripper.png"));
                        return;
                    }
                case "ShishKebab":
                    {
                        Image.Source = new BitmapImage(new Uri("C:\\Users\\212115\\Source\\Repos\\Game\\Game\\Resources\\Shish-Kebab.png"));
                        return;
                    }
                case "SuperHammer":
                    {
                        Image.Source = new BitmapImage(new Uri("C:\\Users\\212115\\Source\\Repos\\Game\\Game\\Resources\\Super-Hammer.png"));
                        return;
                    }
                //case "NukaShredder":
                //    {
                //        Image.Source = new BitmapImage(new Uri("C:\\Users\\212115\\Source\\Repos\\Game\\Game\\Resources\\Nuka-Shredder.png"));
                //        return;
                //    }
            }
        }
    }
}
