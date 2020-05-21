using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using Personal_Finance.Classes;

namespace Personal_Finance.Windows
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void yearsBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ageBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ageBox.Text) && !string.IsNullOrEmpty(retireAgeBox.Text))
                yearsBox.Text = (Convert.ToInt32(retireAgeBox.Text) + Convert.ToInt32(ageBox.Text)).ToString();

        }

        private void retireAgeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ageBox.Text) && !string.IsNullOrEmpty(retireAgeBox.Text))
            yearsBox.Text = (Convert.ToInt32(retireAgeBox.Text) - Convert.ToInt32(ageBox.Text)).ToString();
        }

        private void yearsBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(ageBox.Text) && !string.IsNullOrEmpty(retireAgeBox.Text))
            yearsBox.Text = (Convert.ToInt32(retireAgeBox.Text) - Convert.ToInt32(ageBox.Text)).ToString();
        }

        private void savedBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(savedBox.Text) && !string.IsNullOrEmpty(savePerMonth.Text))
            amountBox.Text = (Convert.ToInt32(savedBox.Text) + (Convert.ToInt32(savePerMonth.Text)*12)* Convert.ToInt32(yearsBox)).ToString();
        }

        private void savePerMonth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(savedBox.Text) && !string.IsNullOrEmpty(savePerMonth.Text))
            amountBox.Text = ((Convert.ToInt32(savedBox.Text)) + (Convert.ToInt32(savePerMonth.Text) * 12) * (Convert.ToInt32(yearsBox.Text))).ToString();
        }

        private void amountBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(savedBox.Text) && !string.IsNullOrEmpty(savePerMonth.Text))
            amountBox.Text = "$" + ((Convert.ToInt32(savedBox.Text)) + (Convert.ToInt32(savePerMonth.Text) * 12) * (Convert.ToInt32(yearsBox.Text))).ToString();

        }

        private void riskBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (!string.IsNullOrEmpty(riskBox.Text))
            {
                if (Convert.ToInt32(riskBox.Text) > 0 && Convert.ToInt32(riskBox.Text) <= 4)
                {
                    portfolioBox.Text = "Mutual Funds and Bonds";
                }
                else if (Convert.ToInt32(riskBox.Text) > 4 && Convert.ToInt32(riskBox.Text) < 8)
                {
                    portfolioBox.Text = "Mutual Funds and ETFs";
                }
                else if (Convert.ToInt32(riskBox.Text) > 7 && Convert.ToInt32(riskBox.Text) < 11)
                {
                    portfolioBox.Text = "Stocks and Options";
                }
                else if (Convert.ToInt32(riskBox.Text) <= 11)
                {
                    MessageBox.Show("Please Input a value between 1 and 10");
                }
            }
            
        }

        private void backToFinance_Click(object sender, RoutedEventArgs e)
        {
            Windows.Window2 backToFinance = new Windows.Window2();
            backToFinance.Show();
            this.Close();
        }

        private void saveSurvey_Click(object sender, RoutedEventArgs e)
        {
            Survey ss = new Survey();

            ss.SaveSurvey(ageBox.Text, retireAgeBox.Text, savedBox.Text, savePerMonth.Text, riskBox.Text, yearsBox.Text, amountBox.Text);

            ageBox.Text = "";
            retireAgeBox.Text = "";
            savedBox.Text = "";
            savePerMonth.Text = "";
            riskBox.Text = "";
            yearsBox.Text = "";
            amountBox.Text = "";

            MessageBox.Show("Thank you for taking the survey!");

            Windows.Window2 backToFinance = new Windows.Window2();
            backToFinance.Show();
            this.Close();
        }
    }
    
}
