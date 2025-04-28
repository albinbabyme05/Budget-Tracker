using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker
{
    public  class Budget
    {
        private double LimitAmount;
        private string Category;

        public Budget(string category, double limitAmount)
        {
            Category = category;
            LimitAmount = limitAmount;
        }

        public string GetBudgetCategory() => Category;
        public double GetLimitAmount() => LimitAmount;

        public void SetBudgetCategory(string category) { Category = category; }
        public void SetLimit(double limit) { LimitAmount = limit; }

        public bool IswithinBudget(double totalSpent)
        {
            if(LimitAmount >= totalSpent)
            {
                //Console.WriteLine("Expense within the limit");
                return true;
            }
            else
            {
                //Console.WriteLine("Expense is over the Limit");
                return false;
            }
        }

        public double RemainingAmount(double totalSpent)
        {
            
            if(LimitAmount >= totalSpent)
            {
                return LimitAmount - totalSpent; 
            }
            else
            {
                return LimitAmount - totalSpent;
            }
        }
    }
}
