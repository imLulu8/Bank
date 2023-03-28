using Bank;

namespace Bank
{
    class Program : Bank
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            //CREAZIONE E AGGIUNTA DEI CLIENTI
            Customer customer1 = new Customer("Luca", "Commendatore", "CMMLCU96L08B428W", 2000);
            Customer customer2 = new Customer("Francesco", "Acquaviva", "ACVFRN75T10A562T", 1500);
            Customer customer3 = new Customer("Samuele", "Cammarata", "SMLCMM00S06T899G", 1500);


            bank.addCustomer(customer1);
            bank.addCustomer(customer2);

            // MODIFICA DELLO STIPENDIO DI UN CLIENTE CON TROVA CLIENTE AL QUALE ASSOCIAMO IL CLIENTE DA MODIFICARE
            Customer customerToModify = bank.findCustomer("CMMLCU96L08B428W");
            customerToModify.salary = 2500;
            bank.editCustomer("CMMLCU96L08B428W", customerToModify);

            //STAMPA DEL PROSPETTO RIASSUNTIVO DI UN CLIENTE

            Console.WriteLine($"Customer: {customer1.name} {customer1.surname}:");
            Console.WriteLine($"Code Identifier: {customer1.codeID}");
            Console.WriteLine($"Salary: {customer1.salary} euro\n");

            Console.WriteLine($"Customer: {customer2.name} {customer2.surname}:");
            Console.WriteLine($"Code Identifier: {customer2.codeID}");
            Console.WriteLine($"Salary: {customer2.salary} euro" + "\n");


            //CREAZIONE E AGGIUNTA DEI PRESTITI
            Loan loan1 = new Loan(2000, 4, "2023/03/08", "2024/04/01", customer1);
            Loan loan2 = new Loan(10000, 8, "2022/02/01", "2023/09/28", customer2);
            Loan loan3 = new Loan(5000, 4, "2023/02/11", "2024/06/18", customer1);


            bank.addLoan(loan1);
            bank.addLoan(loan2);
            bank.addLoan(loan3);

            //STAMPA DEL CLIENTE SINGOLO 
            Console.WriteLine("Customer 1" + customer1 + "\n");
            Console.WriteLine("Customer 2" + customer2 + "\n");

            //CERCARE I PRESTITI DI OGNI CLIENTE
            Console.WriteLine("Loans of customer 1 are " + bank.searchLoansCustomer("CMMLCU96L08B428W") + "\n");
            Console.WriteLine("Loans of customer 2 are " + bank.searchLoansCustomer("ACVFRN75T10A562T") + "\n");

            //CERCARE IL TOTALE DELL'AMMONTARE DEI PRESTITI DI UN SINGOLO CLIENTE
            Console.WriteLine("Total amount loans of customer 1 are " + bank.totalAmountLoans("CMMLCU96L08B428W"));
            Console.WriteLine("Total amount loans of customer 2 are " + bank.totalAmountLoans("ACVFRN75T10A562T"));


            //STAMPA DEL NUMERO DEI CLIENTI ALL'INTERNO DELLA BANCA
            Console.WriteLine("Customers inside the bank are " + bank.printNumCustomers() + ("\n"));


            //STAMPA EFFETTIVA DEI CLIENTI PRESENTI IN BANCA
            bank.printCustomers();


            //DIVERSO DA TROVA CLIENTE, SE TROVATO VIENE STAMPATO
            bank.searchCustomer("CMMLCU96L08B428W");

            //AGGIUNTA ED ELIMINAZIONE DI UN NUOVO CLIENTE
            bank.addCustomer(customer3);

            bank.printCustomers();

            bank.removeCustomer(customer3);

            bank.printCustomers();
        }
    }
}


