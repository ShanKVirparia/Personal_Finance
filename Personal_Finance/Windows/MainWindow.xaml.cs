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
using Personal_Finance.Classes;
using Personal_Finance.Tables;
using Personal_Finance.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Personal_Finance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User loginUsers = new User();
        public static string copyEmail;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void AddNewUser_Click(object sender, RoutedEventArgs e)
        {
            Window1 gotoregistration = new Window1();
            gotoregistration.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=SHAN;Database=PersonalFinance;Trusted_Connection=True;");
            connection.Open();

            string verifyUser = @"SELECT * FROM tblUsers WHERE (EmailAddress = @_EmailAddress) AND (Password = @_Password)";
            SqlCommand cmd = new SqlCommand(verifyUser, connection);
            cmd.Parameters.AddWithValue("@_EmailAddress", _EmailAddress.Text);
            cmd.Parameters.AddWithValue("@_Password", _Password.Text);

            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                copyEmail = _EmailAddress.Text;
                Windows.Window2 goToFinance = new Windows.Window2();
                goToFinance.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }

        }

    }
}
