using System;
using System.Collections.ObjectModel;

namespace Expenses.ViewModels
{
    public class ExpenseListViewModel : ViewModelBase
    {
        public ObservableCollection<ExpenseItem> Expenses { get; }

        public ExpenseListViewModel()
        {
            // Dummy data - replace with data from database later
            Expenses = new ObservableCollection<ExpenseItem>
            {
            };
        }
    }

    public class ExpenseItem
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Type { get; set; } = string.Empty;
        public decimal Amount { get; set; } 
    }
}
