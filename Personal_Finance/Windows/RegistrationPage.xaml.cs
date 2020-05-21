using Personal_Finance.Classes;
using Personal_Finance.Tables;
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

namespace Personal_Finance
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        User users = new User();

        public Window1()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            db.AddNewUser(firstName.Text, lastName.Text, emailAddress.Text, password.Text);

            firstName.Text = "";
            lastName.Text = "";
            emailAddress.Text = "";
            password.Text = "";

            MessageBox.Show("Thank you for Registering!");

            MainWindow goToLogin = new MainWindow();
            goToLogin.Show();
            this.Close();

        }

        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (firstName.Text.Length > 30)
            {
                MessageBox.Show("First name is to long. Must be less than 30 characters.");
            }
        }

        private void lastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lastName.Text.Length > 30)
            {
                MessageBox.Show("Last name is to long. Must be less than 30 characters.");
            }
        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (password.Text.Length > 10)
            {
                MessageBox.Show("Password is to Short!");
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow backtologin = new MainWindow();
            backtologin.Show();
            this.Close();
        }

    }
}
