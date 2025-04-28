using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker
{
    public class ExpenseManager
    {
        private List<Expense> ExpensesList;
        private List<Budget> BudgetsList;

        public ExpenseManager()
        {
            ExpensesList = new List<Expense>();
            BudgetsList = new List<Budget>();
        }

        //add new expense to the list
        public void AddExpense(Expense expense)
        {
            ExpensesList.Add(expense);
        }

        // set budget limit for specific category
        public void AddBudget( Budget budget)
        {
            BudgetsList.Add(budget);
        }

        // calculate total expense in category
        public double GetTotalSpentByCategory(string category)
        {
            double amount = 0;
            foreach (var item in ExpensesList)
            {
                if (item.GetCategory() == category)
                {
                    amount += item.GetAmount();
                }
                else
                {
                    Console.WriteLine("item not found");
                    return 0;
                }
            }
            return amount;
        }

    }
}
