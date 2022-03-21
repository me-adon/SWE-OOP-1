using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Univarsity_Management_System__v._001
{
    public partial class Form1 : Form
    {
        UMS ums = new UMS();
        public Form1()
        {
            InitializeComponent();
        }
         
        
        private void SaveStudentOnClick(object sender, EventArgs e)
        {
            string name, department, semester;
            int id;

            name = studentNameTextBox.Text;
            id = Convert.ToInt32(studentIDTextBox.Text);    
            department = studentDepartmentTextBox.Text;
            semester = studentSemesterTextBox.Text;

            
            Student dummy = new Student ( name, id, department, semester );
            ums.students.Add( dummy);

            MessageBox.Show("Student Added");
        }

        private void ClearStudentOnClick(object sender, EventArgs e)
        {
            studentNameTextBox.Clear();
            studentDepartmentTextBox.Clear();
            studentIDTextBox.Clear();   
            studentSemesterTextBox.Clear();

            //MessageBox.Show("");
        }

        private void ShowStudentInfoOnClick(object sender, EventArgs e)
        {
            StudentListBox.Items.Clear();
            for(int i=0; i<ums.students.Count; i++)
            {
                StudentListBox.Items.Add(ums.students[i].getName() + ums.students[i].getID() + ums.students[i].getDepartment() + ums.students[i].getSemester());
            }
        }

        private void SaveTeacherInfoOnClick(object sender, EventArgs e)
        {
            string name, department, designation;
            int salary;

            name = teacherNameTextBox.Text;
            department = teacherDepartmentTextBox.Text;
            designation = teacherDesignationTextBox.Text;
            salary = Convert.ToInt32(teacherSalaryTextBox.Text);
            
            Teacher dummy = new Teacher(name,department,designation,salary);
            ums.teachers.Add(dummy);
            MessageBox.Show("Teacher Added");
        }

        private void ClearTeacherOnClick(object sender, EventArgs e)
        {
            teacherNameTextBox.Clear();
            teacherDepartmentTextBox.Clear();
            teacherDesignationTextBox.Clear();
            teacherSalaryTextBox.Clear();

            MessageBox.Show("Cleared Successfully");
        }

        private void ShowTeacherInfoOnClick(object sender, EventArgs e)
        {
            teacherListBox.Items.Clear();
            for(int i = 0; i<ums.teachers.Count; i++)
            {
                teacherListBox.Items.Add(ums.teachers[i].getName() + ums.teachers[i].getDepartment() + ums.teachers[i].getDesignation() + ums.teachers[i].getSalary());
            }
        }

        private void SaveAdminInfoOnClick(object sender, EventArgs e)
        {
            string name,department,designation;
            int salary;

            name = adminNameTextBox.Text;
            department = adminDepartmentTextBox.Text;
            designation = adminDesignationTextBox.Text;
            salary = Convert.ToInt32(adminSalaryTextBox.Text);

            Admin dummy = new Admin(name, department, designation, Convert.ToInt32(salary));
            ums.admins.Add( dummy );

            MessageBox.Show("Saved Successfully");

        }

        private void ClearAdminOnClick(object sender, EventArgs e)
        {
            adminNameTextBox.Clear();
            adminDepartmentTextBox.Clear();
            adminDesignationTextBox.Clear();
            adminSalaryTextBox.Clear();

            //MessageBox.Show("Cleared Successfully");
        }

        private void ShowAdminInfoOnClick(object sender, EventArgs e)
        {
            adminListBox.Items.Clear();
            for(int i = 0; i < ums.admins.Count; i++)
            {
                adminListBox.Items.Add(ums.admins[i].getName() + ums.admins[i].getDepartment() + ums.admins[i].getDesignation() + ums.admins[i].getSalary());
            }
        }
    }














































                                                     
}
