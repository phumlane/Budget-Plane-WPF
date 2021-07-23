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
    /// Interaction logic for Renting.xaml
    /// </summary>
    public partial class Renting : Window
    {
        double rent;
        public Renting()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //getting the expenses and storing them in local varaibles
            Expense expenses = new Expense();
            double income = expenses.GrossMonthlyIncome;
            double tax = expenses.Tax;
            double grocery = expenses.Grocery;
            double waterAndLight = expenses.WaterAndLight;
            double travel = expenses.Travel;
            double other = expenses.Other;


            //getting the rent value
            rent = double.Parse(txtRent.Text);
            // adding and subtracting the expenses
            double availableAmount = income - tax - grocery - waterAndLight - travel - other - rent;
            double sum = tax + grocery - waterAndLight + travel + other + rent;
            MessageBox.Show("The Monthly Rent is: R" + rent + "\nAvailable Amount is: R " + availableAmount + "\ntotal" +
                            " Amount of expenses is: R " + sum);

            //closing and open a new form
            this.Hide();

            VehiclePrompt car = new VehiclePrompt();
            car.Show();
        }
    }
}
