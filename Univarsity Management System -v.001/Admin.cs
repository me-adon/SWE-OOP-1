using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univarsity_Management_System__v._001
{
    internal class Admin
    {
        public string name,department,designation;
        public int salary;

        public Admin()
        {

        }
        public Admin(string name,string department, string designation,int salary)
        {
            this.name = name;
            this.department = department;
            this.designation = designation;
            this.salary = salary;
        }

        public string getName()
        {
            string returnName = "Name : " + name;
            return returnName + "\t";
        }
        public string getDepartment()
        {
            string returnDepartment = "Dept : " + department;
            return returnDepartment + "\t";
        }
        public string getDesignation()
        {
            string returnDesignation = "Designation : " + designation;
            return returnDesignation + "\t";
        }
        public string getSalary()
        {
            string returnSalary = "Salary : " + salary;
            return returnSalary + "\t";
        }

    }
}
