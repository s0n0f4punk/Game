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
        public List<double> StatBonus = new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
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
            int index = ClassCbx.SelectedIndex;
            if (index == 0)
            {
                Merc.Visibility = Visibility.Visible;
                Raider.Visibility = Visibility.Collapsed;
                Atom.Visibility = Visibility.Collapsed;
                StrengthTb.Text = "30";
                MaxStrengthTb.Text = "250";
                AgilityTb.Text = "15";
                MaxAgilityTb.Text = "80";
                IntelligenceTb.Text = "10";
                MaxIntelligenceTb.Text = "50";
                EnduranceTb.Text = "25";
                MaxEnduranceTb.Text = "100";

                Refresh();
            }
            else if (index == 1)
            {
                Merc.Visibility = Visibility.Collapsed;
                Raider.Visibility = Visibility.Visible;
                Atom.Visibility = Visibility.Collapsed;
                StrengthTb.Text = "20";
                MaxStrengthTb.Text = "65";
                AgilityTb.Text = "30";
                MaxAgilityTb.Text = "250";
                IntelligenceTb.Text = "15";
                MaxIntelligenceTb.Text = "70";
                EnduranceTb.Text = "20";
                MaxEnduranceTb.Text = "80";

                Refresh();
            }
            else if (index == 2)
            {
                Merc.Visibility = Visibility.Collapsed;
                Raider.Visibility = Visibility.Collapsed;
                Atom.Visibility = Visibility.Visible;
                StrengthTb.Text = "15";
                MaxStrengthTb.Text = "45";
                AgilityTb.Text = "20";
                MaxAgilityTb.Text = "80";
                IntelligenceTb.Text = "35";
                MaxIntelligenceTb.Text = "250";
                EnduranceTb.Text = "15";
                MaxEnduranceTb.Text = "70";

                Refresh();
            }
        }

        public void Refresh()
        {
            int index = ClassCbx.SelectedIndex;
            if (index == 0)
            {
                StrengthTb.Text = (int.Parse(StrengthTb.Text) + StatBonus[0]).ToString();
                AgilityTb.Text = (int.Parse(AgilityTb.Text) + StatBonus[1]).ToString();
                IntelligenceTb.Text = (int.Parse(IntelligenceTb.Text) + StatBonus[2]).ToString();
                EnduranceTb.Text = (int.Parse(EnduranceTb.Text) + StatBonus[3]).ToString();

                HPTbx.Text = (int.Parse(EnduranceTb.Text) * 2 + int.Parse(StrengthTb.Text) + StatBonus[4]).ToString();
                ManaTbx.Text = (int.Parse(IntelligenceTb.Text) + StatBonus[5]).ToString();

                PDamageTb.Text = (int.Parse(StrengthTb.Text) + StatBonus[6]).ToString();
                ArmorTb.Text = (int.Parse(AgilityTb.Text) + StatBonus[7]).ToString();
                MDamageTb.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 0.2 + StatBonus[8]).ToString());
                MDefenceTb.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 0.5 + StatBonus[9]).ToString());
                CrtChanceTb.Text = (Math.Round(int.Parse(AgilityTb.Text) * 0.2 + StatBonus[10]).ToString());
                CrtDamageTb.Text = (Math.Round(int.Parse(AgilityTb.Text) * 0.1) + StatBonus[11]).ToString();
            }
            else if (index == 1)
            {
                StrengthTb.Text = (int.Parse(StrengthTb.Text) + StatBonus[0]).ToString();
                AgilityTb.Text = (int.Parse(AgilityTb.Text) + StatBonus[1]).ToString();
                IntelligenceTb.Text = (int.Parse(IntelligenceTb.Text) + StatBonus[2]).ToString();
                EnduranceTb.Text = (int.Parse(EnduranceTb.Text) + StatBonus[3]).ToString();

                HPTbx.Text = (Math.Round(int.Parse(EnduranceTb.Text) * 1.5 + int.Parse(StrengthTb.Text) * 0.5 + StatBonus[4]).ToString());
                ManaTbx.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 1.2 + StatBonus[5]).ToString());

                PDamageTb.Text = (Math.Round(int.Parse(StrengthTb.Text) * 0.5 + int.Parse(AgilityTb.Text) * 0.5 + StatBonus[6]).ToString());
                ArmorTb.Text = (Math.Round(int.Parse(AgilityTb.Text) * 1.5 + StatBonus[7] ).ToString());
                MDamageTb.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 0.2 + StatBonus[8]).ToString());
                MDefenceTb.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 0.5 + StatBonus[9])).ToString();
                CrtChanceTb.Text = (Math.Round(int.Parse(AgilityTb.Text) * 0.2 + StatBonus[10]).ToString());
                CrtDamageTb.Text = (Math.Round(int.Parse(AgilityTb.Text) * 0.1) + StatBonus[11]).ToString();
            }
            else if (index == 2)
            {
                StrengthTb.Text = (int.Parse(StrengthTb.Text) + StatBonus[0]).ToString();
                AgilityTb.Text = (int.Parse(AgilityTb.Text) + StatBonus[1]).ToString();
                IntelligenceTb.Text = (int.Parse(IntelligenceTb.Text) + StatBonus[2]).ToString();
                EnduranceTb.Text = (int.Parse(EnduranceTb.Text) + StatBonus[3]).ToString();

                HPTbx.Text = (Math.Round(int.Parse(EnduranceTb.Text) * 1.4 + int.Parse(StrengthTb.Text) * 0.2 + StatBonus[4]).ToString());
                ManaTbx.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 1.5) + StatBonus[5]).ToString();

                PDamageTb.Text = (Math.Round(int.Parse(StrengthTb.Text) * 0.5) + StatBonus[6]).ToString();
                ArmorTb.Text = (int.Parse(AgilityTb.Text) + StatBonus[7]).ToString();
                MDamageTb.Text = (int.Parse(IntelligenceTb.Text + StatBonus[8])).ToString();
                MDefenceTb.Text = (int.Parse(IntelligenceTb.Text + StatBonus[9])).ToString();
                CrtChanceTb.Text = (Math.Round(int.Parse(   AgilityTb.Text) * 0.2 + StatBonus[10]).ToString());
                CrtDamageTb.Text = (Math.Round(int.Parse(AgilityTb.Text) * 0.1) + StatBonus[11]).ToString();
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
                if (ClassCbx.SelectedIndex != -1)
                {
                    int stat = int.Parse(StatTbx.Text);
                    int strength = int.Parse(StrengthTb.Text);
                    int agility = int.Parse(AgilityTb.Text);
                    int intelligence = int.Parse(IntelligenceTb.Text);
                    int endurance = int.Parse(EnduranceTb.Text);
                    if (int.Parse(StatTbx.Text) > 0)
                    {
                        switch (PerkTitleTb.Text)
                        {
                            case "Сила":
                                {
                                    if (strength < int.Parse(MaxStrengthTb.Text))
                                    {
                                        strength++;
                                        stat--;
                                        StatTbx.Text = stat.ToString();
                                        StrengthTb.Text = strength.ToString();
                                        Refresh();
                                    }
                                    else MessageBox.Show("Навык максимальный!");
                                    return;
                                }
                            case "Ловкость":
                                {
                                    if (agility < int.Parse(MaxAgilityTb.Text))
                                    {
                                        agility++;
                                        stat--;
                                        StatTbx.Text = stat.ToString();
                                        AgilityTb.Text = agility.ToString();
                                        Refresh();
                                    }
                                    else MessageBox.Show("Навык максимальный!");
                                    return;
                                }
                            case "Интеллект":
                                {
                                    if (intelligence < int.Parse(MaxIntelligenceTb.Text))
                                    {
                                        intelligence++;
                                        stat--;
                                        StatTbx.Text = stat.ToString();
                                        IntelligenceTb.Text = intelligence.ToString();
                                        Refresh();
                                    }
                                    else MessageBox.Show("Навык максимальный!");
                                    return;
                                }
                            case "Выносливость":
                                {
                                    if (endurance < int.Parse(MaxEnduranceTb.Text))
                                    {
                                        endurance++;
                                        stat--;
                                        StatTbx.Text = stat.ToString();
                                        EnduranceTb.Text = endurance.ToString();
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

        private void EquipButt_Click(object sender, RoutedEventArgs e)
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
            MessageBox.Show(selWep1.Type);
            if (selWep1 == null)
            {
                StatBonus = new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            } 
            else if (selWep1.Type == "GammaGun") 
            {
                StatBonus[6] = 1; StatBonus[5] = 10; StatBonus[2] = 10; StatBonus[10] = 5; StatBonus[11] = 300;
            }

            else if (selWep1.Type == "CrowAxe")
            {
                StatBonus[6] = 5; StatBonus[1] = 10; StatBonus[10] = 60; StatBonus[11] = 70;
                if (selWep2 != null)
                {
                    StatBonus[6] += 5; StatBonus[1] += 10; StatBonus[10] += 60; StatBonus[11] += 70;
                }
            }

            else if (selWep1.Type == "Ripper") 
            {
                StatBonus[6] = 10; StatBonus[1] = 5; StatBonus[0] = 5; StatBonus[10] = 35; StatBonus[11] = 150;
            }

            else if (selWep1.Type == "ShishKebab")
            {
                StatBonus[6] = 15; StatBonus[0] = 15; StatBonus[10] = 20; StatBonus[11] = 170;
            }

            else if (selWep1.Type == "SuperHammer")
            {
                StatBonus[6] = 15; StatBonus[0] = 10; StatBonus[4] = 10; StatBonus[10] = 10; StatBonus[11] = 250;
            }
            else
            {
                StatBonus[0] = double.Parse(StrengthTb.Text) * 0.7;
                StatBonus[1] = double.Parse(AgilityTb.Text) * 0.7;
                StatBonus[2] = double.Parse(IntelligenceTb.Text) * 0.7;
                StatBonus[3] = double.Parse(EnduranceTb.Text) * 0.7;
                StatBonus[4] = double.Parse(HPTbx.Text) * 0.7;
                StatBonus[5] = double.Parse(ManaTbx.Text) * 0.7;
                StatBonus[6] = double.Parse(PDamageTb.Text) * 0.7;
                StatBonus[7] = double.Parse(ArmorTb.Text) * 0.7;
                StatBonus[8] = double.Parse(MDamageTb.Text) * 0.7;
                StatBonus[9] = double.Parse(MDefenceTb.Text) * 0.7;
                StatBonus[10] = - double.Parse(CrtChanceTb.Text);
                StatBonus[11] = - double.Parse(CrtDamageTb.Text);
            }
            Refresh();
        }
    }
}
