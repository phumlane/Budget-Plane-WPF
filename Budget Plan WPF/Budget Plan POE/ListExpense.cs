using System;
using System.Collections.Generic;
using System.Text;

namespace Budget_Plan_POE
{
    class ListExpense : IComparable<ListExpense>
    {
        public string expenseName;
        public double expense;

        public string getData()
        {
            return this.expenseName + " is: R" + this.expense;
        }

        public double CompareTo(ListExpense other)
        {
            return this.expense.CompareTo(other.expense);
        }

        int IComparable<ListExpense>.CompareTo(ListExpense other)
        {

            throw new NotImplementedException();
        }
    }
}
