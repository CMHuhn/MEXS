using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace MEXS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UIHandler handler = new UIHandler();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void estimateClick(object sender, RoutedEventArgs e)
        {
            decimal sourceAmount, targetAmount, rate, commission;

            if (sourceDenominationBox.Text.Equals(""))
            {
                MessageBox.Show("Please enter a source currency denomination.");
            }
            else if (!Decimal.TryParse(sourceAmountBox.Text, out sourceAmount))
            {
                MessageBox.Show("Invalid Entry in the 'Source Currency Amount' field.");
            }
            else if (targetDenominationBox.Text.Equals(""))
            {
                MessageBox.Show("Please enter a target currency denomination.");
            }
            else
            {
                handler.estimate(sourceDenominationBox.Text, sourceAmount, targetDenominationBox.Text, out targetAmount, out rate, out commission);

                targetAmountDataLabel.Content = targetAmount.ToString("f2");
                exchangeRateDataLabel.Content = rate;
                commissionDataLabel.Content = commission.ToString() + '%';
            }

            
        }

        private void confirmClick(object sender, RoutedEventArgs e)
        {
            decimal sourceAmount, targetAmount, rate, commission;

            if (sourceDenominationBox.Text.Equals(""))
            {
                MessageBox.Show("Please enter a source currency denomination.");
            }
            else if (!decimal.TryParse(sourceAmountBox.Text, out sourceAmount))
            {
                MessageBox.Show("Invalid Entry in the 'Source Currency Amount' field.");
            }
            else if (targetDenominationBox.Text.Equals(""))
            {
                MessageBox.Show("Please enter a target currency denomination.");
            }
            else if (customerNameBox.Text.Equals(""))
            {
                MessageBox.Show("Please enter a customer name");
            }
            else if (!passportNumberBox.Text.Equals("") && passportCountryBox.Text.Equals(""))
            {
                MessageBox.Show("If a passport number is entered, then a passport country entry is required.");
            }
            else if (passportNumberBox.Equals(""))
            {
                handler.confirm(sourceDenominationBox.Text, sourceAmount, targetDenominationBox.Text, customerNameBox.Text, out targetAmount, out rate, out commission);

                targetAmountDataLabel.Content = targetAmount.ToString("f2");
                exchangeRateDataLabel.Content = rate;
                commissionDataLabel.Content = commission.ToString() + '%';
            }
            else
            {
                handler.confirm(sourceDenominationBox.Text, sourceAmount, targetDenominationBox.Text, customerNameBox.Text, out targetAmount, out rate, out commission, passportNumberBox.Text, passportCountryBox.Text);

                targetAmountDataLabel.Content = targetAmount.ToString("f2");
                exchangeRateDataLabel.Content = rate;
                commissionDataLabel.Content = commission.ToString()+'%';
            }
                
        }

        private void setCommissionClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void reportClick(object sender, RoutedEventArgs e)
        {
            handler.report();
        }

        private void windowLoad(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
