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
        public double Balance { get; set; }
        public DateTime InterestDate { get; set; }
        //Constructor
        public Accounts(double balance, string lname, string fname)
        {
            Balance = balance;
            fName = fname;
            lName = lname;
        }
        //Method
        public abstract double CalculateInterest();
        public void Deposit()
        {

        }
        public void Withdraw()
        {

        }
    }
    public class Current : Accounts
    {
        public int InterestRate = 3;
        public Current(double balance, string lname, string fname) : base(balance,lname,fname)
        {

        }
        public override double CalculateInterest()
        {
            double interest;
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
        public Saving(double balance, string lname, string fname) : base(balance,lname,fname)
        {
            
        }
        public override double CalculateInterest()
        {
            double interest;
            interest = Balance * InterestRate;
            return interest;
        }
        public override string ToString()
        {
            return lName + " " + fName;
        }
    }
}
