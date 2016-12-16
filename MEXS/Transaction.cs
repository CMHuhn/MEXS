using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEXS
{
    class Transaction
    {
        private decimal _sourceAmount, _targetAmount, _currentRate;
        private string _sourceCurrency, _targetCurrency, _customerName, _passportNumber, _passportCountry;
        private DateTime _currentDateTime = DateTime.Now;

        public Transaction(decimal inSourceAmount, decimal inTargetAmount, decimal inCurrentRate, string inSourceCurrency, string inTargetCurrency, string inCustomerName, string inPassportNumber = "n/a", string inPassportCountry = "n/a")
        {
            _sourceAmount = inSourceAmount;
            _sourceCurrency = inSourceCurrency;
            _currentRate = inCurrentRate;
            _targetAmount = inTargetAmount;
            _targetCurrency = inTargetCurrency;
            _customerName = inCustomerName;
            _passportNumber = inPassportNumber;
            _passportCountry = inPassportCountry;
        }

        public decimal sourceAmount
        {
            get { return this._sourceAmount; }
            set { this._sourceAmount = value; }
        }

        public decimal targetAmount
        {
            get { return this._targetAmount; }
            set { this._targetAmount = value; }
        }

        public decimal currentRate
        {
            get { return this._currentRate; }
            set { this._currentRate = value; }
        }

        public string sourceCurrency
        {
            get { return this._sourceCurrency; }
            set { this._sourceCurrency = value; }
        }

        public string  targetCurrency
        {
            get { return this._targetCurrency; }
            set { this._targetCurrency = value; }
        }

        public string customerName
        {
            get { return this._customerName; }
            set { this._customerName = value; }
        }

        public string passportNumber
        {
            get { return this._passportNumber; }
            set { this._passportNumber = value; }
        }

        public string passportCountry
        {
            get { return this._passportCountry; }
            set { this._passportCountry = value; }
        }

        private DateTime currentDateTime
        {
            get { return _currentDateTime; }
        }
    }
}
