﻿using System;
using BankAccount.Entities;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {

            /*Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bacc; // BusinessAccount bacc é um Account, logo pode ser atribuído a uma variável do tipo Account
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);


            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2; // Account acc2 é um BusinessAccount, logo pode ser atribuído a uma variável do tipo BusinessAccount
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3; // Account acc3 é um SavingsAccount, logo não pode ser atribuído a uma variável do tipo BusinessAccount
            if (acc3 is BusinessAccount) { // if falho (apenas para exemplo)
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // BusinessAccount acc5 = (BusinessAccount)acc3 (outra forma de fazer)
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount) { // if verdadeiro
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!"); 
            }
            */

            // SOBREPOSIÇÃO, PALAVRA VIRTUAL E OVERRIDE
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}