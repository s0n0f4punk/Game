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
        }
    }
}
