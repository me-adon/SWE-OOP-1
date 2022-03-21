using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ShowCurrentStockOnClick(object sender, EventArgs e)
        {
            Current_Stock.Items.Clear();
            for(int i=0; i<medicines.Count; i++)
            {
                Current_Stock.Items.Add(medicines[i].get_medicine());
            }

        }

        List<Medicine> medicines = new List<Medicine>();

        private void AddMedicineOnClick(object sender, EventArgs e)
        {
            string name;
            int quantity, price;
            name = textBox1.Text;
            quantity = Convert.ToInt32(textBox2.Text);
            price = Convert.ToInt32(textBox3.Text);

            Medicine dummy_medicine = new Medicine();

            dummy_medicine.name = name;
            dummy_medicine.quantity = quantity;
            dummy_medicine.price = price;

            medicines.Add(dummy_medicine);

            MessageBox.Show("Added");

        }

        private void SellMedicineOnclick(object sender, EventArgs e)
        {
            string name_char = textBox1.Text;
            int quantity_int = Convert.ToInt32(textBox2.Text);
            int price_int = Convert.ToInt32(textBox3.Text);

            for (int i=0; i<medicines.Count; i++)
            {
                if(name_char==medicines[i].name)
                {
                    medicines[i].quantity = medicines[i].quantity-quantity_int;
                    break;
                }

            }
            
            MessageBox.Show("Sold");
        }

        private void ShowCurrentAccountOnClick(object sender, EventArgs e)
        {
            string name_char = textBox1.Text;
            int quantity_int = Convert.ToInt32(textBox2.Text);
            int price_int = Convert.ToInt32(textBox3.Text);
            int initial_amount = Convert.ToInt32(textBox4.Text);
            Current_Account_Balance.Items.Clear();

            for (int i = 0; i < medicines.Count; i++)
            {
                if (name_char == medicines[i].name)
                {
                    initial_amount += medicines[i].price;

                    Current_Account_Balance.Items.Add(initial_amount);

                    break;
                }

            }

            //MessageBox.Show("Sold");

        }
    }
}
