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

            }
            if (amount == 0)
            {
                Console.WriteLine($"No item found with {category} Category");
            }
            Console.WriteLine($"Total expense in {category} Category : {amount}");
            return amount;
        }

        public List<Expense> GetAllExpense()
        {
            return new List<Expense>(ExpensesList);
        }


    }
}
