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
        public List<Equip> armors = new List<Equip>();
        public Weapon selWeapon1 = null;
        public Weapon selWeapon2 = null;
        public Equip selArmor = null;
        public Equip selRing1 = null;
        public Equip selRing2 = null;
        public Equip selAmulet = null;
        public Equip selHelmet = null;
        public Weapon selShield = null;
        public bool isFirstSlotBusy = false;
        public bool isSecSlotBusy = false;
        public bool isShieldAble = false;
        public Inventory(Weapon _selWeapon1, Weapon _selWeapon2)
        {
            InitializeComponent();
            selWeapon1 = _selWeapon1;
            selWeapon2 = _selWeapon2;
            guns.AddRange(new List<Weapon> {
                new Weapon("GammaGun", "Common", new System.Drawing.Point(140, 0), " - "),
                new Weapon("GammaGun", "Rare", new System.Drawing.Point(260, 0), "ИН:10; ВН:5" ),
                new Weapon("GammaGun", "Legendary", new System.Drawing.Point(380, 0), "ИН:6; Р.УР:10; КР.УР:12; СЛ:8"),
                new Weapon("CrowAxe", "Common", new System.Drawing.Point(140, 120), " - "),
                new Weapon("CrowAxe", "Rare", new System.Drawing.Point(260, 120), "ВН:8; Р.ЗЩ:10"),
                new Weapon("CrowAxe", "Legendary", new System.Drawing.Point(380, 120), "ЛВ:12; КР.Ш:12; ЛВ:5; Р.УР:9"),
                new Weapon("Ripper", "Common", new System.Drawing.Point(140, 240), " - "),
                new Weapon("Ripper", "Rare", new System.Drawing.Point(260, 240), "ИН:7; СЛ:8"),
                new Weapon("Ripper", "Legendary", new System.Drawing.Point(380, 240), "СЛ:10; БР:13; КР.УР:5; Р.УР:15"),
                new Weapon("ShishKebab", "Common", new System.Drawing.Point(140, 360), " - "),
                new Weapon("ShishKebab", "Rare", new System.Drawing.Point(260, 360), "Р.УР:9; Р.ЗЩ:10"),
                new Weapon("ShishKebab", "Legendary", new System.Drawing.Point(380, 360), "КР.Ш:11; ЗД:9; Ф.УР:9; ОБЛ:13"),
                new Weapon("SuperHammer", "Common", new System.Drawing.Point(140, 480), " - "),
                new Weapon("SuperHammer", "Rare", new System.Drawing.Point(260, 480), "ОБЛ:10; БР:12"),
                new Weapon("SuperHammer", "Legendary", new System.Drawing.Point(380, 480), "КР.УР:4; Р.УР:9; Ф.УР:10; БР:6"),
                new Weapon("NukaShredder", "Common", new System.Drawing.Point(140, 600), " - "),
                new Weapon("NukaShredder", "Rare", new System.Drawing.Point(260, 600), "ИН:15; Ф.УР:15"),
                new Weapon("NukaShredder", "Legendary", new System.Drawing.Point(380, 600), "СЛ:5; ИН:5; ЛВ:5; ВН:5"),
                new Weapon("Shield", "Common", new System.Drawing.Point(140, 720), " - "),
                new Weapon("Shield", "Rare", new System.Drawing.Point(260, 720), "ИН:15; Ф.УР:15"),
                new Weapon("Shield", "Legendary", new System.Drawing.Point(380, 720), "СЛ:5; ИН:5; ЛВ:5; ВН:5"),
            });

            armors.AddRange(new List<Equip>
            {
                new Equip("Robe", "Common", new System.Drawing.Point(140, 0), " - "),
                new Equip("Robe", "Rare", new System.Drawing.Point(260, 0), "КР.УР:14;"),
                new Equip("Robe", "Legendary", new System.Drawing.Point(380, 0), "Ф.УР:9; ОБЛ:13"),
                new Equip("LeatherArmor", "Common", new System.Drawing.Point(140, 120), " - "),
                new Equip("LeatherArmor", "Rare", new System.Drawing.Point(260, 120), "ЗД:9; "),
                new Equip("LeatherArmor", "Legendary", new System.Drawing.Point(380, 120), "Р.УР:9; Р.УР:12"),
                new Equip("ChainArmor", "Common", new System.Drawing.Point(140, 240), " - "),
                new Equip("ChainArmor", "Rare", new System.Drawing.Point(260, 240), "СЛ:10; "),
                new Equip("ChainArmor", "Legendary", new System.Drawing.Point(380, 240), "Ф.УР:9; БР:13"),
                new Equip("PlateArmor", "Common", new System.Drawing.Point(140, 360), " - "),
                new Equip("PlateArmor", "Rare", new System.Drawing.Point(260, 360), "ЛВ:5;"),
                new Equip("PlateArmor", "Legendary", new System.Drawing.Point(380, 360), "КР.УР:8; ВН:5"),
                new Equip("Ring", "Common", new System.Drawing.Point(140, 480), " - "),
                new Equip("Ring", "Rare", new System.Drawing.Point(260, 480), "Р.УР:10;"),
                new Equip("Ring", "Legendary", new System.Drawing.Point(380, 480), "ИН:5; ЛВ:5"),
                new Equip("Amulet", "Common", new System.Drawing.Point(140, 600), " - "),
                new Equip("Amulet", "Rare", new System.Drawing.Point(260, 600), "СЛ:15;"),
                new Equip("Amulet", "Legendary", new System.Drawing.Point(380, 600), "ЗД:8; ВН:15"),
                new Equip("Helmet", "Common", new System.Drawing.Point(140, 720), " - "),
                new Equip("Helmet", "Rare", new System.Drawing.Point(260, 720), "Ф.УР:7;"),
                new Equip("Helmet", "Legendary", new System.Drawing.Point(380, 720), "ИН:9; ОБЛ:15"),
            });

            foreach (Equip eq in armors)
            {
                var equ = new EquipUC(eq);
                Canvas.SetTop(equ, eq.Cor.Y);
                Canvas.SetLeft(equ, eq.Cor.X);
                ArmorInvCns.Children.Add(equ);
                equ.PreviewMouseDown += Equip_PreviewMouseDown;
            }

            foreach (Weapon gun in guns)
            {
                if (selWeapon1 != null)
                {
                    if (gun.Type == selWeapon1.Type && gun.Rarity == selWeapon1.Rarity && gun.AddStats == selWeapon1.AddStats)
                    {
                        isFirstSlotBusy = true;
                        var gand = new WeaponUC(gun);
                        Canvas.SetTop(gand, 5);
                        Canvas.SetLeft(gand, 5);
                        InvCns.Children.Add(gand);
                        gand.PreviewMouseDown += Weapon_PreviewMouseDown;
                        if ((selWeapon1.Type == "Ripper" || selWeapon1.Type == "ShishKebab" || selWeapon1.Type == "SuperHammer") && !isSecSlotBusy)
                        {
                            isSecSlotBusy = true;
                            Image.Source = new BitmapImage(new Uri(shield.ToString()));
                            isShieldAble = true;
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
                        continue;
                    }
                }
                if (selWeapon2 != null)
                {
                    if (gun.Type == selWeapon2.Type && gun.Rarity == selWeapon2.Rarity && gun.AddStats == selWeapon2.AddStats)
                    {
                        isSecSlotBusy = true;
                        var gand = new WeaponUC(gun);
                        Canvas.SetTop(gand, 145);
                        Canvas.SetLeft(gand, 5);
                        InvCns.Children.Add(gand);
                        gand.PreviewMouseDown += Weapon_PreviewMouseDown;
                        continue;
                    }
                }

                var gandon = new WeaponUC(gun);
                Canvas.SetTop(gandon, gun.Cor.Y);
                Canvas.SetLeft(gandon, gun.Cor.X);
                InvCns.Children.Add(gandon);
                gandon.PreviewMouseDown += Weapon_PreviewMouseDown;
            }
        }
        UIElement dragObject = null;
        Point offset;

        private void Equip_PreviewMouseDown(object sender, MouseEventArgs e)
        {
            this.dragObject = sender as UIElement;
            this.offset = e.GetPosition(this.ArmorInvCns);
            this.offset.Y -= Canvas.GetTop(this.dragObject);
            this.offset.X -= Canvas.GetLeft(this.dragObject);
            this.ArmorInvCns.CaptureMouse();
        }
        private void ArmCns_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragObject == null) return;
            var position = e.GetPosition(sender as IInputElement);
            Canvas.SetTop(this.dragObject, position.Y - this.offset.Y);
            Canvas.SetLeft(this.dragObject, position.X - this.offset.X);
        }

        private void ArmCns_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (this.dragObject != null)
            {
                if (selArmor == null)
                {

                }
                EquipUC equip = this.dragObject as EquipUC;
                var Position = e.GetPosition(sender as IInputElement);
                if (Position.X < 120 && Position.Y < 120 && selArmor == null)
                {
                    if (equip.Type.Text == "Robe" || equip.Type.Text == "LeatherArmor" || equip.Type.Text == "ChainArmor" || equip.Type.Text == "PlateArmor")
                    {
                        Canvas.SetTop(this.dragObject, 5);
                        Canvas.SetLeft(this.dragObject, 5);
                        selArmor = armors.Find(x => x.Rarity == equip.Rarity.Text && x.Type == equip.Type.Text);
                    }
                    else
                    {
                        Canvas.SetTop(this.dragObject, double.Parse(equip.CorY.Text));
                        Canvas.SetLeft(this.dragObject, double.Parse(equip.CorX.Text));
                    }
                }
                else if (Position.X < 120 && Position.Y < 250 && Position.Y >= 120 && selRing1 == null)
                {
                    if (equip.Type.Text == "Ring")
                    {
                        Canvas.SetTop(this.dragObject, 135);
                        Canvas.SetLeft(this.dragObject, 5);
                        selRing1 = armors.Find(x => x.Rarity == equip.Rarity.Text && x.Type == equip.Type.Text);
                    }
                    else
                    {
                        Canvas.SetTop(this.dragObject, double.Parse(equip.CorY.Text));
                        Canvas.SetLeft(this.dragObject, double.Parse(equip.CorX.Text));
                    }
                }
                else if (Position.X < 120 && Position.Y < 380 && Position.Y >= 250 && selRing1 != null && selRing2 == null)
                {
                    if (equip.Type.Text == "Ring")
                    {
                        Canvas.SetTop(this.dragObject, 265);
                        Canvas.SetLeft(this.dragObject, 5);
                        selRing2 = armors.Find(x => x.Rarity == equip.Rarity.Text && x.Type == equip.Type.Text);
                    }
                    else
                    {
                        Canvas.SetTop(this.dragObject, double.Parse(equip.CorY.Text));
                        Canvas.SetLeft(this.dragObject, double.Parse(equip.CorX.Text));
                    }
                } 
                else
                {
                    Canvas.SetTop(this.dragObject, double.Parse(equip.CorY.Text));
                    Canvas.SetLeft(this.dragObject, double.Parse(equip.CorX.Text));
                    if (Position.X > 120 && (equip.Type.Text == "Robe" || equip.Type.Text == "LeatherArmor" || equip.Type.Text == "ChainArmor" || equip.Type.Text == "PlateArmor") && selArmor != null)
                    {
                        if (equip.Type.Text == selArmor.Type && equip.Rarity.Text == selArmor.Rarity)
                            selArmor = null;
                    }
                    else if ((equip.Type.Text == "Robe" || equip.Type.Text == "LeatherArmor" || equip.Type.Text == "ChainArmor" || equip.Type.Text == "PlateArmor") && selArmor != null && Position.X <120)
                    {
                        if (equip.Type.Text == selArmor.Type && equip.Rarity.Text == selArmor.Rarity)
                        {
                            Canvas.SetTop(this.dragObject, double.Parse(selArmor.Cor.Y.ToString()));
                            Canvas.SetLeft(this.dragObject, double.Parse(selArmor.Cor.X.ToString()));
                            selArmor = null;
                        }
                    }
                    else if (equip.Type.Text == "Ring")
                    {
                        if (selRing1 != null)
                        {
                            if (selRing1.Rarity == equip.Rarity.Text)
                            {
                                selRing1 = null;
                                if (selRing2 != null)
                                {
                                    foreach (var child in ArmorInvCns.Children)
                                    {
                                        EquipUC eq = child as EquipUC;
                                        if (eq != null)
                                        {
                                            if (eq.Type.Text == "Ring" && eq.Rarity.Text == selRing2.Rarity && eq.TipAddStat.Text == selRing2.AddStats)
                                            {
                                                Canvas.SetTop(eq, double.Parse(selRing2.Cor.Y.ToString()));
                                                Canvas.SetLeft(eq, double.Parse(selRing2.Cor.X.ToString()));
                                                selRing2 = null;
                                                eq = null;
                                                break;
                                            }
                                        }

                                    }
                                }

                            }
                        }
                        if (selRing2 != null)
                        {
                            if (selRing2.Rarity == equip.Rarity.Text)
                                selRing2 = null;
                        }
                    }

                }
                this.dragObject = null;
                this.ArmorInvCns.ReleaseMouseCapture();
            }
        }

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
        public WeaponUC secWeapon;
        readonly Uri cross = new Uri("pack://application:,,,/Resources/Cross.png");
        readonly Uri shield = new Uri("pack://application:,,,/Resources/Shield.png");

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
                    if (selWeapon1 != null)
                    {
                        if (weapon.Type.Text == selWeapon1.Type && selWeapon1.Rarity == weapon.Rarity.Text)
                        {
                            isFirstSlotBusy = false;
                            selWeapon1 = null;
                            if (selWeapon2 != null)
                            {
                                if (selWeapon2.Type == "CrowAxe")
                                {
                                    foreach (var child in InvCns.Children)
                                    {
                                        WeaponUC weap = child as WeaponUC;
                                        if (weap != null)
                                        {
                                            if (weap.Type.Text == "CrowAxe" && weap.Rarity.Text == selWeapon2.Rarity && weap.TipAddStat.Text == selWeapon2.AddStats)
                                            {
                                                Canvas.SetTop(weap, double.Parse(selWeapon2.Cor.Y.ToString()));
                                                Canvas.SetLeft(weap, double.Parse(selWeapon2.Cor.X.ToString()));
                                                selWeapon2 = null;
                                                weap = null;
                                                break;
                                            }
                                        }

                                    }
                                }
                                else if (selWeapon2.Type == "Shield")
                                {
                                    foreach (var child in InvCns.Children)
                                    {
                                        WeaponUC weap = child as WeaponUC;
                                        if (weap != null)
                                        {
                                            if (weap.Type.Text == "Shield" && weap.Rarity.Text == selWeapon2.Rarity && weap.TipAddStat.Text == selWeapon2.AddStats)
                                            {
                                                Canvas.SetTop(weap, double.Parse(selWeapon2.Cor.Y.ToString()));
                                                Canvas.SetLeft(weap, double.Parse(selWeapon2.Cor.X.ToString()));
                                                selWeapon2 = null;
                                                weap = null;
                                                break;
                                            }
                                        }

                                    }
                                }
                            }
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
                        isShieldAble = true;
                    }
                    else if (selWeapon1.Type == "CrowAxe")
                    {
                        Image.Source = null;
                        
                        if (selWeapon2 == null) isSecSlotBusy = false;
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
                
                if (isFirstSlotBusy && Position.X < 120 && Position.Y > 120 && Position.Y < 260 && !isSecSlotBusy && selWeapon2 == null)
                {
                    if (weapon.Type.Text == "CrowAxe")
                    {
                        Canvas.SetTop(this.dragObject, 145);
                        Canvas.SetLeft(this.dragObject, 5);
                        selWeapon2 = guns.Find(x => x.Type == weapon.Type.Text && x.Rarity == weapon.Rarity.Text);
                        isSecSlotBusy = true;
                    }
                }
                else if (isFirstSlotBusy && Position.X < 120 && Position.Y > 120 && Position.Y < 260 && isSecSlotBusy && selWeapon2 != null)
                {
                    selWeapon2 = null;
                    isSecSlotBusy = false;
                    secWeapon = this.dragObject as WeaponUC;
                    Canvas.SetTop(secWeapon, double.Parse(secWeapon.CorY.Text));
                    Canvas.SetLeft(secWeapon, double.Parse(secWeapon.CorX.Text));
                }
                else if (weapon.Type.Text == "Shield" && isFirstSlotBusy && Position.X < 120 && Position.Y > 120 && Position.Y < 260 &&  isShieldAble && selWeapon2 == null)
                {
                    Canvas.SetTop(this.dragObject, 145);
                    Canvas.SetLeft(this.dragObject, 5);
                    selWeapon2 = guns.Find(x => x.Type == weapon.Type.Text && x.Rarity == weapon.Rarity.Text);
                }
                else if (isFirstSlotBusy && isSecSlotBusy && selWeapon2 != null)
                {
                    if (Position.X < 120 && Position.Y > 120 && Position.Y < 260)
                    {
                        secWeapon = this.dragObject as WeaponUC;
                        Canvas.SetTop(secWeapon, double.Parse(secWeapon.CorY.Text));
                        Canvas.SetLeft(secWeapon, double.Parse(secWeapon.CorX.Text));
                        secWeapon = null;
                    }
                    else if (selWeapon2.Type == weapon.Type.Text && weapon.Rarity.Text == selWeapon2.Rarity)
                    {
                        selWeapon2 = null;
                        isSecSlotBusy = false;
                        secWeapon = this.dragObject as WeaponUC;
                        Canvas.SetTop(secWeapon, double.Parse(secWeapon.CorY.Text));
                        Canvas.SetLeft(secWeapon, double.Parse(secWeapon.CorX.Text));
                        secWeapon = null;
                    }
                }
                else if (isFirstSlotBusy && !isSecSlotBusy && selWeapon2 != null)
                {
                    if (selWeapon2.Type == weapon.Type.Text && weapon.Rarity.Text == selWeapon2.Rarity)
                    {
                        selWeapon2 = null;
                        isSecSlotBusy = false;
                        secWeapon = this.dragObject as WeaponUC;
                        Canvas.SetTop(secWeapon, double.Parse(secWeapon.CorY.Text));
                        Canvas.SetLeft(secWeapon, double.Parse(secWeapon.CorX.Text));
                        secWeapon = null;
                    }
                }
                this.dragObject = null;
                this.InvCns.ReleaseMouseCapture();
            }   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            App.heroEditPage.WeaponCheck(selWeapon1,selWeapon2, selArmor, selRing1, selRing2, selAmulet, selHelmet);
        }
    }
}
