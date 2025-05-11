using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Models
{
    public class Expenses
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Type { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }
}
