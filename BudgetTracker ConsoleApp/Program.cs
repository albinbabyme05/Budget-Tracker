using Budget_Tracker;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ExpenseManager manager = new ExpenseManager();

        Console.Write("How many expenses do you want to add? ");
        int expenseCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < expenseCount; i++)
        {
            Console.WriteLine($"\nAdding Expense #{i + 1}");

            Console.Write("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Enter category (travel/food): ");
            string category = Console.ReadLine().ToLower();

            Console.Write("Enter date (dd-mm-yyyy): ");
            string date = Console.ReadLine();

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            // Create specific Expense object based on category
            if (category == "travel")
            {
                TravelExpense travelExpense = new TravelExpense(amount, category, date, description);
                manager.AddExpense(travelExpense);
            }
            else if (category == "food")
            {
                FoodExpense foodExpense = new FoodExpense(amount, category, date, description);
                Budget foodBudget = new Budget(category, 150);
                
                manager.AddExpense(foodExpense);
                manager.SetBudget(foodBudget);
            }
            else
            {
                Console.WriteLine("Unknown category. Skipping this expense.");
            }
        }

        Console.Write("\nEnter category to view total spent (travel/food): ");
        string checkCategory = Console.ReadLine().ToLower();

        manager.GetTotalSpentByCategory(checkCategory);

        Console.WriteLine("Would like to see All expense ? ");
        string choice = Console.ReadLine();
        
        if (choice == "y")
        {
            foreach(var item in manager.GetAllExpense())
            {
                Console.WriteLine($"Caregory {item.GetCategory()} - Amount {item.GetAmount()}");
            }

        }

        Console.WriteLine("================***");

        Console.WriteLine(manager.BudgetStatus("food")); 

        Console.WriteLine("==========***///");
        manager.DisplayBudgetSummary();

                

        
    }
}
