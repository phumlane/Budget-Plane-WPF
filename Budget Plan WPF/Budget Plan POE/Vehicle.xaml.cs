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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Window
    {
        string model;
        double price, deposite, interest, insurances;
        int years = 5;
        public Vehicle()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //checking if the text box is null 
            if (string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtModel.Text) ||
                string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("Feild is empty");
            }
            else
            {
                //storing the values
                model = txtModel.Text;
                price = double.Parse(txtPrice.Text);
                deposite = double.Parse(txtDepoaite.Text);
                interest = double.Parse(txtInterest.Text);
                insurances = double.Parse(txtInsurance.Text);
                //gettimh expense and storing them in varibles
                Expense expenses = new Expense();
                double income = expenses.GrossMonthlyIncome;
                double tax = expenses.Tax;
                double grocery = expenses.Grocery;
                double waterAndLight = expenses.WaterAndLight;
                double travel = expenses.Travel;
                double other = expenses.Other;
                //converting 
                double months = years * 12;
                double rate = interest / 100;

                //sub deposite form origanl price
                double principle = price - deposite;
                //calculating monthly payments
                double payments = (principle * (1 + rate * years));
                double monthlyPayments = payments / months;
                double pay = monthlyPayments + insurances;
                //addimg and subtracting expenses
                double availableAmount = income - tax - grocery - waterAndLight - travel - other - monthlyPayments;
                double sum = tax + grocery - waterAndLight + travel + other + monthlyPayments;
                //displaying the values
                MessageBox.Show("the model of the car is: "+ model +"monthly payments for the car is: R" + monthlyPayments + "\nMonthly payments including insurence is: R" + pay +"\nAvailable Amount is: R " + availableAmount + "\ntotal" +
                            " Amount of expenses is: R " + sum);
                this.Hide();
                //opening a new form
                Saving saving = new Saving();
                saving.Show();
            }
        }
    }
}
