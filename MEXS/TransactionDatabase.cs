using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEXS
{
    class TransactionDatabase
    {
        List<Transaction> db = new List<Transaction>();

        public void addTransaction(Transaction t)
        {
            db.Add(t);
        }

        public List<Transaction> getTransactions()
        {
            return db;
        }
    }
}
