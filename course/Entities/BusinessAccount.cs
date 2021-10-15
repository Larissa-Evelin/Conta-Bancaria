using System;
using System.Collections.Generic;
using System.Text;
using course.Entities;

namespace course.Entities
{
    class BunissAccount : Account //HERDANDO TODOS OS METODOS DA CLASSE ACCOUNT
    {
        public double LoanLimit { get; set; }

        public BunissAccount() //CONSTRUTOR POSSUI O MESMO NOME DA CLASSE
        {

        }

        public BunissAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) //BASE : CONSTRUTOR SUBCLASSE
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) //METODO POSSUI UM RETORNO E NOME DIFERENTE
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
