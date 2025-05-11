using ReactiveUI;
using System.Reactive;

namespace Expenses.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit, Unit> ShowAddExpenseCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowExpenseListCommand { get; }

        private ViewModelBase _content = new AddExpenseViewModel();
        public ViewModelBase Content
        {
            get => _content;
            set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public MainWindowViewModel()
        {
            ShowAddExpenseCommand = ReactiveCommand.Create(ShowAddExpense);
            ShowExpenseListCommand = ReactiveCommand.Create(ShowExpenseList);

            Content = new AddExpenseViewModel(); // Set default view
        }

        private void ShowAddExpense()
        {
            Content = new AddExpenseViewModel();
        }

        private void ShowExpenseList()
        {
            Content = new ExpenseListViewModel();
        }
    }
}
