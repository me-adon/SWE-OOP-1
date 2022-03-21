using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System__Home__v._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountOnClick(object sender, EventArgs e)
        {
            string name, age, address, phoneNo, accNo;

            int initial_amount;

            name = TextBoxName.Text;
            age = TextBoxAge.Text;
            address = TextBoxAddress.Text;
            phoneNo = TextBoxPhoneNo.Text;
            accNo = "0";
            initial_amount = Convert.ToInt32(TextBoxInitialDeposite.Text);



            if (radioButton1.Checked)
            {
                Current_Account dummy_current_Account = new Current_Account();
                dummy_current_Account.name = name;
                dummy_current_Account.address = address;
                dummy_current_Account.age = age;
                dummy_current_Account.phoneNo = phoneNo;
                dummy_current_Account.accNo = accNo;
                dummy_current_Account.initial_deposite = initial_amount;
                dummy_current_Account.balance = initial_amount;

                Banking_System.current_Accounts.Add(dummy_current_Account);

                for (int i = 0; i < Banking_System.current_Accounts.Count; i++)
                {
                    if (Banking_System.current_Accounts.Count == i + 1)
                    {
                        Banking_System.current_Accounts[i].accNo = i + "3" + "0" + "0";
                        //Banking_System.current_Accounts[i].initial_deposite = ;
                    }

                }

            }





            else if (radioButton2.Checked)
            {
                Savings_Account dummy_savings_Account = new Savings_Account();
                dummy_savings_Account.name = name;
                dummy_savings_Account.address = address;
                dummy_savings_Account.age = age;
                dummy_savings_Account.phoneNo = phoneNo;
                dummy_savings_Account.accNo = accNo;
                dummy_savings_Account.initial_deposite = initial_amount;
                dummy_savings_Account.balance = initial_amount;

                if(initial_amount >= 50000)
                {
                    Banking_System.savings_Accounts.Add(dummy_savings_Account);

                    for (int i = 0; i < Banking_System.savings_Accounts.Count; i++)
                    {
                        if (Banking_System.savings_Accounts.Count == i + 1)
                        {
                            Banking_System.savings_Accounts[i].accNo = i + "3" + "1" + "4";
                            //Banking_System.savings_Accounts[i].min_balance = 0;
                        }

                    }

                }

                else
                {
                    MessageBox.Show("f");
                }

            }






            else if (radioButton3.Checked)
            {
                Loan_Account dummy_loan_account = new Loan_Account();
                dummy_loan_account.name = name;
                dummy_loan_account.age = age;
                dummy_loan_account.address = address;
                dummy_loan_account.phoneNo = phoneNo;
                dummy_loan_account.accNo = accNo;
                dummy_loan_account.initial_loan = initial_amount;
                dummy_loan_account.balance = initial_amount;


                Banking_System.loan_Accounts.Add(dummy_loan_account);

                for (int i = 0; i < Banking_System.loan_Accounts.Count; i++)
                {
                    if (Banking_System.loan_Accounts.Count == i + 1)
                    {
                        Banking_System.loan_Accounts[i].accNo = i + "4" + "0" + "0";
                    }

                    //Banking_System.loanUsers[i].min_balance = "0";

                }

            }







        }

        private void ShowAccountsOnClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButton6.Checked)
            {
                for (int i = 0; i < Banking_System.current_Accounts.Count; i++)
                {
                    listBox1.Items.Add(Banking_System.current_Accounts[i].get_current_Account());
                }

            }

            else if (radioButton5.Checked)
            {
                for (int i = 0; i < Banking_System.savings_Accounts.Count; i++)
                {
                    listBox1.Items.Add(Banking_System.savings_Accounts[i].get_savings_Account());
                }

            }

            else if (radioButton4.Checked)
            {
                for (int i = 0; i < Banking_System.loan_Accounts.Count; i++)
                {
                    listBox1.Items.Add(Banking_System.loan_Accounts[i].get_loan_Account());
                }

            }
        }

        private void DepositeAmmountOnClick(object sender, EventArgs e)
        {
            string accNo = textBox4.Text;
            int amount = Convert.ToInt32(textBox5.Text);


            //if(accNo[accNo.Length - 1] == 0 && accNo[accNo.Length - 2] == 0 && accNo[accNo.Length - 3] == 3)
            //{
                for(int i = 0; i < Banking_System.current_Accounts.Count; i++)
                {
                    if(Convert.ToInt32(accNo) == Convert.ToInt32(Banking_System.current_Accounts[i].accNo))
                    {
                        Banking_System.current_Accounts[i].balance = Banking_System.current_Accounts[i].balance + amount;
                        break;
                    }
                }
            //}

            //if (accNo[accNo.Length - 1] == 4 && accNo[accNo.Length - 2] == 1 && accNo[accNo.Length - 3] == 3)
            //{
                for (int i = 0; i < Banking_System.savings_Accounts.Count; i++)
                {
                    if (Convert.ToInt32(accNo) == Convert.ToInt32(Banking_System.savings_Accounts[i].accNo))
                    {
                        Banking_System.savings_Accounts[i].balance = Banking_System.savings_Accounts[i].balance + amount;
                        break;
                    }
                }
            //}

            //if(accNo[accNo.Length - 1] == 0 && accNo[accNo.Length - 2] == 0 && accNo[accNo.Length - 3] == 3)
            //{
            for (int i = 0; i < Banking_System.loan_Accounts.Count; i++)
            {
                if (Convert.ToInt32(accNo) == Convert.ToInt32(Banking_System.loan_Accounts[i].accNo) && Banking_System.loan_Accounts[i].balance >= 0)
                {
                    Banking_System.loan_Accounts[i].balance = Banking_System.loan_Accounts[i].balance - amount;
                    break;
                }
            }
            //}

        }

        private void WithdrawAmountOnClick(object sender, EventArgs e)
        {
            string accNo = textBox4.Text;
            int amount = Convert.ToInt32(textBox5.Text);


            //if(accNo[accNo.Length - 1] == 0 && accNo[accNo.Length - 2] == 0 && accNo[accNo.Length - 3] == 3)
            //{
            for (int i = 0; i < Banking_System.current_Accounts.Count; i++)
            {
                if (Convert.ToInt32(accNo) == Convert.ToInt32(Banking_System.current_Accounts[i].accNo))
                {
                    if(Banking_System.current_Accounts[i].balance >=500)
                    {
                        Banking_System.current_Accounts[i].balance = Banking_System.current_Accounts[i].balance - amount;
                        break;
                    }
                    
                }
            }
            //}

            //if (accNo[accNo.Length - 1] == 4 && accNo[accNo.Length - 2] == 1 && accNo[accNo.Length - 3] == 3)
            //{
            for (int i = 0; i < Banking_System.savings_Accounts.Count; i++)
            {
                if (Convert.ToInt32(accNo) == Convert.ToInt32(Banking_System.savings_Accounts[i].accNo))
                {
                    Banking_System.savings_Accounts[i].balance = Banking_System.savings_Accounts[i].balance - amount - 15;
                    break;
                }
            }
            //}
        }

        private void MoneyTransactionOnClick(object sender, EventArgs e)
        {
            string accNo_from = textBox1.Text;
            string accNo_to = textBox2.Text;
            int amount = Convert.ToInt32(textBox3.Text);



            //if(accNo[accNo.Length - 1] == 0 && accNo[accNo.Length - 2] == 0 && accNo[accNo.Length - 3] == 3)
            //{
            for (int i = 0; i < Banking_System.current_Accounts.Count; i++)
            {
                if (Convert.ToInt32(accNo_from) == Convert.ToInt32(Banking_System.current_Accounts[i].accNo))
                {
                    if (Banking_System.current_Accounts[i].balance >= 500 && amount<=100000)
                    {
                        Banking_System.current_Accounts[i].balance = Banking_System.current_Accounts[i].balance - amount;
                        break;
                    }

                }
            }
            //}

            //if (accNo[accNo.Length - 1] == 4 && accNo[accNo.Length - 2] == 1 && accNo[accNo.Length - 3] == 3)
            //{
            for (int i = 0; i < Banking_System.savings_Accounts.Count; i++)
            {
                if (Convert.ToInt32(accNo_from) == Convert.ToInt32(Banking_System.savings_Accounts[i].accNo))
                {
                    Banking_System.savings_Accounts[i].balance = Banking_System.savings_Accounts[i].balance - amount;
                    break;
                }
            }
            //}



            //if(accNo[accNo.Length - 1] == 0 && accNo[accNo.Length - 2] == 0 && accNo[accNo.Length - 3] == 3)
            //{
            for (int i = 0; i < Banking_System.current_Accounts.Count; i++)
            {
                if (Convert.ToInt32(accNo_to) == Convert.ToInt32(Banking_System.current_Accounts[i].accNo)  && amount <= 100000)
                {
                    Banking_System.current_Accounts[i].balance = Banking_System.current_Accounts[i].balance + amount;
                    break;
                }
            }
            //}

            //if (accNo[accNo.Length - 1] == 4 && accNo[accNo.Length - 2] == 1 && accNo[accNo.Length - 3] == 3)
            //{
            for (int i = 0; i < Banking_System.savings_Accounts.Count; i++)
            {
                if (Convert.ToInt32(accNo_to) == Convert.ToInt32(Banking_System.savings_Accounts[i].accNo))
                {
                    Banking_System.savings_Accounts[i].balance = Banking_System.savings_Accounts[i].balance + amount;
                    break;
                }
            }
            //}


        }
    }
}
