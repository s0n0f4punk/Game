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
    /// Логика взаимодействия для HeroEditPage.xaml
    /// </summary>
    public partial class HeroEditPage : Page
    {
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
                AgiltyTb.Text = "15";
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
                AgiltyTb.Text = "30";
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
                AgiltyTb.Text = "20";
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
                HPTbx.Text = (int.Parse(EnduranceTb.Text) * 2 + int.Parse(StrengthTb.Text)).ToString();
                ManaTbx.Text = (int.Parse(IntelligenceTb.Text)).ToString();

                PDamageTb.Text = StrengthTb.Text;
                ArmorTb.Text = AgiltyTb.Text;
                MDamageTb.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 0.2).ToString());
                MDefenceTb.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 0.5).ToString());
                CrtChanceTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 0.2).ToString());
                CrtDamageTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 0.1)).ToString();
            }
            else if (index == 1)
            {
                HPTbx.Text = (Math.Round(int.Parse(EnduranceTb.Text) * 1.5 + int.Parse(StrengthTb.Text) * 0.5).ToString());
                ManaTbx.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 1.2).ToString());

                PDamageTb.Text = (Math.Round(int.Parse(StrengthTb.Text) * 0.5 + int.Parse(AgiltyTb.Text) * 0.5).ToString());
                ArmorTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 1.5).ToString());
                MDamageTb.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 0.2).ToString());
                MDefenceTb.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 0.5)).ToString();
                CrtChanceTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 0.2).ToString());
                CrtDamageTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 0.1)).ToString();
            }
            else if (index == 2)
            {
                HPTbx.Text = (Math.Round(int.Parse(EnduranceTb.Text) * 1.4 + int.Parse(StrengthTb.Text) * 0.2).ToString());
                ManaTbx.Text = (Math.Round(int.Parse(IntelligenceTb.Text) * 1.5)).ToString();

                PDamageTb.Text = (Math.Round(int.Parse(StrengthTb.Text) * 0.5)).ToString();
                ArmorTb.Text = AgiltyTb.Text;
                MDamageTb.Text = IntelligenceTb.Text;
                MDefenceTb.Text = IntelligenceTb.Text;
                CrtChanceTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 0.2).ToString());
                CrtDamageTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 0.1)).ToString();
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
                    int agility = int.Parse(AgiltyTb.Text);
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
                                return;
                            }
                            case "Ловкость":
                            {
                                if (agility < int.Parse(MaxAgilityTb.Text))
                                {
                                    agility++;
                                    stat--;
                                    StatTbx.Text = stat.ToString();
                                    AgiltyTb.Text = agility.ToString();
                                    Refresh();
                                }
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
                                return;
                            }
                        } 
                    }
                }
            } 
        }
        private void SaveButt_Click(object sender, RoutedEventArgs e)
        {
            if (ClassCbx.SelectedIndex != -1)
            {
                MessageBox.Show("длалщдапщдывбдпав");
                App.CanUpgrade = true;
                ClassCbx.IsEnabled = false;
            }
            else MessageBox.Show("Сначала выберите класс героя!");
        }

        private void ExpGiveButt_Click(object sender, RoutedEventArgs e)
        {
            
            int CurrentExp = int.Parse(ExpTbx.Text);
            CurrentExp += 500;
            if (CurrentExp >= int.Parse(MaxExpTbx.Text))
            {
                ExpTbx.Text = (CurrentExp - int.Parse(MaxExpTbx.Text)).ToString();
                MaxExpTbx.Text = (int.Parse(MaxExpTbx.Text) + 1000).ToString();
                LevelTbx.Text = (int.Parse(LevelTbx.Text) + 1).ToString();
                StatTbx.Text = (int.Parse(StatTbx.Text) + 10).ToString();
                if (LevelTbx.Text == "10") ExpGiveButt.IsEnabled = false;
            }
            else ExpTbx.Text = CurrentExp.ToString();
        }
    }
}
