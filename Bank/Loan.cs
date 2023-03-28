using Bank;

namespace Bank
{

    public class Loan
    {
        public double amount;
        public double tranche;
        public string startDate;
        public string endDate;
        public Customer holder;

        public Loan(double amount, double tranche, string startDate, string endDate, Customer holder)
        {
            this.amount = amount;
            this.tranche = tranche;
            this.startDate = startDate;
            this.endDate = endDate;
            this.holder = holder;
        }


        public double getAmount()
        {
            return amount;
        }

        public double getTranche()
        {
            return tranche;
        }

        public string getStartDate()
        {
            return startDate;
        }


        public string getEndDate()
        {
            return endDate;
        }

        public Customer getHolder()
        {
            return holder;
        }




        public override string ToString()
        {
            return
                    "\n \nAmount = " + getAmount() +
                    "\nTranche = " + getTranche() +
                    "\nStart Date = " + getStartDate() +
                    "\nEnd Date= " + getEndDate() +
                    "\nHolder = " + getHolder();

        }

    }

}