using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Enroll : Participant
    {
        public string student;
        public string course;
        public string date;


        public string get_enroll()
        {
            string return_enroll = student + "\t" + course + "\t\t " + date;
            return return_enroll; 
        }

    }
}
