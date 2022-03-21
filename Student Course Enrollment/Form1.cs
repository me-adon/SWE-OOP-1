using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course_Enrollment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Participant> participants = new List<Participant>();

        private void AddParticipantOnClick(object sender, EventArgs e)
        {
            string name, contactNo, email;
            string regNo;
            name = textBox1.Text;
            contactNo = textBox3.Text;
            email = textBox4.Text;
            regNo = textBox2.Text;


            string type, level;
            if(radioButton1.Checked && radioButton3.Checked)
            {
                type = radioButton1.Text;
                level = radioButton3.Text;
            }
            else if(radioButton1.Checked && radioButton4.Checked)
            {
                type = radioButton1.Text;
                level = radioButton4.Text;
            }
            else if(radioButton1.Checked && radioButton5.Checked)
            {
                type = radioButton1.Text;
                level = radioButton5.Text;
            }
            else 
            {
                type = radioButton2.Text;
            }

            if(radioButton3.Checked)
            {
                level = radioButton3.Text;
            }
            else if(radioButton4.Checked)
            {
                level=radioButton4.Text;
            }
            else
            {
                level=radioButton5.Text;
            }


            Participant dummy_participant = new Participant();
            dummy_participant.name = name;
            dummy_participant.contactNo = contactNo;
            dummy_participant.email = email;
            dummy_participant.regNo = regNo;

            dummy_participant.type = type;
            dummy_participant.level = level;


            participants.Add(dummy_participant);
            MessageBox.Show("Added");

        }

        List<Course> courses = new List<Course>();

        private void AddCourseOnClick(object sender, EventArgs e)
        {
            string title, level;
            int courseFee;

            title = textBox10.Text;
            courseFee = Convert.ToInt32(textBox8.Text);

            if(radioButton8.Checked)
            {
                level =radioButton8.Text;
            }
            else if( radioButton6.Checked)
            {
                level =radioButton6.Text;
            }
            else
            {
                level=radioButton7.Text;
            }

            Course dummy_course = new Course();

            dummy_course.level = level;
            dummy_course.title = title;
            dummy_course.courseFee = courseFee;

            courses.Add(dummy_course);
            MessageBox.Show("Added");

        }
        List<Enroll> enrolls = new List<Enroll>();
        private void PayEnrollOnClick(object sender, EventArgs e)
        {
            string studentID;
            string course, date;
            studentID = textBox7.Text;
            course = textBox6.Text;
            date = textBox5.Text;

            Enroll dummy_enroll = new Enroll();

            for (int i=0; i<participants.Count; i++)
            {
                if(studentID == participants[i].regNo)
                {
                    for(int j=0; j<courses.Count; j++)
                    {
                        if(course == courses[j].title)
                        {

                            dummy_enroll.course = course;
                            dummy_enroll.student = studentID;
                            dummy_enroll.date = date;

                            enrolls.Add(dummy_enroll);

                            label10.Text = "Course Fee: " + courses[j].courseFee + "BDT";
                            MessageBox.Show("Enrolled");


                        }
                    }
                }
            }



        }

        private void ShowOnClick(object sender, EventArgs e)
        {
            string studentID;
            studentID = textBox9.Text;

            for(int i=0; i<enrolls.Count; i++)
            {
                if (studentID == enrolls[i].student)
                {
                    listBox1.Items.Add(enrolls[i].get_enroll());
                    break;
                }
                
            }
        }
    }
}
