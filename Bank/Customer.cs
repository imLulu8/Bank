using Bank;

namespace Bank
{
    public class Customer
    {
        public string name;
        public string surname;
        public string codeID;
        public double salary;

        public Customer(string name, string surname, string codeID, double salary)
        {
            this.name = name;
            this.surname = surname;
            this.codeID = codeID;
            this.salary = salary;
        }


        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getCF()
        {
            return codeID;
        }

        public double getSalary()
        {
            return salary;
        }


        public override string ToString()
        {
            return
                    "\n \nName = " + getName() +
                    "\nSurname = " + getSurname() +
                    "\nCode ID = " + getCF() +
                    "\nSalary = " + getSalary();

        }

    }

}


