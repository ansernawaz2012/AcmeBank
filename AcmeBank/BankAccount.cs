using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeBank
{
    public class BankAccount
    {
        public BankAccount(BasicAccount basic)
        {
            Console.WriteLine($"This account is a {basic.AccountType}");
            Console.WriteLine($"The overdraft limit is {basic.OverdraftLimit}");
            Console.WriteLine($"The credit card issued with this account is the {basic.CCType}");

            
            basic.GetBalance();
            basic.Deposit(300);
            basic.Withdraw(500);
            basic.Withdraw(155);

        }
        
       
    }
}
