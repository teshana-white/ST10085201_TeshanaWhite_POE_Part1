using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    class income_expenditure : Expenses
    {
        //variables for income and and accomadtion expenses
        private static double dblgrossIncome = 0.0;
        private static double dbltaxDeductions = 0.0;
        private static double dblpurchasePrice = 0.0;
        private static double dbltotalDeposit = 0.0;
        private static double dblinterestRate = 0.0;
        private static double dblnumberOfMonths = 0.0;
        private static double dblMonthlyRent = 0.0;
        private static int iCounter = 0;
        private static int iSizeArray = 0;

        //getters and setters to get and set user input from the above variables
        public void setGrossIncome(double GrossIncome)
        {
            dblgrossIncome = GrossIncome;
        }
        public double getGrossIncome()
        {
            return dblgrossIncome;
        }
        public void setMonthlyTaxDeducted(double MonthlyTaxDeducted)
        {
            dbltaxDeductions = MonthlyTaxDeducted;
        }
        public double getMonthlyTaxDeducted()
        {
            return dbltaxDeductions;
        }
        public void setPurchasePrice(double PurchasePrice)
        {
            dblpurchasePrice = PurchasePrice;
        }
        public double getPurchasePrice()
        {
            return dblpurchasePrice;
        }
        public void setTotalDeposit(double TotalDeposit)
        {
            dbltotalDeposit = TotalDeposit;
        }
        public double getTotalDeposit()
        {
            return dbltotalDeposit;
        }
        public void setInterestRate(double InterestRate)
        {
            dblinterestRate = InterestRate;
        }
        public double getInterestRate()
        {
            return dblinterestRate;
        }
        public void setNumberOfMonths(double NumberOfMonths)
        {
            dblnumberOfMonths = NumberOfMonths;
        }
        public double getNumberOfMonths()
        {
            return dblnumberOfMonths;
        }

        public void setMonthlyRent(double MonthlyRent)
        {
            dblMonthlyRent = MonthlyRent;
        }
        public double getMonthlyRent()
        {
            return dblMonthlyRent;
        }

        //array variables for expenses
        private static double[] Groceries;
        private static double[] Utilities;
        private static double[] TravelCost;
        private static double[] Cellphone;
        private static double[] OtherExpenses;

        //setting the above variables into arrays
        public override void setArray(int num)
        {
            Groceries = new double[num];
            Utilities = new double[num];
            TravelCost = new double[num];
            Cellphone = new double[num];
            OtherExpenses = new double[num];
            iSizeArray = 1;
        }

        //returns the array
        public int size()
        {
            return iSizeArray;
        }

        //the addtoArray method adds the variables to an array 
        public bool addToArray(double dblGroceries, double dblUtilities, double dblTravelCost, double dblPhone, double dblOther)
        {
            if (iCounter < iSizeArray)
            {
                Groceries[iCounter] = dblGroceries;
                Utilities[iCounter] = dblUtilities;
                TravelCost[iCounter] = dblTravelCost;
                Cellphone[iCounter] = dblPhone;
                OtherExpenses[iCounter] = dblOther;
                iCounter++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double getGroceries(int x)
        {
            return Groceries[x];
        }
        public override double getUtilities(int x)
        {
            return Utilities[x];
        }
        public override double getTravelCost(int x)
        {
            return TravelCost[x];
        }
        public override double getCellphone(int x)
        {
            return Cellphone[x];
        }
        public override double getOtherExpenses(int x)
        {
            return OtherExpenses[x];
        }
    }
}
