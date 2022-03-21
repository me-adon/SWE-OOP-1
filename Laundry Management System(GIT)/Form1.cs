using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>();

        private void CreateAccountOnClick(object sender, EventArgs e)
        {
            int userID;
            string name, address;
            
            userID = Convert.ToInt32(textBox2.Text);
            name = textBox3.Text;
            address = textBox4.Text;

            User dummy_user = new User();
            
            dummy_user.name = name;
            dummy_user.address = address;
            dummy_user.userID = userID;

            users.Add(dummy_user);

            MessageBox.Show("Account Created Successfully");
        }

        List<Order> orders = new List<Order>();

        private void PlaceOrderOnClick(object sender, EventArgs e)
        {
            int user_ID;
            user_ID = Convert.ToInt32(textBox7.Text);
            int pant, shirt, suit, bedsheet, user__ID;
            string pant_todo, shirt_todo, suit_todo, bedsheet_todo;

            pant = Convert.ToInt32(textBox6.Text);
            shirt = Convert.ToInt32(textBox5.Text);
            suit = Convert.ToInt32(textBox9.Text);
            bedsheet = Convert.ToInt32(textBox8.Text);

            user__ID = Convert.ToInt32(textBox7.Text);

            pant_todo = comboBox2.Text;
            shirt_todo = comboBox4.Text;
            suit_todo = comboBox3.Text;
            bedsheet_todo = comboBox7.Text;

            Order dummy_order = new Order();
            dummy_order.shirt = shirt;
            dummy_order.suit = suit;
            dummy_order.bedsheet = bedsheet;
            dummy_order.pant = pant;

            dummy_order.user__ID = user_ID;

            dummy_order.pant_todo = pant_todo;
            dummy_order.shirt_todo = shirt_todo;
            dummy_order.suit_todo = suit_todo;
            dummy_order.bedsheet_todo = bedsheet_todo;

            for (int i=0; i<users.Count; i++)
            {
                if (users[i].userID == user_ID)
                {
                    orders.Add(dummy_order);
                    MessageBox.Show("Order Placed Successfully");
                    break;
                }
            }
        }

        private void SetStatusOnClick(object sender, EventArgs e)
        {
            int order_ID = Convert.ToInt32(textBox1.Text);
            string stat_us = comboBox1.Text;
            int balance = 0;


            for(int i=0; i< orders.Count; i++)
            {
                if((order_ID - 1) == i)
                {
                    orders[i].status = stat_us;
                    balance += orders[i].pant * Amount.price_pant + orders[i].shirt * Amount.price_shirt + orders[i].suit * Amount.price_suit + orders[i].bedsheet * Amount.price_bedsheet;
                    
                    label2.Text = "Current balance : " + balance.ToString();

                    MessageBox.Show("Status Set Done");
                }
            }

        }

        private void SeeOrderDetailsOnClick(object sender, EventArgs e)
        {
            int order_ID = Convert.ToInt32(textBox10.Text);

            listBox1.Items.Clear();

            /*for(int i=0; i< orders.Count; i++)
            {
                if (orders[i].user__ID == users[i].userID)
                {
                    //listBox1.Items.Add(orders[i].get_userInfo());
                }
            }*/
            int i= order_ID - 1;
            int total_amount;
            for(int k=0; k<users.Count; k++)
            {
                total_amount = 0;
                if(users[k].userID == orders[i].user__ID)
                {
                    listBox1.Items.Add(users[k].get_userInfo() + "\t" +orders[i].get_OrderInfo());
                    label12.Text = "Status : " + orders[i].status;
                    label15.Text = "Name : " + users[k].name;
                    label14.Text = "Address : " + users[k].address;
                    total_amount = orders[i].pant * Amount.price_pant + orders[i].shirt * Amount.price_shirt + orders[i].suit * Amount.price_suit + orders[i].bedsheet * Amount.price_bedsheet;
                    label13.Text = "Amount : " + total_amount.ToString();
                }
            }
        }
    }
}
