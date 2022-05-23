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

namespace Diplom_2022
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void changesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hallsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Улыбок тебе, дед Мокар!");
        }

        private void ticketsButton_Click(object sender, RoutedEventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            Close();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
