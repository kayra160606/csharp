using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit3
{
    
    public partial class unit3_1 : Form
    {
        abstract class Shape
        {
            public virtual int area()
            { return 0; }
            public virtual int perimeter() { return 0; }
        }
        class square : Shape
        {
            int l;
            public square(int length)
            {
                l = length;
            }
            public override int area()
            {
                return l * l;
            }
            public override int perimeter()
            {
                return 4 * l;
            }
        }
        class circle : Shape
        {
            int r;
            public circle(int radius)
            {
                r = radius;
            }
            public override int area()
            {
                return Convert.ToInt16(Math.PI * r * r);
            }
            public override int perimeter()
            {
                return Convert.ToInt16(2 * Math.PI * r);
            }
        }
        class ract : Shape
        {
            int l, b;
            public ract(int length, int breadth)
            {
                l = length;
                b = breadth;
            }

            public override int area()
            {
                return l * b;
            }
            public override int perimeter()
            {
                return 2 * (l + b);
            }
        }


        public unit3_1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked== true)
            {
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible=false;
                txtradius.Text = "";    
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            txtsqlength.Text = "";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }
        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            circle c = new circle(Convert.ToInt16(txtradius.Text));
            int area = c.area();
            MessageBox.Show("Area of circle is :" + Convert.ToString(area));
        }
        private void btncirclepari_Click(object sender, EventArgs e)
        {
            circle c = new circle(Convert.ToInt16(txtradius.Text));
            int Peri = c.perimeter();
            MessageBox.Show("Perimeter of circle is :" + Convert.ToString(Peri));
        }
        private void btnsquarArea_Click(object sender, EventArgs e)
        {
            square s = new square(Convert.ToInt16(txtsqlength.Text));
            int area = s.area();
            MessageBox.Show("Area of Square is "+Convert.ToString(area));   
        }
        private void btnSquarPeri_Click(object sender, EventArgs e)
        {
            square s = new square(Convert.ToInt16(txtsqlength.Text));
            int Peri = s.perimeter();
            MessageBox.Show("Perimeter of Square is " + Convert.ToString(Peri));
        }

        private void btnRectArea_Click(object sender, EventArgs e)
        {
           ract rc = new ract(Convert.ToInt16(textBox1.Text),Convert.ToInt16(txtractbreadth.Text));
            int area = rc.area();
            MessageBox.Show("Area of Ractangle is " + Convert.ToString(area));
        }
        private void btnRectPeri_Click(object sender, EventArgs e)
        {
            ract rc = new ract(Convert.ToInt16(textBox1.Text), Convert.ToInt16(txtractbreadth.Text));
            int peri = rc.perimeter();
            MessageBox.Show("Perimeter of Ractangle is " + Convert.ToString(peri));
        }
    }
   

}
