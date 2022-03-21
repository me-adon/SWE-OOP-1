using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System__Home__v._01
{
    internal class Current_Account : Account
    {
        public string accNo;
        public int initial_deposite, min_balance, balance;


        public string get_current_Account()
        {
            string return_current = accNo + "\t" + name + "\t" + age + "\t" + phoneNo + "\t" + address + "\t" + balance + "\t" + min_balance;
            return return_current;
        }

    }
}
