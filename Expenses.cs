using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    public abstract class Expenses
    {
        public abstract void setArray(int num);
        public abstract double getCellphone(int x);
        public abstract double getGroceries(int x);
        public abstract double getOtherExpenses(int x);
        public abstract double getTravelCost(int x);
        public abstract double getUtilities(int x);
        
    }
}
