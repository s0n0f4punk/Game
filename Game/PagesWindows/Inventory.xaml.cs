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
        public List<Weapon> guns = new List<Weapon>();
        public Inventory()
        {
            InitializeComponent();

            guns.AddRange(new List<Weapon> {
                new Weapon("GammaGun", "Common", new System.Drawing.Point(140, 0)),
                new Weapon("GammaGun", "Rare", new System.Drawing.Point(260, 0) ),
                new Weapon("GammaGun", "Legendary", new System.Drawing.Point(380, 0)),
                new Weapon("CrowAxe", "Common", new System.Drawing.Point(140, 120)),
                new Weapon("CrowAxe", "Rare", new System.Drawing.Point(260, 120)),
                new Weapon("CrowAxe", "Legendary", new System.Drawing.Point(380, 120)),
                new Weapon("Ripper", "Common", new System.Drawing.Point(140, 240)),
                new Weapon("Ripper", "Rare", new System.Drawing.Point(260, 240)),
                new Weapon("Ripper", "Legendary", new System.Drawing.Point(380, 240)),
                new Weapon("ShishKebab", "Common", new System.Drawing.Point(140, 360)),
                new Weapon("ShishKebab", "Rare", new System.Drawing.Point(260, 360)),
                new Weapon("ShishKebab", "Legendary", new System.Drawing.Point(380, 360)),
                new Weapon("SuperHammer", "Common", new System.Drawing.Point(140, 480)),
                new Weapon("SuperHammer", "Rare", new System.Drawing.Point(260, 480)),
                new Weapon("SuperHammer", "Legendary", new System.Drawing.Point(380, 480)),
                new Weapon("NukaShredder", "Common", new System.Drawing.Point(140, 600)),
                new Weapon("NukaShredder", "Rare", new System.Drawing.Point(260, 600)),
                new Weapon("NukaShredder", "Legendary", new System.Drawing.Point(380, 600)),
            });
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

        public bool isFirstSlotBusy = false;
        public bool isSecSlotBusy = false;
        public Weapon selWeapon1 = null;
        public Weapon selWeapon2 = null;
        public WeaponUC secWeapon;
        Uri cross = new Uri("pack://application:,,,/Resources/Cross.png");
        Uri shield = new Uri("pack://application:,,,/Resources/Shield.png");

        private void InvCns_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (this.dragObject != null)
            {
                if (selWeapon1 == null)
                {
                    Image.Source = new BitmapImage(new Uri(cross.ToString()));
                    isSecSlotBusy = true;
                }
                WeaponUC weapon = this.dragObject as WeaponUC;
                var Position = e.GetPosition(sender as IInputElement);
                if (Position.X < 120 && Position.Y < 120 && !isFirstSlotBusy)
                {
                    isFirstSlotBusy = true;
                    Canvas.SetTop(this.dragObject, 5);
                    Canvas.SetLeft(this.dragObject, 5);
                    selWeapon1 = guns.Find(x => x.Type == weapon.Type.Text && x.Rarity == weapon.Rarity.Text);
                }
                else
                {
                    if (selWeapon1 !=null)
                    {
                        if (weapon.Type.Text == selWeapon1.Type && selWeapon1.Rarity == weapon.Rarity.Text)
                        {
                            isFirstSlotBusy = false;
                            selWeapon1 = null;
                        }                    
                    } 
                    Canvas.SetTop(this.dragObject, double.Parse(weapon.CorY.Text));
                    Canvas.SetLeft(this.dragObject, double.Parse(weapon.CorX.Text));
                }
 
                
                if (isFirstSlotBusy && selWeapon1.Type != null)
                {
                    if ((selWeapon1.Type == "Ripper" || selWeapon1.Type == "ShishKebab" || selWeapon1.Type == "SuperHammer") && isFirstSlotBusy)
                    {
                        isSecSlotBusy = true;
                        Image.Source = new BitmapImage(new Uri(shield.ToString()));
                    }
                    else if (selWeapon1.Type == "CrowAxe")
                    {
                        Image.Source = null;
                        isSecSlotBusy = false;
                    }
                    else
                    {
                        Image.Source = new BitmapImage(new Uri(cross.ToString()));
                        isSecSlotBusy = true;
                    }
                }
                else 
                {
                    Image.Source = new BitmapImage(new Uri(cross.ToString()));
                    isSecSlotBusy = true;
                }

                if (!isSecSlotBusy && Position.X < 120 && Position.Y > 120 && Position.Y < 260 && weapon.Type.Text == "CrowAxe" && secWeapon == null)
                {
                    isSecSlotBusy = true;
                    secWeapon = this.dragObject as WeaponUC;
                    Canvas.SetTop(this.dragObject, 145);
                    Canvas.SetLeft(this.dragObject, 5);
                    selWeapon2 = guns.Find(x => x.Type == weapon.Type.Text && x.Rarity == weapon.Rarity.Text);
                }
                else if (secWeapon != null && !isSecSlotBusy)
                {
                    Canvas.SetTop(secWeapon, double.Parse(secWeapon.CorY.Text));
                    Canvas.SetLeft(secWeapon, double.Parse(secWeapon.CorX.Text));
                    selWeapon2 = null;
                    secWeapon = null;
                }

                this.dragObject = null;
                this.InvCns.ReleaseMouseCapture();
            }   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            App.heroEditPage.WeaponCheck(selWeapon1,selWeapon2);
        }
    }
}
