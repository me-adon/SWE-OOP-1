using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_task_1_Lab_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         List<Rectangle> rectangles = new List<Rectangle>();
         List<Circle> circles = new List<Circle>();
         List<Sphere> spheres = new List<Sphere>();
         List<Cylinder> cylinders = new List<Cylinder>();

        private void SaveL1OnClick(object sender, EventArgs e)
        {
            int length_1, length_2;
            length_1 = Convert.ToInt32(textBox1.Text);
            length_2 = Convert.ToInt32(textBox2.Text);

            Rectangle dummy_rectangle = new Rectangle();
            dummy_rectangle.length_2 = length_2;
            dummy_rectangle.length_1 = length_1;

            rectangles.Add(dummy_rectangle); 

        }

        private void SaveL2OnClick(object sender, EventArgs e)
        {
            int radius;
            radius = Convert.ToInt32(textBox3.Text);
            
            Circle dummy_circle = new Circle();
            dummy_circle.radius = radius;
            
            circles.Add(dummy_circle);
        }

        private void SaveL3OnClick(object sender, EventArgs e)
        {
            int radius;
            radius = Convert.ToInt32(textBox6.Text);

            Sphere dummy_sphere = new Sphere();
            dummy_sphere.radius = radius;

            spheres.Add(dummy_sphere);
        }

        private void SaveL4OnClick(object sender, EventArgs e)
        {
            int radius, height;
            radius = Convert.ToInt32(textBox4.Text);
            height = Convert.ToInt32(textBox5.Text);

            Cylinder dummy_cylinder = new Cylinder();
            dummy_cylinder.radius = radius;

            cylinders.Add(dummy_cylinder);
        }

        private void CalculateL1OnClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = 0; i< listBox1.Items.Count; i++)
            {
                listBox1.Items.Add(rectangles[i].getArea() + " " + rectangles[i].getPerimeter());
            }
        }
    }
}
