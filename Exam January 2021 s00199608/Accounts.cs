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
        public double balance { get; set; }
        public DateTime InterestDate { get; set; }
        //Constructor
        public Accounts()
        {

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
        public Current(string fName, string lName, double balance)
        {

        }
        public override double CalculateInterest()
        {
            double interest;
            interest = balance* InterestRate;
            return interest;
        }
    }
    public class Saving : Accounts
    {
        public int InterestRate = 6;
        public Saving(string fName, string lName, double balance)
        {

        }
        public override double CalculateInterest()
        {
            double interest;
            interest = balance * InterestRate;
            return interest;
        }
    }
}
