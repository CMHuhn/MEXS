using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEXS
{
    class TransactionGenerator
    {
        public Transaction addTransaction(decimal sourceAmount, decimal targetAmount, decimal rate, string sourceCurrency, string targetCurrency, string customerName, string passportNumber, string passportCountry)
        {
            Transaction thisTransaction = new Transaction(sourceAmount, targetAmount, rate, sourceCurrency, targetCurrency, customerName, passportNumber, passportCountry);

            return thisTransaction;
        }
    }
}
