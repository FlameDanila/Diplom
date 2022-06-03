using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddEvent.xaml
    /// </summary>
    public partial class AddEvent : Window
    {
        public AddEvent()
        {
            InitializeComponent();
            DataTable data = Select("select Type from venueType");
            DataTable table = Select("select Name from EventType");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                venueCombo.Items.Add(data.Rows[i][0]);
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                typeCombo.Items.Add(table.Rows[i][0]);
            }
            venueCombo.SelectedIndex = 0;
            typeCombo.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameText.Text == "" || DateText.Text == "" || ticketsCount.Text == "" || timeText.Text == "" || ageText.Text == "" || CostText.Text == "")
            {
                MessageBox.Show("У вас остались незаполненые поля");
            }
            else
            {
                DataTable data = Select($"select id from venueType where type = '{venueCombo.Text}'");
                DataTable datatable = Select($"select id from EventType where name = '{typeCombo.Text}'");
                Events events = new Events()
                {
                    Name = nameText.Text,
                    Date = DateText.Text.ToString(),
                    GainTicketsCount = Convert.ToInt32(ticketsCount.Text),
                    SoldTicketsCount = 0,
                    Time = timeText.Text,
                    Age = Convert.ToInt32(ageText.Text),
                    Cost = Convert.ToInt32(CostText.Text),
                    Profession = proffessionText.Text,
                    Eduacation = "-",
                    TypeId = Convert.ToInt32(datatable.Rows[0][0]),
                    VenueId = Convert.ToInt32(data.Rows[0][0]),
                    Couch = couch_Text.Text
                };
                App.db.Events.Add(events);

                App.db.SaveChanges();
                MessageBox.Show("Мероприятие добавлено");
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            Close();
        }

        public new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"([^а-яА-Я]+)");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void DigitsTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"^[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }
        public DataTable Select(string selectSQL)
        {
            DataTable data = new DataTable("dataBase");

            string path = "ConnectionString.txt";

            string text = File.ReadAllText(path);

            string[] vs = text.Split('"');

            SqlConnection sqlConnection = new SqlConnection($"server = {vs[1]};Trusted_connection={vs[3]};DataBase={vs[5]};User={vs[7]};PWD={vs[9]}");
            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);

            return data;
        }
    }
}
