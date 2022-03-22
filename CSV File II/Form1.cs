using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CSV_File_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         public List<Student> students = new List<Student>();
         public List<int> quizes = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"C:\Users\Adon\Desktop\SWE4201MarkSheet.csv"))
            {
                //List<string> listA = new List<string>();
                //List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values[2] == "")
                    {
                        values[2] = "0";
                    }
                    if (values[3] == "")
                    {
                        values[3] = "0";
                    }
                    if (values[4] == "")
                    {
                        values[4] = "0";
                    }
                    if (values[5] == "")
                    {
                        values[5] = "0";
                    }
                    if (values[6] == "")
                    {
                        values[6] = "0";
                    }
                    if (values[8] == "")
                    {
                        values[8] = "0";
                    }
                    if (values[9] == "")
                    {
                        values[9] = "0";
                    }

                    Student student = new Student();
                    student.ID = values[0];
                    student.Name = values[1];
                    student.Attendance = Convert.ToInt32(values[2]);
                    student.QuizI = Convert.ToInt32(values[3]);
                    student.QuizII = Convert.ToInt32(values[4]);
                    student.QuizIII = Convert.ToInt32(values[5]);
                    student.QuizIV = Convert.ToInt32(values[6]);
                    student.MID = Convert.ToInt32(values[7]);
                    student.Final= Convert.ToInt32(values[8]);
                    student.Viva = Convert.ToInt32(values[9]);


                    int q1, q2, q3, q4,temp;
                    q1 = student.QuizI;
                    q2 = student.QuizII;
                    q3 = student.QuizIII;
                    q4 = student.QuizIV;

                    if(q1>q4 && q2>q4 && q3>q4)
                    {
                        student.bestQuizIII = q1 + q2 + q3;
                    }
                    if (q1 > q3 && q2 > q3 && q4 > q3)
                    {
                        student.bestQuizIII = q1 + q2 + q4;
                    }
                    if (q1 > q2 && q3 > q2 && q4 > q2)
                    {
                        student.bestQuizIII = q1 + q4 + q3;
                    }
                    if (q1 < q4 && q2 > q1 && q3 > q1)
                    {
                        student.bestQuizIII = q4 + q2 + q3;
                    }


                    /*
                    quizes.Add(student.QuizI);
                    quizes.Add(student.QuizII);
                    quizes.Add(student.QuizIII);
                    quizes.Add(student.QuizIV);

                    quizes.Sort();*/

                    //student.bestQuizIII = quizes[1] + quizes[2] + quizes[3];
                    int sum = student.bestQuizIII + student.MID + student.Final + student.Viva;
                    student.totalMarks = sum;
                    student.Percentage = student.totalMarks / 3;
 
                    


                    if (student.Percentage >= 80)
                    {
                        student.grade = "A+";
                    }
                    else if (student.Percentage < 80 && student.Percentage >= 75)
                    {
                        student.grade = "A";
                    }
                    else if (student.Percentage < 75 && student.Percentage >= 70)
                    {
                        student.grade = "A-";
                    }
                    else if (student.Percentage < 70 && student.Percentage >= 65)
                    {
                        student.grade = "B+";
                    }
                    else if (student.Percentage < 65 && student.Percentage >= 60)
                    {
                        student.grade = "B";
                    }
                    else if (student.Percentage < 60 && student.Percentage >= 55)
                    {
                        student.grade = "C";
                    }
                    else if (student.Percentage < 55 && student.Percentage >= 50)
                    {
                        student.grade = "D";
                    }
                    else
                    {
                        student.grade = "F";
                    }

                    students.Add(student);

                    listBox1.Items.Add(student.ID);
                    listBox2.Items.Add(student.Name);
                    listBox3.Items.Add(student.Percentage + "%");
                    listBox4.Items.Add(student.grade);

                    //listBox3.Items.Add(student.Attendance);

                    //listA.Add(values[0]);
                    //listB.Add(values[1]);
                }
            }
        }

        private void SearchOnClick(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            for(int i = 0; i < students.Count; i++)
            {
                if(students[i].ID == id)
                {
                    textBox2.Text = Convert.ToString(students[i].Attendance);
                    textBox3.Text = Convert.ToString(students[i].QuizI);
                    textBox4.Text = Convert.ToString(students[i].QuizII);
                    textBox5.Text = Convert.ToString(students[i].QuizIII);
                    textBox6.Text = Convert.ToString(students[i].QuizIV);
                    textBox7.Text = Convert.ToString(students[i].bestQuizIII);
                    textBox8.Text = Convert.ToString(students[i].MID);
                    textBox9.Text = Convert.ToString(students[i].Final);
                    textBox10.Text = Convert.ToString(students[i].Viva);
                    textBox11.Text = Convert.ToString(students[i].totalMarks);
                    textBox12.Text = Convert.ToString(students[i].Percentage);
                    textBox13.Text = Convert.ToString(students[i].grade);
                }
            }
        }
    }
}
