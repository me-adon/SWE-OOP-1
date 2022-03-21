using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System__Home__v._01
{
    internal class Loan_Account : Account
    {
        public string accNo;
        public int initial_loan, min_balance, balance;


        public string get_loan_Account()
        {
            string return_loan = accNo + "\t" + name + "\t" + age + "\t" + phoneNo + "\t" + address + "\t" + balance;
            return return_loan;
        }
    }
}
