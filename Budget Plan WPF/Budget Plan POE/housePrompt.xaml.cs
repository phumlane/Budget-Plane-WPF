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
    /// Interaction logic for housePrompt.xaml
    /// </summary>
    public partial class housePrompt : Window
    {
        string num;
        //  Expense exp = new Expense();
        Expenses exp = new Expenses();
        ListExpense list = new ListExpense();
        MainWindow main = new MainWindow();
        public housePrompt()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {

           //closing and open a new form
            Buying buy = new Buying();
            buy.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {

            //closing and open a new form
            Renting rent = new Renting();
            rent.Show();
            this.Hide();
        }
    }
}
