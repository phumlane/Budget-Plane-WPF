using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Budget_Plan_POE
{
    /// <summary>
    /// Interaction logic for Saving.xaml
    /// </summary>
    public partial class Saving : Window
    {
        string reason;
        double amount, interest;
        int years;
        public Saving()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //checking if the text box is null 
            if (string.IsNullOrEmpty(txtReason.Text) || string.IsNullOrEmpty(txtAmount.Text)
                || string.IsNullOrEmpty(txtInterest.Text) || string.IsNullOrEmpty(txtYears.Text))
            {
                MessageBox.Show("There's an empty TextFeild");
            }
            else
            {
                //storing the valraibles
                reason = txtReason.Text;
                amount = double.Parse(txtAmount.Text);
                interest = double.Parse(txtInterest.Text);
                years = int.Parse(txtYears.Text);

                double months = years * 12;
                double interestRate = interest / 100;
                //calculating monthly payments
                double payment = amount * (1 + interestRate * years);
                double monthlypayments = payment / months;

                MessageBox.Show("Reason for saving: "+ reason+ "\nThe Amount you need tosave every month is: R" + monthlypayments);
                MessageBox.Show("Thank you for paarticipating!!!!!!!!");

                this.Close();



            }
        }
    }
}
