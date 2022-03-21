using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_task_1_Lab_
{
    internal class Circle : Shape
    {
        public int radius;

        public string getArea()
        {
            double Area = 3.1416 * radius;
            string showArea = "Area : " + Convert.ToString(Area);
            return showArea;
        }

        public string getPerimeter()
        {
            double Perimeter = 2 * (3.1416) * radius;
            string showPerimeter = "Perimeter : " + Convert.ToString(Perimeter);
            return showPerimeter;
        }
    }
}
