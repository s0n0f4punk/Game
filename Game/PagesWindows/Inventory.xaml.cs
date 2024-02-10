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
            Ellipse userCTRL = new Ellipse();
            userCTRL.Fill = Brushes.Azure;
            userCTRL.Width = 100;
            userCTRL.Height = 100;
            Canvas.SetTop(userCTRL, 20);
            Canvas.SetLeft(userCTRL, 20);
            userCTRL.PreviewMouseDown += Weapon_PreviewMouseDown;
            InvCns.Children.Add(userCTRL);

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
        UIElement dragObject = null;
        Point offset;
        WeaponUC newCtrl;
        newCtrl = Activator.CreateInstance()

        private void Weapon_PreviewMouseDown(object sender, MouseEventArgs e)
        {
            this.dragObject = sender as UIElement;
            this.offset = e.GetPosition(this.InvCns);
            this.offset.Y -= Canvas.GetTop(this.dragObject);
            this.offset.X -= Canvas.GetLeft(this.dragObject);
            this.InvCns.CaptureMouse();
        }

        private void InvCns_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragObject == null) return;
            var position = e.GetPosition(sender as IInputElement);
            Canvas.SetTop(this.dragObject, position.Y - this.offset.Y);
            Canvas.SetLeft(this.dragObject, position.X - this.offset.X);
        }

        private void InvCns_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            this.dragObject = null;
            this.InvCns.ReleaseMouseCapture();
        }
    }
}
