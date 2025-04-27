using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker
{
    public abstract class Expense
    {
        private double Amount;
        private string Category;
        private string Date;
        private string Description;

        public Expense(double amount, string category,string date, string description)
        {
            Amount = amount;
            Category = category;
            Date = date;
            Description = description;
        }

        public double GetAmount() => Amount;
        public string GetCategory() => Category;
        public string GetDate() => Date;
        public string GetDescription() => Description;

        public abstract void GetExpenceDetails();
    }
}
