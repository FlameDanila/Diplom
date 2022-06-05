using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Changes.xaml
    /// </summary>
    public partial class Changes : Window
    {
        public Changes()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            int f = Convert.ToInt32(App.userId);
            var OwnersLoginList = App.db.Users.Where(n => n.Id == f).ToList();
            foreach (var a in OwnersLoginList)
            {
                string[] nameUser = a.Name.Split(' ');
                LastNameBox.Text = nameUser[0];
                FirstNameBox.Text = nameUser[1];
                ProfessionBox.Text = a.Profession;
                EducationBox.Text = a.Eduacation;
                AgeText.Text = a.Age.ToString();
            }
        }

        private void saveChangesClick(object sender, RoutedEventArgs e)
        {
            if (oldPassText.Text == "")
            {
                MessageBox.Show("Чтобы сохранить изменения введите старый пароль");
            }
            else
            {
                if (FirstNameBox.Text == "" || LastNameBox.Text == "")
                { MessageBox.Show("Обязательно заполните оба поля имени!"); }
                else
                {
                    if (PasswordBox.Text != RepeatPassBox.Text)
                    { MessageBox.Show("Пароли должны совпадать!"); }
                    else
                    {
                        int f = Convert.ToInt32(App.userId);
                        var stuff = App.db.Users.Where(n => n.Id == f).FirstOrDefault();

                        stuff.Name = LastNameBox.Text.Replace(" ", "") + " " + FirstNameBox.Text.Replace(" ", "");
                        stuff.Eduacation = EducationBox.Text;
                        stuff.Profession = ProfessionBox.Text;
                        stuff.Age = Convert.ToInt32(AgeText.Text.Replace(" ", ""));
                        if (PasswordBox.Text != "")
                        {
                            stuff.Password = PasswordBox.Text.Replace(" ", "");
                        }
                        else
                        {
                            stuff.Password = stuff.Password;
                        }

                        App.db.SaveChanges();
                        MessageBox.Show("Профиль изменён");
                    }
                }
            }
        }
        public new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void DigitsTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }
    }
}
