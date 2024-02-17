using Game.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
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
using static System.Net.Mime.MediaTypeNames;

namespace Game.PagesWindows
{
    /// <summary>
    /// Логика взаимодействия для HeroEditPage.xaml
    /// </summary>
    public partial class HeroEditPage : Page
    {
        public Weapon selWeapon1;
        public Weapon selWeapon2;
        public int ClassIndex = -1;
       
        public HeroEditPage()
        {
            InitializeComponent();
            NameTbx.Text = "Имя";
            StatTbx.Text = "0";
            LevelTbx.Text= "1";
            ExpTbx.Text = "0";
            MaxExpTbx.Text = "1000";
        }

        private void ClassCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClassIndex = ClassCbx.SelectedIndex;
            
            if (ClassIndex == 0)
            {
                Merc.Visibility = Visibility.Visible;
                Raider.Visibility = Visibility.Collapsed;
                Atom.Visibility = Visibility.Collapsed;
                // StrengthTb.Text = "30";
                App.Stats[0] = 30;
                MaxStrengthTb.Text = "250";
                App.Stats[1] = 15;
                MaxAgilityTb.Text = "80";
                App.Stats[2] = 10;
                MaxIntelligenceTb.Text = "50";
                App.Stats[3] = 25;
                MaxEnduranceTb.Text = "100";
            }
            else if (ClassIndex == 1)
            {
                Merc.Visibility = Visibility.Collapsed;
                Raider.Visibility = Visibility.Visible;
                Atom.Visibility = Visibility.Collapsed;
                App.Stats[0] = 20;
                MaxStrengthTb.Text = "65";
                App.Stats[1] = 30;
                MaxAgilityTb.Text = "250";
                App.Stats[2] = 15;
                MaxIntelligenceTb.Text = "70";
                App.Stats[3] = 20;
                MaxEnduranceTb.Text = "80";
            }
            else if (ClassIndex == 2)
            {
                Merc.Visibility = Visibility.Collapsed;
                Raider.Visibility = Visibility.Collapsed;
                Atom.Visibility = Visibility.Visible;
                App.Stats[0] = 15;
                MaxStrengthTb.Text = "45";
                App.Stats[1] = 20;
                MaxAgilityTb.Text = "80";
                App.Stats[2] = 35;
                MaxIntelligenceTb.Text = "250";
                App.Stats[3] = 15;
                MaxEnduranceTb.Text = "70";
            }
            Refresh();
        }

        public void Refresh()
        { 
            App.heroEditPage = this;
            if (ClassIndex == 0)
            {
                StrengthTb.Text = (App.Stats[0] + App.StatBonus[0]).ToString();
                AgilityTb.Text = (App.Stats[1] + App.StatBonus[1]).ToString();
                IntelligenceTb.Text = (App.Stats[2] + App.StatBonus[2]).ToString();
                EnduranceTb.Text = (App.Stats[3] + App.StatBonus[3]).ToString();

                HPTbx.Text = (App.Stats[4] + App.Stats[3] * 2 + App.Stats[0] + App.StatBonus[4]).ToString();
                ManaTbx.Text = (App.Stats[5] + App.Stats[2] + App.StatBonus[5]).ToString();

                PDamageTb.Text = (App.Stats[6] + App.Stats[0] + App.StatBonus[6]).ToString();
                ArmorTb.Text = (App.Stats[7] + App.Stats[1] + App.StatBonus[7]).ToString();
                MDamageTb.Text = (App.Stats[8] + (Math.Round(App.Stats[2] * 0.2) + App.StatBonus[8])).ToString();
                MDefenceTb.Text = (App.Stats[9] + (Math.Round(App.Stats[2] * 0.5) + App.StatBonus[9])).ToString();
               
                CrtChanceTb.Text = (App.Stats[10] + (Math.Round(App.Stats[1] * 0.2) + App.StatBonus[10])).ToString();
                CrtDamageTb.Text = (App.Stats[11] + (Math.Round(App.Stats[1] * 0.1) + App.StatBonus[11])).ToString(); 
            }
            else if (ClassIndex == 1)
            {
                StrengthTb.Text = (App.Stats[0] + App.StatBonus[0]).ToString();
                AgilityTb.Text = (App.Stats[1] + App.StatBonus[1]).ToString();
                IntelligenceTb.Text = (App.Stats[2] + App.StatBonus[2]).ToString();
                EnduranceTb.Text = (App.Stats[3] + App.StatBonus[3]).ToString();

                HPTbx.Text = (Math.Round(App.Stats[4] * 1.5 + App.Stats[0] * 0.5 + App.StatBonus[4]).ToString());
                ManaTbx.Text = (Math.Round(App.Stats[5] * 1.2 + App.StatBonus[5]).ToString());

                PDamageTb.Text = (Math.Round(App.Stats[0] * 0.5 + App.Stats[1] * 0.5 + App.StatBonus[6]).ToString());
                ArmorTb.Text = (Math.Round(App.Stats[1] * 1.5 + App.StatBonus[7] ).ToString());
                MDamageTb.Text = (Math.Round(App.Stats[2] * 0.2 + App.StatBonus[8]).ToString());
                MDefenceTb.Text = (Math.Round(App.Stats[2] * 0.5 + App.StatBonus[9])).ToString();
                CrtChanceTb.Text = (Math.Round(App.Stats[1] * 0.2 + App.StatBonus[10]).ToString());
                CrtDamageTb.Text = (Math.Round(App.Stats[1] * 0.1) + App.StatBonus[11]).ToString();
            }
            else if (ClassIndex == 2)
            {
                StrengthTb.Text = (App.Stats[0] + App.StatBonus[0]).ToString();
                AgilityTb.Text = (App.Stats[1] + App.StatBonus[1]).ToString();
                IntelligenceTb.Text = (App.Stats[2] + App.StatBonus[2]).ToString();
                EnduranceTb.Text = (App.Stats[3] + App.StatBonus[3]).ToString();

                HPTbx.Text = (Math.Round(App.Stats[3] * 1.4 + App.Stats[0] * 0.2 + App.StatBonus[4]).ToString());
                ManaTbx.Text = (Math.Round(App.Stats[2] * 1.5) + App.StatBonus[5]).ToString();

                PDamageTb.Text = (Math.Round(App.Stats[0] * 0.5) + App.StatBonus[6]).ToString();
                ArmorTb.Text = (App.Stats[1] + App.StatBonus[7]).ToString();
                MDamageTb.Text = ((App.Stats[2] + App.StatBonus[8])).ToString();
                MDefenceTb.Text = ((App.Stats[2] + App.StatBonus[9])).ToString();
                CrtChanceTb.Text = (Math.Round(App.Stats[1] * 0.2 + App.StatBonus[10]).ToString());
                CrtDamageTb.Text = (Math.Round(App.Stats[1] * 0.1) + App.StatBonus[11]).ToString();
            }
            if (selWeapon1 != null)
            {
                if (selWeapon1.Type == "NukaShredder")
                {
                    CrtChanceTb.Text = "0";
                    CrtDamageTb.Text = "0";
                }
            }
        }

