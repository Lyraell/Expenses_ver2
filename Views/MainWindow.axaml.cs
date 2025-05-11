using Avalonia.Controls;
using Expenses.ViewModels;

namespace Expenses.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel();
            InitializeComponent();
        }
    }
}