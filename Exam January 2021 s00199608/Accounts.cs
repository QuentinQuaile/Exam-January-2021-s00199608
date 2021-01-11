using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_2021_s00199608
{
    public abstract class Accounts
    {
        //Properties
        public string fName { get; set; }
        public string lName { get; set; }
        public decimal Balance { get; set; }
        public DateTime InterestDate { get; set; }
        public string Account { get; set; }
        //Constructor
        public Accounts(decimal balance, string lname, string fname, string account, DateTime dateTime)
        {
            Balance = balance;
            fName = fname;
            lName = lname;
            Account = account;
            InterestDate = dateTime;
        }
        //Method
        public abstract decimal CalculateInterest();
        public decimal Deposit(decimal Transaction)
        {
            Balance = Balance + Transaction;
            return Balance;
        }
        public decimal Withdraw(decimal Transaction)
        {
            Balance = Balance - Transaction;
            return Balance;
        }
    }
    public class Current : Accounts
    {
        public int InterestRate = 3;
        public Current(decimal balance, string lname, string fname, string account, DateTime dateTime) : base(balance,lname,fname,account, dateTime)
        {

        }
        public override decimal CalculateInterest()
        {
            decimal interest;
            interest = Balance* InterestRate;
            return interest;
        }
        public override string ToString()
        {
            return lName + " " + fName;
        }
    }
    public class Saving : Accounts
    {
        public int InterestRate = 6;
        public Saving(decimal balance, string lname, string fname, string account, DateTime dateTime) : base(balance,lname,fname,account,dateTime)
        {
            
        }
        public override decimal CalculateInterest()
        {
            decimal interest;
            interest = Balance * InterestRate;
            return interest;
        }
        public override string ToString()
        {
            return lName + " " + fName;
        }
    }
}
