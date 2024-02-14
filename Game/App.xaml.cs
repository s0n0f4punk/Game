using Game.PagesWindows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Game
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static bool CanUpgrade = false;
        public static HeroEditPage heroEditPage = new HeroEditPage();
    }
}
