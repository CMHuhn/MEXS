using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MEXS
{
    class UIHandler
    {
        MEXSController controller = new MEXSController();
        decimal targetAmount, rate, commission;

        public void estimate(string sourceDenomination, decimal sourceAmount, string targetDenomination, out decimal estAmount, out decimal estRate, out decimal estCommission)
        {
            controller.getEstimate(sourceDenomination, targetDenomination, sourceAmount, out targetAmount, out rate, out commission);

            estAmount = targetAmount;
            estCommission = commission;
            estRate = rate;
        }

        public void confirm(string sourceDenomination, decimal sourceAmount, string targetDenomination, string name, out decimal estAmount, out decimal estRate, out decimal estCommission, string passportNumber = "", string passportCountry = "")
        {
            controller.confirmTransaction(sourceDenomination, targetDenomination, sourceAmount, name, passportNumber, passportCountry, out targetAmount, out rate, out commission);

            estAmount = targetAmount;
            estCommission = commission;
            estRate = rate;
        }


        public void setCommission(decimal newCommission)
        {
            controller.commission = newCommission;
        }

        public void report()
        {
            MessageBox.Show("Not Implemented");
        }
    }
}
