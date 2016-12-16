using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEXS
{
    class DataFeed
    {
        decimal[,] rateTable = new decimal[5,5];

        public DataFeed()
        {
            rateTable[0, 0] = 1;
            rateTable[0, 2] = 118.14M;
            rateTable[0, 4] = 1.0283M;
            rateTable[1, 0] = 1.0431M;
            rateTable[1, 1] = 1;
            rateTable[1, 2] = 123.22M;
            rateTable[1, 3] = 0.8401M;
            rateTable[1, 4] = 1.0726M;
            rateTable[2, 2] = 1;
            rateTable[3, 0] = 1.2416M;
            rateTable[3, 3] = 1;
            rateTable[4, 4] = 1;
            rateTable[0, 1] = 1 / rateTable[1, 0];
            rateTable[0, 3] = 1 / rateTable[3, 0];
            rateTable[2, 0] = 1 / rateTable[0, 2];
            rateTable[2, 1] = 1 / rateTable[1, 2];
            rateTable[3, 1] = 1 / rateTable[1, 3];
            rateTable[4, 0] = 1 / rateTable[0, 4];
            rateTable[4, 1] = 1 / rateTable[1, 4];
            rateTable[2, 3] = rateTable[2, 1] * rateTable[1, 3];
            rateTable[2, 4] = rateTable[2, 1] * rateTable[1, 4];
            rateTable[3, 2] = 1 / rateTable[2, 3];
            rateTable[3, 4] = rateTable[1, 4] / rateTable[1, 3];
            rateTable[4, 2] = 1 / rateTable[2, 4];
            rateTable[4, 3] = 1 / rateTable[3, 4];
        }

        public decimal feedRate(int i, int j)
        {
            return rateTable[i, j];
        }
        

    }
}
