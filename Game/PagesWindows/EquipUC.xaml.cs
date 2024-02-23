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
    /// Логика взаимодействия для EquipUC.xaml
    /// </summary>
    public partial class EquipUC : UserControl
    {
        Equip equip;
        public EquipUC(Equip _equip)
        {
            InitializeComponent();
            equip = _equip;
            CorX.Text = _equip.Cor.X.ToString();
            CorY.Text = _equip.Cor.Y.ToString();
            Type.Text = _equip.Type.ToString();
            Rarity.Text = _equip.Rarity.ToString();
            TipType.Text = equip.Type;
            TipAddStat.Text = equip.AddStats;

            if (equip.Rarity == "Common")
            {
                RadialGradientBrush br = new RadialGradientBrush();
                br.GradientStops.Add(new GradientStop(Color.FromArgb(70, 55, 255, 0), 1));
                br.GradientStops.Add(new GradientStop(Color.FromArgb(30, 178, 255, 127), 0.2));
                Grid.Background = br;
                TipAddStat.Text = " - ";
            }
            else if (equip.Rarity == "Rare")
            {
                RadialGradientBrush br = new RadialGradientBrush();
                br.GradientStops.Add(new GradientStop(Color.FromArgb(75, 0, 132, 255), 1));
                br.GradientStops.Add(new GradientStop(Color.FromArgb(35, 116, 243, 253), 0.2));
                Grid.Background = br;
            }
            else if (equip.Rarity == "Legendary")
            {
                RadialGradientBrush br = new RadialGradientBrush();
                br.GradientStops.Add(new GradientStop(Color.FromArgb(100, 247, 51, 2), 1));
                br.GradientStops.Add(new GradientStop(Color.FromArgb(100, 247, 88, 2), 0.2));
                Grid.Background = br;
            }
        }
    }
}
