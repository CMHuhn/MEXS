using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Text;
using System.Threading.Tasks;

namespace MEXS
{
    class DataFeedAdapter
    {
        int sourceInt, targetInt;
        decimal rate;
        DataFeed df = new DataFeed();

        public decimal getRate(string source, string target)
        {
            source = source.ToUpper();
            target = target.ToUpper();

            switch (source)
            {
                case "USD":
                    sourceInt = 0;
                    break;
                case "EUR":
                    sourceInt = 1;
                    break;
                case "JPY":
                    sourceInt = 2;
                    break;
                case "GBP":
                    sourceInt = 3;
                    break;
                case "CHF":
                    sourceInt = 4;
                    break;
                default:
                    MessageBox.Show("Invalid currency code input.");
                    return 0;
            }

            switch (target)
            {
                case "USD":
                    targetInt = 0;
                    break;
                case "EUR":
                    targetInt = 1;
                    break;
                case "JPY":
                    targetInt = 2;
                    break;
                case "GBP":
                    targetInt = 3;
                    break;
                case "CHF":
                    targetInt = 4;
                    break;
                default:
                    MessageBox.Show("Invalid currency code input.");
                    return 0;
            }
            
            return df.feedRate(sourceInt, targetInt);
        }

        public decimal lastKnownRate(string source, string target)
        {
            return 1.1M;
        }

    }
}
