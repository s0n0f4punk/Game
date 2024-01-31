using Microsoft.Win32;
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

namespace Game
{
    /// <summary>
    /// Логика взаимодействия для HeroEditPage.xaml
    /// </summary>
    public partial class HeroEditPage : Page
    {
        public HeroEditPage()
        {
            InitializeComponent();
            NameTbx.Text = "Name";

        }

        private void ClassCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ClassCbx.SelectedIndex;
            if (index == 0)
            {
                StrengthTb.Text = "30"; MaxStrengthTb.Text = "250";
                AgiltyTb.Text = "15"; MaxAgilityTb.Text = "80";
                IntellegenceTb.Text = "10"; MaxIntellegenceTb.Text = "50";
                EnduranceTb.Text = "25"; MaxEnduranceTb.Text = "100";

                HPTbx.Text = (int.Parse(EnduranceTb.Text) * 2 + int.Parse(StrengthTb.Text)).ToString();
                ManaTbx.Text = (int.Parse(IntellegenceTb.Text)).ToString();

                PDamageTb.Text = StrengthTb.Text;
                ArmorTb.Text = AgiltyTb.Text;
                MDamageTb.Text = (int.Parse(IntellegenceTb.Text) * 0.2).ToString();
                MDefenceTb.Text = (int.Parse(IntellegenceTb.Text) * 0.5).ToString();
                CrtChanceTb.Text = (int.Parse(AgiltyTb.Text) * 0.2).ToString();
                CrtDamageTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 0.1)).ToString();
            }
            else if (index == 1)
            {
                StrengthTb.Text = "20"; MaxStrengthTb.Text = "65";
                AgiltyTb.Text = "30"; MaxAgilityTb.Text = "250";
                IntellegenceTb.Text = "15"; MaxIntellegenceTb.Text = "70";
                EnduranceTb.Text = "20"; MaxEnduranceTb.Text = "80";

                HPTbx.Text = (int.Parse(EnduranceTb.Text) * 1.5 + int.Parse(StrengthTb.Text) * 0.5).ToString();
                ManaTbx.Text = (int.Parse(IntellegenceTb.Text) * 1.2).ToString();

                PDamageTb.Text = (int.Parse(StrengthTb.Text) * 0.5 + int.Parse(AgiltyTb.Text) * 0.5).ToString();
                ArmorTb.Text = (int.Parse(AgiltyTb.Text) * 1.5).ToString();
                MDamageTb.Text = (int.Parse(IntellegenceTb.Text) * 0.2).ToString();
                MDefenceTb.Text = (Math.Round(int.Parse(IntellegenceTb.Text) * 0.5)).ToString();
                CrtChanceTb.Text = (int.Parse(AgiltyTb.Text) * 0.2).ToString();
                CrtDamageTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 0.1)).ToString();
            }
            else if (index == 2)
            {
                StrengthTb.Text = "15"; MaxStrengthTb.Text = "45";
                AgiltyTb.Text = "20"; MaxAgilityTb.Text = "80";
                IntellegenceTb.Text = "35"; MaxIntellegenceTb.Text = "250";
                EnduranceTb.Text = "15"; MaxEnduranceTb.Text = "70";

                HPTbx.Text = (int.Parse(EnduranceTb.Text) * 1.4 + int.Parse(StrengthTb.Text) * 0.2).ToString();
                ManaTbx.Text = (Math.Round(int.Parse(IntellegenceTb.Text) * 1.5)).ToString();

                PDamageTb.Text = (Math.Round(int.Parse(StrengthTb.Text) * 0.5)).ToString();
                ArmorTb.Text = AgiltyTb.Text;
                MDamageTb.Text = IntellegenceTb.Text;
                MDefenceTb.Text = IntellegenceTb.Text;
                CrtChanceTb.Text = (int.Parse(AgiltyTb.Text) * 0.2).ToString();
                CrtDamageTb.Text = (Math.Round(int.Parse(AgiltyTb.Text) * 0.1)).ToString();
            }
        }

        private void StackPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PerkTitleTb.Text = "СИЛА";
            PerkDescTb.Text = "описаниеописаниеописаниеописаниеописаниеописаниеописаниеописаниеописаниеописание";
        }

        private void StackPanel_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            PerkTitleTb.Text = "ЛОВКОСТЬ";
            PerkDescTb.Text = "описаниеописаниеописаниеописаниеописаниеописаниеописаниеописаниеописаниеописание";
        }

        private void StackPanel_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            PerkTitleTb.Text = "УМНОСТЬ";
            PerkDescTb.Text = "описаниеописаниеописаниеописаниеописаниеописаниеописаниеописаниеописаниеописание";
        }

        private void StackPanel_MouseLeftButtonUp_3(object sender, MouseButtonEventArgs e)
        {
            PerkTitleTb.Text = "ВЫНОСИТЬ";
            PerkDescTb.Text = "муосрмуосрмуосрмуосрмуосрмуосрмуосрмуосрмуосрмуосрмуоср";
        }
    }
}
