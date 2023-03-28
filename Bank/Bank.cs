
using Bank;

namespace Bank
{
    public class Bank
    {

        private List<Customer> listCustomers;
        private List<Loan> listLoans;



        public Bank(List<Customer> customers, List<Loan> loans)
        {
            this.listCustomers = customers;
            this.listLoans = loans;
        }



        public Bank()
        {
            listCustomers = new List<Customer>();
            listLoans = new List<Loan>();
        }



        public void printCustomers()
        {
            Console.WriteLine("List customers: ");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.ToString());
            }
        }



        public int printNumCustomers()
        {
            return listCustomers.Count();
        }

        public void addCustomer(Customer customer)
        {
            listCustomers.Add(customer);
        }



        public bool removeCustomer(Customer customer)
        {
            return listCustomers.Remove(customer);
        }



        public void editCustomer(string codeID, Customer modifiedCustomer)
        {
            Customer customerToModify = findCustomer(codeID);
            customerToModify.name = modifiedCustomer.name;
            customerToModify.surname = modifiedCustomer.surname;
            customerToModify.salary = modifiedCustomer.salary;
        }



        public Customer findCustomer(string codeID)
        {
            foreach (Customer customer in listCustomers)
            {
                if (customer.codeID == codeID)
                {
                    return customer;
                }
            }
            return null;
        }


        public void searchCustomer(string codeID)
        {
            Customer customer = findCustomer(codeID);
            if (customer != null)
            {
                Console.WriteLine("Customer found:");
                Console.WriteLine(customer.ToString());
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }



        public void addLoan(Loan loan)
        {
            listLoans.Add(loan);
        }



        public string searchLoansCustomer(string codeID)
        {
            List<string> prestitiCliente = new List<string>();
            foreach (Loan loan in listLoans)
            {
                if (loan.holder.codeID == codeID)
                {
                    prestitiCliente.Add(loan.ToString());
                }
            }
            return string.Join("\n", prestitiCliente);
        }



        public double totalAmountLoans(string codeID)
        {
            double totalAmount = 0;
            foreach (Loan loan in listLoans)
            {
                if (loan.holder.codeID == codeID)
                {
                    totalAmount += loan.amount;
                }
            }
            return totalAmount;
        }



    }

}




