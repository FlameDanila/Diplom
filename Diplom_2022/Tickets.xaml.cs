using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
    public partial class Tickets : Window
    {
        public int counter = 0;
        public Tickets()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            list.Children.Clear();
            DataTable data = new DataTable();

            if (counter == 0)
            {
                data = Select("Select * from events");
            }
            else 
            {
                data = Select($"Select * from events where date = '{datePicker.Text}'");
            }
            List<string> name = new List<string>();
            List<string> age = new List<string>();
            List<string> cost = new List<string>();
            List<string> date = new List<string>();
            List<string> type = new List<string>();
            List<string> time = new List<string>();
            List<string> ticket = new List<string>();
            List<string> venue = new List<string>();
            List<string> id = new List<string>();

            for (int f = 0; f < data.Rows.Count; f++)
            {
                var names = App.db.Events.Select(n => n.Name).ToList();
                name.Add(names[f]);
                var ages = App.db.Events.Select(n => n.Age).ToList();
                age.Add(ages[f].ToString());
                var costs = App.db.Events.Select(n => n.Cost).ToList();
                cost.Add(costs[f].ToString());
                var dates = App.db.Events.Select(n => n.Date).ToList();
                date.Add(dates[f].ToString());
                var times = App.db.Events.Select(n => n.Time).ToList();
                time.Add(times[f].ToString());
                var types = App.db.Events.Select(n => n.TypeId).ToList();
                type.Add(types[f].ToString());
                var ticketsGain = App.db.Events.Select(n => n.GainTicketsCount).ToList();
                ticket.Add(ticketsGain[f].ToString());
                var venues = App.db.Events.Select(n => n.VenueId).ToList();
                venue.Add(venues[f].ToString());
                var ids = App.db.Events.Select(n => n.Id).ToList();
                id.Add(ids[f].ToString());
            }

            int top = 20;
            int bottom = 2;

            for (int g = 0; g < data.Rows.Count; g++)
            {
                StackPanel grid = new StackPanel();
                grid.Orientation = Orientation.Horizontal;
                grid.Height = 50;
                grid.PreviewMouseLeftButtonDown += buy;
                grid.Name = "s" + id[g];

                TextBlock nameText = new TextBlock();
                nameText.Height = 80;
                nameText.Width = 260;
                nameText.Text = name[g];
                nameText.HorizontalAlignment = HorizontalAlignment.Left;
                nameText.VerticalAlignment = VerticalAlignment.Top;
                nameText.FontSize = 23;
                nameText.Margin = new Thickness(top, bottom, 0, 0);
                nameText.ToolTip = name[g];

                TextBlock ageText = new TextBlock();
                ageText.Height = 50;
                ageText.Width = 45;
                ageText.Text = age[g];
                ageText.HorizontalAlignment = HorizontalAlignment.Left;
                ageText.VerticalAlignment = VerticalAlignment.Top;
                ageText.FontSize = 23;
                ageText.Margin = new Thickness(top, bottom, 0, 0);

                TextBlock costText = new TextBlock();
                costText.Height = 50;
                costText.Width = 60;
                costText.Text = cost[g];
                costText.HorizontalAlignment = HorizontalAlignment.Left;
                costText.VerticalAlignment = VerticalAlignment.Top;
                costText.FontSize = 23;
                costText.Margin = new Thickness(top, bottom, 0, 0);

                TextBlock timeText = new TextBlock();
                timeText.Height = 50;
                timeText.Width = 56;
                timeText.Text = time[g];
                timeText.HorizontalAlignment = HorizontalAlignment.Left;
                timeText.VerticalAlignment = VerticalAlignment.Top;
                timeText.FontSize = 23;
                timeText.Margin = new Thickness(top, bottom, 0, 0);

                TextBlock dateText = new TextBlock();
                dateText.Height = 50;
                dateText.Width = 112;
                dateText.Text = date[g];
                dateText.HorizontalAlignment = HorizontalAlignment.Left;
                dateText.VerticalAlignment = VerticalAlignment.Top;
                dateText.FontSize = 23;
                dateText.Margin = new Thickness(top, bottom, 0, 0);

                DataTable selectNameFromId = Select($"select Name from dbo.eventType where Id = {type[g]}");
                string nameFromId = selectNameFromId.Rows[0][0].ToString();

                TextBlock typeText = new TextBlock();
                typeText.Height = 50;
                typeText.Width = 130;
                typeText.Text = nameFromId;
                typeText.HorizontalAlignment = HorizontalAlignment.Left;
                typeText.VerticalAlignment = VerticalAlignment.Top;
                typeText.FontSize = 23;
                typeText.Margin = new Thickness(top, bottom, 0, 0);
                typeText.ToolTip = nameFromId;

                TextBlock ticketsGainText = new TextBlock();
                ticketsGainText.Height = 50;
                ticketsGainText.Width = 60;
                ticketsGainText.Text = ticket[g];
                ticketsGainText.HorizontalAlignment = HorizontalAlignment.Left;
                ticketsGainText.VerticalAlignment = VerticalAlignment.Top;
                ticketsGainText.FontSize = 23;
                ticketsGainText.Margin = new Thickness(top, bottom, 0, 0);
                ticketsGainText.ToolTip = ticket[g];

                DataTable venueNameFromId = Select($"select Name from dbo.venue where VenueTypeId = {venue[g]}");
                string venueName = venueNameFromId.Rows[0][0].ToString();

                TextBlock venueText = new TextBlock();
                venueText.Height = 50;
                venueText.Width = 180;
                venueText.Text = venueName;
                venueText.HorizontalAlignment = HorizontalAlignment.Left;
                venueText.VerticalAlignment = VerticalAlignment.Top;
                venueText.FontSize = 23;
                venueText.Margin = new Thickness(top, bottom, 0, 0);
                venueText.ToolTip = venueName;

                grid.Children.Add(nameText);
                grid.Children.Add(ageText);
                grid.Children.Add(timeText);
                grid.Children.Add(costText);
                grid.Children.Add(dateText);
                grid.Children.Add(typeText);
                grid.Children.Add(ticketsGainText);
                grid.Children.Add(venueText);

                list.Children.Add(grid);
            }
            counter = 0;
        }

        public void buy(object sender, MouseButtonEventArgs e)
        {
            var f = sender as StackPanel;
            DataTable dt = Select($"select name from events where id = '{f.Name.Replace("s","")}'");
            if (MessageBox.Show($"Вы действительно хотите забронировать билет на {dt.Rows[0][0]}?", "Уверены?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No) { }
            else
            {
                DataTable data = Select($"select gainticketscount from events where id = '{f.Name.Replace("s", "")}'");
                if (Convert.ToInt32(data.Rows[0][0]) > 1)
                {
                    DataTable dataTable = Select($"update Events set GainTicketsCount = REPLACE(GainTicketsCount, GainTicketsCount,GainTicketsCount-1) where id = '{f.Name.Replace("s", "")}' " +
                    $"update Events set SoldTicketsCount = REPLACE(SoldTicketsCount, SoldTicketsCount, SoldTicketsCount + 1) where id = '{f.Name.Replace("s", "")}'");
                    MessageBox.Show("Место забронировано!");
                    Update();
                }
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
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

        private void authButton_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            Update();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            counter = 0;
            Update();
        }
    }
}
