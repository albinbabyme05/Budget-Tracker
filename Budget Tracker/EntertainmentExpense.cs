using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker
{
    public class EntertainmentExpense : Expense
    {
        public EntertainmentExpense(double amount, string category, string date, string description) : base(amount, category, date, description)
        {

        }

        public override void GetExpenceDetails()
        {
            Console.WriteLine($"Food Expense : {GetAmount()} - Category: {GetCategory()} - Date: {GetDate()}");
        }
    }
}

