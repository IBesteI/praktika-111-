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

namespace WpfApp5
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string password = passwordtb.Password;

            if (password.Equals("admin"))
            {
                string login = logintb.Text;

                if (login.Equals("admin"))
                {
                    {
                        var window = new MainWindow();


                        MessageBox.Show("Вы админ      " +
                            "Ваш пароль: admin  " +
                            "Ваш логин: admin");
                    }


                }
            }
            password = passwordtb.Password;
            if (password.Equals("user"))
            {
                string login = logintb.Text;

                if (login.Equals("user"))
                {
                    var window = new MainWindow();

                    MessageBox.Show("Вы пользователь      " +
                        "Ваш пароль: user  " +
                        "Ваш логин: user");
                }
            }
            password = passwordtb.Password;
            if (password.Equals("teacher"))
            {
                string login = logintb.Text;

                if (login.Equals("teacher"))
                {
                    var window = new MainWindow();

                    MessageBox.Show("Вы учитель      " +
                        "Ваш пароль: teacher  " +
                        "Ваш логин: teacher");
                }

               


            }
        }
    }
}

            
        
    


