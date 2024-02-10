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
                new Weapon("GammaGun", "Common", new System.Drawing.Point(120, 0)),
                new Weapon("GammaGun", "Rare", new System.Drawing.Point(220, 0) ),
                new Weapon("GammaGun", "Legendary", new System.Drawing.Point(320, 0)),
                new Weapon("CrowAxe", "Common", new System.Drawing.Point(120, 100)),
                new Weapon("CrowAxe", "Rare", new System.Drawing.Point(220, 100)),
                new Weapon("CrowAxe", "Legendary", new System.Drawing.Point(320, 100)),
                new Weapon("Ripper", "Common", new System.Drawing.Point(120, 200)),
                new Weapon("Ripper", "Rare", new System.Drawing.Point(220, 200)),
                new Weapon("Ripper", "Legendary", new System.Drawing.Point(320, 200)),
                new Weapon("ShishKebab", "Common", new System.Drawing.Point(120, 300)),
                new Weapon("ShishKebab", "Rare", new System.Drawing.Point(220, 300)),
                new Weapon("ShishKebab", "Legendary", new System.Drawing.Point(320, 300)),
                new Weapon("SuperHammer", "Common", new System.Drawing.Point(120, 400)),
                new Weapon("SuperHammer", "Rare", new System.Drawing.Point(220, 400)),
                new Weapon("SuperHammer", "Legendary", new System.Drawing.Point(320, 400)),
                new Weapon("NukaShredder", "Common", new System.Drawing.Point(120, 500)),
                new Weapon("NukaShredder", "Rare", new System.Drawing.Point(220, 500)),
                new Weapon("NukaShredder", "Legendary", new System.Drawing.Point(320, 500)),
            };
            foreach (Weapon gun in guns)
            {
                var gandon = new WeaponUC(gun);
                Canvas.SetTop(gandon, gun.Cor.Y);
                Canvas.SetLeft(gandon, gun.Cor.X);
                InvCns.Children.Add(gandon);
                gandon.PreviewMouseDown += Weapon_PreviewMouseDown;
            }
        }
        UIElement dragObject = null;
        Point offset;

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
            if (this.dragObject != null)
            {
                WeaponUC weapon = this.dragObject as WeaponUC;
                var Position = e.GetPosition(sender as IInputElement);
                MessageBox.Show(Position.X.ToString());   
                if (Position.X < 120)
                {
                    Canvas.SetTop(this.dragObject, 5);
                    Canvas.SetLeft(this.dragObject, 5);
                }
                else
                {
                    Canvas.SetTop(this.dragObject, double.Parse(weapon.CorY.Text));
                    Canvas.SetLeft(this.dragObject, double.Parse(weapon.CorX.Text));
                }
                this.dragObject = null;
                this.InvCns.ReleaseMouseCapture();
            }   
        }
    }
}
