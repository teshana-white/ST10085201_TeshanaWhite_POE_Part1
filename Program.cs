using System;

namespace POEPart1
{
    class Program
    {
        static void Main(string[] args)
        { //This section of code is the output, asking the user to input their information
            income_expenditure i = new income_expenditure();
            Console.Clear();
            Console.WriteLine("Please enter your Gross Monthly Income: ");
            i.setGrossIncome(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Please enter the Monthly Tax Deducted: ");
            i.setMonthlyTaxDeducted(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Please enter your monthly expenditure for groceries: ");
            double dblGroceries = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your monthly expenditure for water and lights: ");
            double dblUtilities = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your monthly expenditure for travel costs: ");
            double dblTravelCost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your monthly expenditure for cellphones: ");
            double dblPhone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your monthly expenditure for other expenses: ");
            double dblOther = Convert.ToDouble(Console.ReadLine());

            //This section asks if the user will rent a property, and will be asked to enter the rent
            //amount
            Console.WriteLine("Are you (1) looking to rent a property or (2) buying a property? ");
            String strOption = Console.ReadLine();
            if (strOption.Equals("1"))
            {
                Console.WriteLine("Please enter the monthly rental amount: ");
                i.setMonthlyRent(Convert.ToDouble(Console.ReadLine()));

            }
            else if (strOption.Equals("2"))
            {//This section asks the user too enter information if they are buying a property
                Console.WriteLine("Please enter the purchase price of the property: ");
                i.setPurchasePrice(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Please enter the total deposit: ");
                i.setTotalDeposit(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Please enter the interest rate: ");
                i.setInterestRate(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Please enter the number of months to repay the loan: ");
                i.setNumberOfMonths(Convert.ToDouble(Console.ReadLine()));
            }

            //This section will display the monthly payment if buying a house, whether or not the loan
            //is approved, and what your remanining balance will be
            Console.WriteLine("Monthly Payment: R" + (i.getPurchasePrice() - i.getTotalDeposit()) * (1 + i.getInterestRate() / 100 * i.getNumberOfMonths() / 12) / i.getNumberOfMonths() 
                + i.getMonthlyRent());

            double monthlyPayment = (i.getPurchasePrice() - i.getTotalDeposit()) * (1 + i.getInterestRate() / 100 * i.getNumberOfMonths() / 12) / i.getNumberOfMonths();
            if (monthlyPayment > i.getGrossIncome() / 3)
            {
                Console.WriteLine("Your loan is unlikely to be approved");
            }
            else
            {
                Console.WriteLine("Your home loan is approved");
            }
            i.setArray(1);
            i.addToArray(dblGroceries, dblUtilities, dblTravelCost, dblPhone, dblOther);
            for (int x = 0; x < i.size(); x++)
            {
                Console.WriteLine("Your remaining income is: R" + (i.getGrossIncome() - i.getMonthlyRent() - i.getMonthlyTaxDeducted()
                                                                - i.getGroceries(x) - i.getTravelCost(x) - i.getCellphone(x)
                                                                - i.getOtherExpenses(x) - i.getUtilities(x) - monthlyPayment));
            }
        }
    }
}
