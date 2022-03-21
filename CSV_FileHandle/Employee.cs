using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_FileHandle
{
    internal class Employee
    {
        public string EMPLOYEE_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE_NUMBER, HIRE_DATE, JOB_ID, SALARY, COMMISSION_PCT, MANAGER_ID, DEPARTMENT_ID;


        public Employee()
        {

        }

        public Employee(string EMPLOYEE_ID, string FIRST_NAME, string LAST_NAME, string EMAIL, string PHONE_NUMBER, string HIRE_DATE, string JOB_ID, string SALARY, string COMMISSION_PCT, string MANAGER_ID, string DEPARTMENT_ID)
        {
            this.EMPLOYEE_ID=EMPLOYEE_ID;
            this.FIRST_NAME=FIRST_NAME;
            this.LAST_NAME=LAST_NAME;
            this.EMAIL=EMAIL;
            this.PHONE_NUMBER=PHONE_NUMBER;
            this.HIRE_DATE = HIRE_DATE;
            this.JOB_ID=JOB_ID;
            this.SALARY=SALARY;
            this.COMMISSION_PCT=COMMISSION_PCT;
            this.MANAGER_ID=MANAGER_ID;
            this.DEPARTMENT_ID=DEPARTMENT_ID;
        }


    }

    

    //public string getInfo()
    //{
        //string X = EMPLOYEE_ID + "\t" + FIRST_NAME;
        //return X;
    //}

}
