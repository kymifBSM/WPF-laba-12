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

namespace WPF_laba12
{
    /// <summary>
    /// Логика взаимодействия для zadanie2.xaml
    /// </summary>
    public partial class zadanie2 : Window
    {
        public zadanie2()
        {
            InitializeComponent();
        }

        public void GOM(Object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        public void GO3(Object sender, RoutedEventArgs e)
        {
            zadanie3 z3 = new zadanie3();
            z3.Show();
            Close();
        }

        public void Exit(Object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
