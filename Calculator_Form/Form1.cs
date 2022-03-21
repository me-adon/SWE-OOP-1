using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonToAdd_Click(object sender, EventArgs e)
        {
            int N1=Convert.ToInt32(textBox1.Text); //converts input in 1st text box to integer
            int N2=Convert.ToInt32(textBox2.Text);   
            string result=Convert.ToString(N1+N2); //converts the evaluated value to string to give output
            MessageBox.Show(result);
            //Convert.ToString(textBox3) = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt32(textBox1.Text); //converts input in 1st text box to integer
            int N2 = Convert.ToInt32(textBox2.Text);
            string result = Convert.ToString(N1 - N2); //converts the evaluated value to string to give output
            MessageBox.Show(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt32(textBox1.Text); //converts input in 1st text box to integer
            int N2 = Convert.ToInt32(textBox2.Text);
            string result = Convert.ToString(N1 * N2); //converts the evaluated value to string to give output
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt32(textBox1.Text); //converts input in 1st text box to integer
            int N2 = Convert.ToInt32(textBox2.Text);
            string result = Convert.ToString(N1 / N2); //converts the evaluated value to string to give output
            MessageBox.Show(result);
        }
    }
}
