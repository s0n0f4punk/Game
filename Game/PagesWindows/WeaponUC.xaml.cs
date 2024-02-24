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
            CorX.Text = _weapon.Cor.X.ToString();
            CorY.Text = _weapon.Cor.Y.ToString();
            Type.Text = _weapon.Type.ToString();
            Rarity.Text = _weapon.Rarity.ToString();
            TipType.Text = weapon.Type;
            TipAddStat.Text = weapon.AddStats;
            
            if (weapon.Rarity == "Common")
            {
                RadialGradientBrush br = new RadialGradientBrush();
                br.GradientStops.Add(new GradientStop(Color.FromArgb(70, 55, 255, 0), 1));
                br.GradientStops.Add(new GradientStop(Color.FromArgb(30, 178, 255, 127), 0.2));
                Grid.Background = br;
            }
            else if (weapon.Rarity == "Rare")
            {
                RadialGradientBrush br = new RadialGradientBrush();
                br.GradientStops.Add(new GradientStop(Color.FromArgb(75, 0, 132, 255), 1));
                br.GradientStops.Add(new GradientStop(Color.FromArgb(35, 116, 243, 253), 0.2));
                Grid.Background = br;
            }
            else if (weapon.Rarity == "Legendary")
            {
                RadialGradientBrush br = new RadialGradientBrush();
                br.GradientStops.Add(new GradientStop(Color.FromArgb(100, 247, 51, 2), 1));
                br.GradientStops.Add(new GradientStop(Color.FromArgb(100, 247, 88, 2), 0.2));
                Grid.Background = br;
            }

            switch (weapon.Type) 
            {
                case "GammaGun":
                    {
                        Uri uri = new Uri("pack://application:,,,/Resources/Gamma gun.png");
                        Image.Source = new BitmapImage(new Uri(uri.ToString()));
                        Image.Width = 120;
                        Image.Stretch = Stretch.Uniform;
                        TipStat.Text = "Ф.УР:1; ОБЛ:10; ИН:10; КР.Ш:5; КР.УР:300";
                        return;
                    }
                case "CrowAxe":
                    {
                        Uri uri = new Uri("pack://application:,,,/Resources/Crow-Axe.png");
                        Image.Source = new BitmapImage(new Uri(uri.ToString()));
                        Image.Width = 110;
                        Image.Stretch = Stretch.Uniform;
                        TipStat.Text = "Ф.УР:5; ЛВ:10; КР.Ш:60; КР.УР:70";
                        return;
                    }
                case "Ripper":
                    {
                        Uri uri = new Uri("pack://application:,,,/Resources/Ripper.png");
                        Image.Source = new BitmapImage(new Uri(uri.ToString()));
                        Image.Width = 115;
                        Image.Stretch = Stretch.Uniform;
                        TipStat.Text = "Ф.УР:10; ЛВ:5; СЛ:5; КР.Ш:35; КР.УР:150";
                        return;
                    }
                case "ShishKebab":
                    {
                        Uri uri = new Uri("pack://application:,,,/Resources/Shish-Kebab.png");
                        Image.Source = new BitmapImage(new Uri(uri.ToString()));
                        Image.Width = 128;
                        Image.Stretch = Stretch.Uniform;
                        TipStat.Text = "Ф.УР:15; СЛ:15; КР.Ш:20; КР.УР:170";
                        return;
                    }
                case "SuperHammer":
                    {
                        Uri uri = new Uri("pack://application:,,,/Resources/Super-Hammer.png");
                        Image.Source = new BitmapImage(new Uri(uri.ToString()));
                        Image.Width = 120;
                        Image.Stretch = Stretch.Uniform;
                        TipStat.Text = "Ф.УР:15; СЛ:10; ЗД:10; КР.Ш:10; КР.УР:250";
                        return;
                    }
                case "NukaShredder":
                    {
                        Uri uri = new Uri("pack://application:,,,/Resources/Nuka-Shredder.png");
                        Image.Source = new BitmapImage(new Uri(uri.ToString()));
                        Image.Width = 120;
                        Image.Stretch = Stretch.UniformToFill;
                        TipStat.Text = "Все хар-ки + 70%; КР.Ш и КР.УР = 0";
                        return;
                    }
            }
        }
    }
}