        private void StackPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PerkTitleTb.Text = "Сила";
            PerkDescTb.Text = "Необходимый навык, чтобы толкать камень в гору. Сила влияет на кол-во здоровья и на навыки ближнего боя.";
        }

        private void StackPanel_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            PerkTitleTb.Text = "Ловкость";
            PerkDescTb.Text = "Не бойся уклоняться от щекотливых вопросов и выпадов меча в твою сторону! Ловкость влияет на навыки: Броня, крит.урон и крит.шанс";
        }

        private void StackPanel_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            PerkTitleTb.Text = "Интеллект";
            PerkDescTb.Text = "Только умный может понять, как много он не знает. И призвать шаровую молнию. Интеллект определяет, как вы распоряжаетесь с силой радиации, и ваш рад.урон и защиту.";
        }

        private void StackPanel_MouseLeftButtonUp_3(object sender, MouseButtonEventArgs e)
        {
            PerkTitleTb.Text = "Выносливость";
            PerkDescTb.Text = "Только выносливый сможет добраться туда, куда лезть не стоило. Выносливость оказывает наибольшее влияние на выше здоровье.";
        }

        private void PerkPlus_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                int stat = int.Parse(StatTbx.Text);
                if (int.Parse(StatTbx.Text) > 0)
                {
                    switch (PerkTitleTb.Text)
                    {
                        case "Сила":
                            {
                                if (App.Stats[0] < int.Parse(MaxStrengthTb.Text))
                                {
                                    App.Stats[0]++;
                                    stat--;
                                    StatTbx.Text = stat.ToString();
                                    Refresh();
                                }
                                else MessageBox.Show("Навык максимальный!");
                                return;
                            }
                        case "Ловкость":
                            {
                                if (App.Stats[1] < int.Parse(MaxAgilityTb.Text))
                                {
                                    App.Stats[1]++;
                                    stat--;
                                    StatTbx.Text = stat.ToString();
                                    Refresh();
                                }
                                else MessageBox.Show("Навык максимальный!");
                                return;
                            }
                        case "Интеллект":
                            {
                                if (App.Stats[2] < int.Parse(MaxIntelligenceTb.Text))
                                {
                                    App.Stats[2]++;
                                    stat--;
                                    StatTbx.Text = stat.ToString();
                                    Refresh();
                                }
                                else MessageBox.Show("Навык максимальный!");
                                return;
                            }
                        case "Выносливость":
                            {
                                if (App.Stats[3] < int.Parse(MaxEnduranceTb.Text))
                                {
                                    App.Stats[3]++;
                                    stat--;
                                    StatTbx.Text = stat.ToString();
                                    Refresh();
                                }
                                else MessageBox.Show("Навык максимальный!");
                                return;
                            }
                        default: 
                            { 
                                MessageBox.Show("Cначала выберите навык! ");
                                break;
                            }
                    }
                }
                else MessageBox.Show("Нет свободных очков навыка. ");
            }
            else MessageBox.Show("Сначала выберите класс героя и нажмите сохранить!");
        }
        private void SaveButt_Click(object sender, RoutedEventArgs e)
        {
            if (ClassCbx.SelectedIndex != -1)
            {
                MessageBox.Show("Класс выбран. ");
                App.CanUpgrade = true;
                ClassCbx.IsEnabled = false;
            }
            else MessageBox.Show("Сначала выберите класс героя!");
        }

        private void ExpGiveButt_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                int CurrentExp = int.Parse(ExpTbx.Text);
                CurrentExp += 500;
                if (CurrentExp >= int.Parse(MaxExpTbx.Text))
                {
                    ExpTbx.Text = (CurrentExp - int.Parse(MaxExpTbx.Text)).ToString();
                    MaxExpTbx.Text = (int.Parse(MaxExpTbx.Text) + 1000).ToString();
                    LevelTbx.Text = (int.Parse(LevelTbx.Text) + 1).ToString();
                    StatTbx.Text = (int.Parse(StatTbx.Text) + 10).ToString();
                    MessageBox.Show("Новый уровень!");
                    if (LevelTbx.Text == "10") ExpGiveButt.IsEnabled = false;
                }
                else ExpTbx.Text = CurrentExp.ToString();
            }
            else MessageBox.Show("Сначала выберите класс героя и нажмите сохранить!");
            
        }

        public void EquipButt_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                Window inventory = new Inventory();
                inventory.Show();
            }
            else MessageBox.Show("Сначала выберите класс героя и нажмите сохранить!");
        }

        public void WeaponCheck(Weapon selWep1, Weapon selWep2)
        {
            selWeapon1 = selWep1;
            selWeapon2 = selWep2;
            if (selWeapon1 == null)
            {
                App.StatBonus = new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
            else if (selWeapon1.Type == "GammaGun")
            {
                App.StatBonus[6] = 1; App.StatBonus[5] = 10; App.StatBonus[2] = 10; App.StatBonus[10] = 5; App.StatBonus[11] = 300;
            }

            else if (selWep1.Type == "CrowAxe")
            {
                App.StatBonus[6] = 5; App.StatBonus[1] = 10; App.StatBonus[10] = 60; App.StatBonus[11] = 70;
                if (selWeapon2 != null)
                {
                    App.StatBonus[6] += 5; App.StatBonus[1] += 10; App.StatBonus[10] += 60; App.StatBonus[11] += 70;
                }
            }

            else if (selWeapon1.Type == "Ripper")
            {
                App.StatBonus[6] = 10; App.StatBonus[1] = 5; App.StatBonus[0] = 5; App.StatBonus[10] = 35; App.StatBonus[11] = 150;
            }

            else if (selWeapon1.Type == "ShishKebab")
            {
                App.StatBonus[6] = 15; App.StatBonus[0] = 15; App.StatBonus[10] = 20; App.StatBonus[11] = 170;
            }

            else if (selWeapon1.Type == "SuperHammer")
            {
                App.StatBonus[6] = 15; App.StatBonus[0] = 10; App.StatBonus[4] = 10; App.StatBonus[10] = 10; App.StatBonus[11] = 250;
            }
            else
            {
                App.StatBonus[0] = Math.Round(App.Stats[0] * 0.7);
                App.StatBonus[1] = Math.Round(App.Stats[1] * 0.7);
                App.StatBonus[2] = Math.Round(App.Stats[2] * 0.7);
                App.StatBonus[3] = Math.Round(App.Stats[3] * 0.7);
                App.StatBonus[4] = Math.Round(double.Parse(PDamageTb.Text) * 0.7);
                App.StatBonus[5] = Math.Round(double.Parse(ArmorTb.Text) * 0.7);
                App.StatBonus[6] = Math.Round(double.Parse(MDamageTb.Text) * 0.7);
                App.StatBonus[7] = Math.Round(double.Parse(MDefenceTb.Text) * 0.7);
                App.StatBonus[8] = Math.Round(double.Parse(CrtChanceTb.Text) * 0.7);
                App.StatBonus[9] = Math.Round(double.Parse(CrtDamageTb.Text) * 0.7);
                App.StatBonus[10] = 0;
                App.StatBonus[11] = 0;
                App.Stats[10] = 0;
                App.Stats[11] = 0;
                CrtChanceTb.Text = "0";
                CrtDamageTb.Text = "0";
            }
            int cunt = 0;
            if (selWeapon1 != null)
            {
                if (selWeapon1.Rarity == "Rare") cunt += 2;
                else if (selWeapon1.Rarity == "Legendary") cunt += 4;
            }

            if (selWeapon2 != null)
            {
                if (selWeapon2.Rarity == "Rare") cunt += 2;
                else if (selWeapon2.Rarity == "Legendary") cunt += 4;
            }

            for (int i = 1; i <= cunt; i++)
            {
                int statId = App.rnd.Next(0, 12);
                int statValue = App.rnd.Next(5, 16);
                App.StatBonus[statId] += statValue;
                MessageBox.Show("Лег. свойство: " + statId + ": " + statValue + "     " + App.StatBonus[statId]);
            }
            Refresh();
            
        }
    }
   
}
