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
    }
}
