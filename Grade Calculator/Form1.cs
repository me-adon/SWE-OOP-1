using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_task__ONE_LAST_TRY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double attendance_marks = Convert.ToDouble(textBox4.Text);
            attendance_marks = Math.Ceiling((30.0/28.0)* attendance_marks);
            label14.Text = "Attendence: ";
            label14.Text += (" "+ attendance_marks.ToString()+"/30");
            
            double mid_marks = Convert.ToDouble(textBox5.Text);
            label15.Text = "Mid: ";
            label15.Text += (" " + mid_marks + "/75");

            double final_marks = Convert.ToDouble(textBox16.Text);
            label17.Text = "Final: ";
            label17.Text += (" " + final_marks + "/150");

            double quiz_I=Convert.ToDouble(textBox20.Text);
            double quiz_II=Convert.ToDouble(textBox19.Text);
            double quiz_III = Convert.ToDouble(textBox18.Text);
            double quiz_IV = Convert.ToDouble(textBox6.Text);
            double quiz_total = quiz_I + quiz_II + quiz_III + quiz_IV;
            double quiz_min= Math.Min(quiz_IV, Math.Min(quiz_III, Math.Min(quiz_II, quiz_I)));
            /*double quiz_min;
            quiz_min = Math.Min(quiz_I, quiz_II);
            quiz_min = Math.Min(quiz_III, quiz_min);
            quiz_min=Math.Min(quiz_IV,quiz_min);*/

            quiz_total = quiz_total - quiz_min;
            label16.Text = "Quiz: ";
            label16.Text += (" " + quiz_total.ToString() + "/45");

            double total = quiz_total + mid_marks+final_marks+attendance_marks;
            label18.Text = "Total: ";
            label18.Text += " " + total + "/300";

            double grade = Math.Round((((double)total / 300) * 100));
            label19.Text = "Grade: ";
            if (grade >= 80) label19.Text += "A+";
            else if (grade >= 75 && grade < 80) label19.Text += "A";
            else if (grade >= 70 && grade < 76) label19.Text += "A-";
            else if (grade >= 65 && grade < 70) label19.Text += "B+";
            else if (grade >= 60 && grade < 65) label19.Text += "B";
            else if (grade >= 50 && grade < 60) label19.Text += "C";
            else if (grade >= 40 && grade < 50) label19.Text += "D";

            String user_name = textBox1.Text;
            label16.Text += "\n\n\n\n\n\n\n\n\n\n\n";
            label16.Text += user_name + " obtained" + Math.Round(grade) + "% marks";

        }

    
    }
}
