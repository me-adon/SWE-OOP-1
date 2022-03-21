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


namespace CSV_FileHandle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

         //static void Main(string[] args)
         //{
            
         //}

         private void SearchOnClick(object sender, EventArgs e)
         {
            string inputID = textBox1.Text;
            for(int i = 0; i < employees.Count; i++)
            {
                //if(inputID == .EMPLOYEE_ID)
                //{
                   // MessageBox.Show("Found");

                //}
            }


         }
        List<Employee> employees = new List<Employee>();


        private void Form1_Load_1(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"C:\employees.csv"))
            {
                //List<string> listA = new List<string>();
                //List<string> listB = new List<string>();

                Employee dummy_employee = new Employee();
                
                


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    string EMPLOYEE_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE_NUMBER, HIRE_DATE, JOB_ID, SALARY, COMMISSION_PCT, MANAGER_ID, DEPARTMENT_ID;
                    EMPLOYEE_ID = values[0];
                    FIRST_NAME = values[1];
                    LAST_NAME = values[2];
                    EMAIL = values[3];
                    PHONE_NUMBER = values[4];
                    HIRE_DATE = values[5];
                    JOB_ID = values[6];
                    SALARY = values[7];
                    COMMISSION_PCT = values[8];
                    MANAGER_ID = values[9];
                    DEPARTMENT_ID = values[10];

                    Employee emp = new Employee(EMPLOYEE_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE_NUMBER, HIRE_DATE, JOB_ID, SALARY, COMMISSION_PCT, MANAGER_ID, DEPARTMENT_ID);
                    employees.Add(emp);

                    /*
                    for (int i = 0; i < employees.Count; i++)
                    {
                    listBox1.Items.Add(employees[i].EMPLOYEE_ID + "\t" + employees[i].FIRST_NAME + "\t" + employees[i].JOB_ID + "\t" + employees[i].EMAIL + "\t" + employees[i].PHONE_NUMBER + "\t" + employees[i].SALARY);
                    }
                    */

                    //listA.Add(values[0]);
                    //listB.Add(values[1]);
                    dummy_employee.EMPLOYEE_ID = values[0];
                    dummy_employee.FIRST_NAME = values[1];
                    dummy_employee.LAST_NAME = values[2];
                    dummy_employee.EMAIL = values[3];
                    dummy_employee.PHONE_NUMBER = values[4];
                    dummy_employee.HIRE_DATE = values[5];
                    dummy_employee.JOB_ID = values[6];
                    dummy_employee.SALARY = values[7];
                    dummy_employee.COMMISSION_PCT = values[8];
                    dummy_employee.MANAGER_ID = values[9];
                    dummy_employee.DEPARTMENT_ID = values[10];

                    for (int i = employees.Count-1; i < employees.Count; i++)
                    {
                        listBox1.Items.Add(employees[i].EMPLOYEE_ID + "\t" + employees[i].FIRST_NAME + "\t" + employees[i].JOB_ID + "\t" + employees[i].EMAIL + "\t" + employees[i].PHONE_NUMBER + "\t" + employees[i].SALARY);
                    }

                    /*
                    employees.Add(dummy_employee);
                    for (int i = 0; i < employees.Count; i++)
                    {
                    listBox1.Items.Add(dummy_employee.EMPLOYEE_ID + "\t" + dummy_employee.FIRST_NAME + "\t" + dummy_employee.JOB_ID + "\t" + dummy_employee.EMAIL + "\t" + dummy_employee.PHONE_NUMBER + "\t" + dummy_employee.SALARY);
                    }
                    */

                }


            }
        }
    }
}
