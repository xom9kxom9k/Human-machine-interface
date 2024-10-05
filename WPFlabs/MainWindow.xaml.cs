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

namespace WPFlabs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void But_Play_Casino(object sender, RoutedEventArgs e)
        {
            casino.Play();
        }
        private void But_Stop_Casino(object sender, RoutedEventArgs e)
        {
            casino.Stop();
        }

        private void But_Play_Tamaev(object sender, RoutedEventArgs e)
        {
            tamaev.Play();
        }
        private void But_Stop_Tamaev(object sender, RoutedEventArgs e)
        {
            tamaev.Stop();
        }
        private void vol_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            casino.Volume = (double)vol.Value;
        }
        private void vol_ValueChanged2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tamaev.Volume = (double)vol2.Value;
        }
        private void playbutton1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("5 красное");
        }
        private void playbutton2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ОГО, ровно 21");
        }
        private void playbutton3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Бонуска не окупилась");
        }
        private void playbutton4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Флеш рояль");
        }
        private void playbutton5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ни как у Тамаева конечно, но тоже нормально");
        }
        private void playbutton6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тяните карту");
        }
    }
}
