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
    /// Interaction logic for Buying.xaml
    /// </summary>
    public partial class Buying : Window
    {
        public double price, deposite, interest;
        public int months;

        House house = new House();
        public Buying()
        {
            InitializeComponent();
           
        }
       
        private void txtSubmit_Click(object sender, RoutedEventArgs e)
        {
          //checking if the text box is null 
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Enter the purchase price");
            }
            else if (txtDepoate.Text == "")
            {
                MessageBox.Show("Enter the deposite");
            }
            else if (txtInterest.Text == "")
            {
                MessageBox.Show("Enter the interest in percentage");
            }
            else if(txtMonths.Text == "")
            {
                MessageBox.Show("Enter number of months");
            }
            else
            {
                //storing the values to a variable and changing the values to double 
                price = double.Parse(txtPrice.Text);
                deposite = double.Parse(txtDepoate.Text);
                interest = double.Parse(txtInterest.Text);
                months = Int32.Parse(txtMonths.Text);

                //geting the values from another form
                Expense expenses = new Expense();
                double income = expenses.GrossMonthlyIncome;
                double tax =expenses.Tax;
                double grocery = expenses.Grocery;
                double waterAndLight = expenses.WaterAndLight;
                double travel = expenses.Travel;
                double other = expenses.Other;


                //checking if months is between 250 and 360
                if(months >= 250 && months<= 360)
                {
                    //conerting months to years
                    double years = months / 12;
                    
                    //converting interest rate
                    double rate = interest / 100;

                    //calculate monthly payments
                    double principle = price - deposite;
                    double monthlyPayments = (principle * (1 + rate * years));
                    double payments = monthlyPayments / months;

                    house.monthlyPayment = payments;
                    //calculating the third of monthly income
                    double third = income / 3;

                    //sub all the expenses and adding the expenses
                    double availableAmount = income - tax - grocery - waterAndLight - travel - other - house.monthlyPayment;
                    double sum = tax + grocery - waterAndLight + travel + other + payments;

                    //checking if the third is greatter than income
                    if(income > third)
                    {
                        MessageBox.Show("you don not qualify for the home loan");
                    }
                    else
                    //displaying the output
                    {
                        MessageBox.Show("Monthly payments for the house is: R" + house.monthlyPayment + "\nAvailable Amount is: R " + availableAmount + "\ntotal" +
                            " Amount of expenses is: R " + sum);
                    }
                   // MessageBox.Show("Monthly payments for the house is: R" + house.monthlyPayment + "\n");


                    //closing the form
                    this.Hide();
                    VehiclePrompt car = new VehiclePrompt();
                    car.Show();
                }
                else
                {
                    MessageBox.Show("Number of months must be between 250 and 360");
                }

            }
        }
    }
}
