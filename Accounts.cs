using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank101
{
    public class Accounts
    {
        //fields

        private double balance = 100;
        private int accountNumber = 0;

        //properties

         public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //methods

        public double Deposit(double balance, double depositAmt)
        {
            double result = depositAmt + balance;
            return result;
        }
        public double Withdraw(double balance, double withdrawAmt)
        {
            double result = balance - withdrawAmt;
            return result;

            

        }
        //constructor
        public Accounts()
        {
            Random accoutNumberGenerator = new Random();//object instantiation
            this.AccountNumber = accoutNumberGenerator.Next(100, 300);


        }


    }
}
