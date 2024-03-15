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

namespace HW_9
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
        private void btm_navy_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Navy;
        }

        private void btm_blue_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Blue;
        }

        private void btm_aqua_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Aqua;
        }

        private void btm_teal_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Teal;
        }

        private void btm_olive_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Olive;
        }

        private void btm_green_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Green;
        }

        private void btm_Lime_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Lime;
        }

        private void btm_yellow_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Yellow;
        }

        private void btm_orange_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Orange;
        }

        private void btm_red_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Red;
        }

        private void btm_maroon_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Maroon;
        }

        private void btm_fuchsia_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Fuchsia;
        }

        private void btm_purple_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Purple;
        }

        private void btm_black_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Black;
        }

        private void btm_silver_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Silver;
        }

        private void btm_gray_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.Gray;
        }

        private void btm_white_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = Brushes.White;
        }

        private void btm_calc_Click(object sender, RoutedEventArgs e)
        {            
            Calculator calc = new Calculator();
            calc.Show();
        }
    }
}
