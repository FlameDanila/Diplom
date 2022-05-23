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
    /// <summary>
    /// Логика взаимодействия для Tickets.xaml
    /// </summary>
    public partial class Tickets : Window
    {
        public Tickets()
        {
            InitializeComponent();

            DataTable data = Select("Select * from dbo.events");

            List<string> name = new List<string>();

            for(int f = 0; f < data.Rows.Count; f++)
            {
                var names = App.db.Events.Select(n => n.Name).ToList();
                name.Add(names[f]);
            }

            List<string> tickets = new List<string>();

            int top = 70;
            int bottom = 18;

            for (int i = 0; i < 2; i++)
            {
                TextBlock text = new TextBlock();
                text.Width = 200;
                text.Height = 30;
                text.Text = name[i];

                list.Children.Add(text);
                //Пока что выводятся только названия эвентов
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

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
