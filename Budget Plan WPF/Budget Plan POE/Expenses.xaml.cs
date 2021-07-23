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
    /// Interaction logic for Expenses.xaml
    /// </summary>
    public partial class Expenses : Window
    {
        Expense exp = new Expense();

      


        public Expenses()
        {
            InitializeComponent();
           
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Buying buy = new Buying();
            //cheching if the textbox is null
            if(string.IsNullOrEmpty(txtIncome.Text) || string.IsNullOrEmpty(txtGrocery.Text) || 
                string.IsNullOrEmpty(txtTax.Text) || string.IsNullOrEmpty(txtWaterAndLight.Text) || string.IsNullOrEmpty(txtTravel.Text) || string.IsNullOrEmpty(txtPhone.Text)
                || string.IsNullOrEmpty(txtOther.Text))
            {
                MessageBox.Show("Feild is Empty");
            }
         
            else
            {
                 //storing the user input to varisbles
                exp.GrossMonthlyIncome = double.Parse(txtIncome.Text);
                exp.Tax = double.Parse(txtTax.Text);
                exp.Grocery = double.Parse(txtGrocery.Text);
                exp.WaterAndLight = double.Parse(txtWaterAndLight.Text);
                exp.Travel = double.Parse(txtTravel.Text);
                exp.Phones = double.Parse(txtPhone.Text);
                exp.Other = double.Parse(txtOther.Text);

                List<double> expenseList = new List<double>();
                expenseList.Add(exp.GrossMonthlyIncome);

                //storing the values to list
                List<ListExpense> list = new List<ListExpense>();
                list.Add(new ListExpense());
                list[0].expense= exp.Tax;
                list.Add(new ListExpense());
                list[1].expense = exp.Grocery;
                list.Add(new ListExpense());
                list[2].expense = exp.WaterAndLight;
                list.Add(new ListExpense());
                list[3].expense = exp.Travel;
                list.Add(new ListExpense());
                list[4].expense = exp.Phones;
                list.Add(new ListExpense());
                list[5].expense = exp.Other;

                //  double expens = list[0].expense - list[1].expense - list[2].expense - list[2].expense - list[4].expense - list[5].expense;
                //  double sum = list[0].expense + list[1].expense + list[2].expense + list[2].expense + list[4].expense + list[5].expense;

               
                this.Hide();
                housePrompt prompt =new housePrompt();
                prompt.Show();
                


            }

            
            

          
            
        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
