using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEXS
{
    class MEXSController
    {
        private string sourceDenomination, targetDenomination, passportNumber, passportCountry, customerName;
        private decimal sourceAmount, targetAmount, _commission = 3M;
        static DataFeedAdapter datafeed = new DataFeedAdapter();
        TransactionDatabase tDatabase = new TransactionDatabase();
        TransactionGenerator tGenerator = new TransactionGenerator();

        public void getEstimate(string source, string target, decimal inAmount, out decimal outAmount, out decimal outRate, out decimal outCommission)
        {
            outRate = datafeed.lastKnownRate(source, target);
            outCommission = _commission;
            outAmount = Decimal.Floor(inAmount * outRate * (100 - _commission)) / 100;
        }

        public void confirmTransaction(string source, string target, decimal inAmount, string name, string number, string country, out decimal outAmount, out decimal outRate, out decimal outCommission)
        {
            outRate = datafeed.getRate(source, target);
            outCommission = _commission;
            outAmount = Decimal.Floor(inAmount * outRate * (100 - _commission)) / 100;

            Transaction thisTransaction = new Transaction(inAmount, outAmount, outRate, source, target, name, number, country);

            tDatabase.addTransaction(thisTransaction);
        }

        public decimal commission
        {
            get { return this._commission; }
            set { this._commission = value; }
        }
    }
}
