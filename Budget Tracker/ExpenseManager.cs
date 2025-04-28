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
            //Console.WriteLine($"Total expense in {category} Category : {amount}");
            return amount;
        }

        public List<Expense> GetAllExpense()
        {
            return new List<Expense>(ExpensesList);
        }

        // set budget limit for specific category
        public void SetBudget(Budget buget)
        {
            bool found = false;
            foreach (var item in BudgetsList)
            {
                if (item.GetBudgetCategory()==buget.GetBudgetCategory())
                {
                    item.SetLimit(buget.GetLimitAmount());
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                BudgetsList.Add(buget);
            }
        }

        // checking buget within the limit or not
        public string BudgetStatus(string category)
        {
            foreach (var item in BudgetsList)
            {
                if (item.GetBudgetCategory() == category)
                {
                    bool isInLimit = item.IswithinBudget(GetTotalSpentByCategory(category));
                    if (!isInLimit)
                    {
                        return "Budget out of limit";
                        
                    }
                    else
                    {
                        return "Budget within the limit";
                    }
                }
            }
            return "No budget Found";
        }


        //display all info of Budgets
        public void DisplayBudgetSummary()
        {
            foreach (var item in BudgetsList)
            {
                var totalSpent = GetTotalSpentByCategory(item.GetBudgetCategory());
                var remainingAmount = item.RemainingAmount(GetTotalSpentByCategory(item.GetBudgetCategory()));
                Console.WriteLine($"category: {item.GetBudgetCategory()} -" +
                    $"total spent: {totalSpent} - remaining: {remainingAmount}");
            }
        }

    }
}
