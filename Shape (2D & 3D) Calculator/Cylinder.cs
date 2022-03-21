using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_task_1_Lab_
{
    internal class Cylinder : Shape
    {
        public int radius, height;
        public string getVolume()
        {
            double Volume = 3.1416 * radius * radius * height;
            string showVolume = "Volume : " + Convert.ToString(Volume);
            return showVolume;
        }

        public string getSurfaceArea()
        {
            double SurfaceArea = (2 * 3.1416 * radius * height) + (2 * 3.1416 * radius * radius);
            string showSurfaceArea = "Surface Area : " + Convert.ToString(SurfaceArea);
            return showSurfaceArea;
        }
    }
}
