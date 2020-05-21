using Personal_Finance.Classes;
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
using Personal_Finance.Windows;
using System.Data.SqlClient;
using System.Data;

namespace Personal_Finance.Windows
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        
        public Window2()
        {
            InitializeComponent();

        }

        private void SurveyButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.Window3 goToSurvey = new Windows.Window3();
            goToSurvey.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow logout = new MainWindow();
            logout.Show();
            this.Close();
        }

        public void totalAsset_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(retirementAccount.Text) && !string.IsNullOrEmpty(bankAccount.Text) && !string.IsNullOrEmpty(homeValue.Text) && !string.IsNullOrEmpty(otherAsset.Text))
            {
                totalAsset.Text = ((Convert.ToInt32(retirementAccount.Text)) + (Convert.ToInt32(bankAccount.Text)) + (Convert.ToInt32(homeValue.Text)) + (Convert.ToInt32(otherAsset.Text))).ToString();
            }
        }

        private void retirementAccount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(retirementAccount.Text) && !string.IsNullOrEmpty(bankAccount.Text) && !string.IsNullOrEmpty(homeValue.Text) && !string.IsNullOrEmpty(otherAsset.Text))
            {
                totalAsset.Text = ((Convert.ToInt32(retirementAccount.Text)) + (Convert.ToInt32(bankAccount.Text)) + (Convert.ToInt32(homeValue.Text)) + (Convert.ToInt32(otherAsset.Text))).ToString();
            }
        }

        private void bankAccount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(retirementAccount.Text) && !string.IsNullOrEmpty(bankAccount.Text) && !string.IsNullOrEmpty(homeValue.Text) && !string.IsNullOrEmpty(otherAsset.Text))
            {
                totalAsset.Text = ((Convert.ToInt32(retirementAccount.Text)) + (Convert.ToInt32(bankAccount.Text)) + (Convert.ToInt32(homeValue.Text)) + (Convert.ToInt32(otherAsset.Text))).ToString();
            }
        }

        private void homeValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(retirementAccount.Text) && !string.IsNullOrEmpty(bankAccount.Text) && !string.IsNullOrEmpty(homeValue.Text) && !string.IsNullOrEmpty(otherAsset.Text))
            {
                totalAsset.Text = ((Convert.ToInt32(retirementAccount.Text)) + (Convert.ToInt32(bankAccount.Text)) + (Convert.ToInt32(homeValue.Text)) + (Convert.ToInt32(otherAsset.Text))).ToString();
            }
        }

        private void otherAsset_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(retirementAccount.Text) && !string.IsNullOrEmpty(bankAccount.Text) && !string.IsNullOrEmpty(homeValue.Text) && !string.IsNullOrEmpty(otherAsset.Text))
            {
                totalAsset.Text = ((Convert.ToInt32(retirementAccount.Text)) + (Convert.ToInt32(bankAccount.Text)) + (Convert.ToInt32(homeValue.Text)) + (Convert.ToInt32(otherAsset.Text))).ToString();
            }
        }

        public void totalDebt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(carLoan.Text) && !string.IsNullOrEmpty(mortgage.Text) && !string.IsNullOrEmpty(studentLoans.Text) && !string.IsNullOrEmpty(otherDebt.Text))
            {
                totalDebt.Text = ((Convert.ToInt32(carLoan.Text)) + (Convert.ToInt32(mortgage.Text)) + (Convert.ToInt32(studentLoans.Text)) + (Convert.ToInt32(otherDebt.Text))).ToString();
            }
        }

        private void carLoan_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(carLoan.Text) && !string.IsNullOrEmpty(mortgage.Text) && !string.IsNullOrEmpty(studentLoans.Text) && !string.IsNullOrEmpty(otherDebt.Text))
            {
                totalDebt.Text = ((Convert.ToInt32(carLoan.Text)) + (Convert.ToInt32(mortgage.Text)) + (Convert.ToInt32(studentLoans.Text)) + (Convert.ToInt32(otherDebt.Text))).ToString();
            }
        }

        private void mortgage_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(carLoan.Text) && !string.IsNullOrEmpty(mortgage.Text) && !string.IsNullOrEmpty(studentLoans.Text) && !string.IsNullOrEmpty(otherDebt.Text))
            {
                totalDebt.Text = ((Convert.ToInt32(carLoan.Text)) + (Convert.ToInt32(mortgage.Text)) + (Convert.ToInt32(studentLoans.Text)) + (Convert.ToInt32(otherDebt.Text))).ToString();
            }
        }

        private void studentLoans_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(carLoan.Text) && !string.IsNullOrEmpty(mortgage.Text) && !string.IsNullOrEmpty(studentLoans.Text) && !string.IsNullOrEmpty(otherDebt.Text))
            {
                totalDebt.Text = ((Convert.ToInt32(carLoan.Text)) + (Convert.ToInt32(mortgage.Text)) + (Convert.ToInt32(studentLoans.Text)) + (Convert.ToInt32(otherDebt.Text))).ToString();
            }
        }

        private void otherDebt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(carLoan.Text) && !string.IsNullOrEmpty(mortgage.Text) && !string.IsNullOrEmpty(studentLoans.Text) && !string.IsNullOrEmpty(otherDebt.Text))
            {
                totalDebt.Text = ((Convert.ToInt32(carLoan.Text)) + (Convert.ToInt32(mortgage.Text)) + (Convert.ToInt32(studentLoans.Text)) + (Convert.ToInt32(otherDebt.Text))).ToString();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
            FinancePage fp = new FinancePage();

            fp.SaveNetWorth(emailaddress.Text,totalAsset.Text, totalDebt.Text, netWorth.Text);

            emailaddress.Text = "";
            totalAsset.Text = "";
            totalDebt.Text = "";
            netWorth.Text = "";

            if (!string.IsNullOrEmpty(emailaddress.Text) || string.IsNullOrEmpty(emailaddress.Text))
            {
                emailaddress.Text = "Email: " + MainWindow.copyEmail;
            }

            MessageBox.Show("Please Refresh History.");

            retirementAccount.Clear();
            bankAccount.Clear();
            homeValue.Clear();
            otherAsset.Clear();
            totalAsset.Clear();
            carLoan.Clear();
            mortgage.Clear();
            studentLoans.Clear();
            otherDebt.Clear();
            totalDebt.Clear();
            netAsset.Clear();
            netDebt.Clear();
            netWorth.Clear();
        }

        private void netAsset_MouseEnter(object sender, MouseEventArgs e)
        {
            netAsset.Text = string.Copy(totalAsset.Text);
            
        }

        private void netDebt_MouseEnter(object sender, MouseEventArgs e)
        {
            
            netDebt.Text = string.Copy(totalDebt.Text);

        }


        

        private void emailaddress_Loaded(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(emailaddress.Text) || string.IsNullOrEmpty(emailaddress.Text))
            {
                emailaddress.Text = "Email: " + MainWindow.copyEmail;
            }
            
        }

        private void netWorthHistory_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=SHAN;Database=PersonalFinance;Trusted_Connection=True;");
            con.Open();
            string updateNetWorth = (@"Select NetWorth, Date From dbo.tblFinance Where (EmailAddress = '" + emailaddress.Text + "')");
            SqlCommand cmd = new SqlCommand(updateNetWorth, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            netWorthHistory.ItemsSource = dt.DefaultView;
            
            con.Close();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=SHAN;Database=PersonalFinance;Trusted_Connection=True;");
            con.Open();
            string updateNetWorth = (@"Select NetWorth, Date From dbo.tblFinance Where (EmailAddress = '" + emailaddress.Text + "')");
            SqlCommand cmd = new SqlCommand(updateNetWorth, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            netWorthHistory.ItemsSource = dt.DefaultView;
            
            con.Close();
        }

        private void netWorth_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(netAsset.Text) && !string.IsNullOrEmpty(netDebt.Text) || !string.IsNullOrEmpty(netWorth.Text))
            {
                netWorth.Text = Convert.ToString((Convert.ToInt32(netAsset.Text)) - (Convert.ToInt32(netDebt.Text)));
            }
        }
    }
    

}
