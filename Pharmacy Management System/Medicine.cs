using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Medicine
    {
        public string name;
        public int quantity;
        public int price;

        public string get_medicine()
        {
            string get_medi= name +"\t"+ quantity.ToString()+"\t"+price.ToString();
            return get_medi;
        }
    }

}
