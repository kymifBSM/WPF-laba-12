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
    /// Логика взаимодействия для zadanie3.xaml
    /// </summary>
    public partial class zadanie3 : Window
    {
        public zadanie3()
        {
            InitializeComponent();

        }

        bool isButton1Enable = true;
        bool isButton2Enable = true;
        bool isDoubleEnable = true;

        public void Message(object sender, RoutedEventArgs e)
        {
            if (isButton1Enable)
            {
                MessageBox.Show(
                    "Ефремов",
                    "Моя фамилия",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Hand);
            }
        }

        public void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Check(object sender, RoutedEventArgs e)
        {
            if (isButton2Enable)
            {
                isButton1Enable = false;
                isButton2Enable = false;
            }
            else
            {
                isButton1Enable = true;
                isButton2Enable = true;
            }

        }

        public void About(object sender, RoutedEventArgs e)
        {
            About a = new About();
            a.Show();
            Close();
        }

        public void GO2(object sender, RoutedEventArgs e)
        {
            zadanie2 z2 = new zadanie2();
            z2.Show();
            Close();
        }

        public void Double(object sender, RoutedEventArgs e)
        {
            if (isDoubleEnable)
            {
                MI.Items.Add("Message");
                MI.Items.Add("Check");
                MI.Items.Add("Exit");

                isDoubleEnable = false;
            }
            else
            {
                MI.Items.Remove("Message");
                MI.Items.Remove("Check");
                MI.Items.Remove("Exit");

                isDoubleEnable = true;
            }
        }
    }
}
