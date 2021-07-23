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
    /// Interaction logic for VehiclePrompt.xaml
    /// </summary>
    public partial class VehiclePrompt : Window
    {
        public VehiclePrompt()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            Vehicle car = new Vehicle();
            car.Show();
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            Saving saving = new Saving();
            saving.Show();
        }
    }
}
