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
            if (App.userId == "1")
            {
                hallsButton.IsEnabled = true;
            }
        }

        private void changesButton_Click(object sender, RoutedEventArgs e)
        {
            Changes changes = new Changes();
            changes.Show();
            Close();
        }

        private void hallsButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.userlogin == "Admin")
            {
                AddEvent addEvent = new AddEvent();
                addEvent.Show();
                Close();
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав!");
            }
        }

        private void ticketsButton_Click(object sender, RoutedEventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            Close();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти из аккаунта?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No) { }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
        }
    }
}
