using System;

namespace AcmeBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicAccount basicAccount = new BasicAccount("Anser", "Nawaz", 11111111); 

            BankAccount Anser = new BankAccount(basicAccount);

            
            
           // Console.ReadKey();
        }
    }
}
