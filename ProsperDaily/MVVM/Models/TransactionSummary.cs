using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsperDaily.MVVM.Models
{
    public class TransactionSummary
    {
        public DateTime TransactionsDate {  get; set; }

        public string ShowDate { get; set; }

        public decimal TransactionsTotal { get; set; }

    }
}
