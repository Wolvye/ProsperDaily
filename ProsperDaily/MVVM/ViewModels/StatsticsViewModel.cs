
using PropertyChanged;
using ProsperDaily.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Transaction = ProsperDaily.MVVM.Models.Transaction;

namespace ProsperDaily.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class StatsticsViewModel
    {
        public ObservableCollection<TransactionSummary> Summary {get; set;}
        public ObservableCollection<Transaction> SpendingList {get; set;}

        public void GetTransactionsSummary()
        {
          //  Console.WriteLine(" GetTransactionsSummary wurde aufgerufen");
            var data =
                App.TransactionsRepo.GetItems();
            var result =
                new List<TransactionSummary>();
            var groupedTransactions =
                data.GroupBy(t => t.OperationDate.Date);

         

            foreach ( var group in groupedTransactions)
            {
                var transactionSummery = new TransactionSummary
                {
                    TransactionsDate = group.Key,
                    TransactionsTotal = group.Sum(t => t.IsIncome ? t.Amount: -t.Amount),
                    ShowDate = group.Key.ToString("dd/MM")
                };
                result.Add(transactionSummery);
            }
            result = result.OrderBy(x => x.TransactionsDate).ToList();

            Summary = new ObservableCollection<TransactionSummary>(result);

            var spendingList = data.Where(x => x.IsIncome == false);
            SpendingList = new ObservableCollection<Transaction>(spendingList);
            //Debug.WriteLine($" Summary.Count = {Summary.Count}");
            //foreach (var item in Summary)
            //{
            //    Debug.WriteLine($" {item.ShowDate} → {item.TransactionsTotal}");
            //}
        }


    }
}
