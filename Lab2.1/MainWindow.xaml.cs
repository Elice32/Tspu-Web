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

namespace Lab2._1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Technical_Work(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry, this feature is temporarily unavailable, technical work is underway...");
        }

        private void Exit(object sender, RoutedEventArgs ex)
        {
            this.Close();
        }

        private void Connect_Author(object sender, RoutedEventArgs Author)
        {
            MessageBox.Show("You could connect with author by:\nVK: @design71123\nE-mail: 77707cx@gmail.com");
        }

        private void About(object sender, RoutedEventArgs about)
        {
            MessageBox.Show("Автор приложения: Лушин Владимир Айдарович, студент 1 курса институ передовых информационных технологий ТГПУ Л. Н. Толстого.");
        }

        private void Fun(object sender, RoutedEventArgs fun)
        {
            MessageBox.Show("Just for FUN...");
        }
    }
}