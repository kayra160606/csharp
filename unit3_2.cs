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
    public partial class unit3_2 : Form
    {
        abstract class Person
        {
            string name, city, email;
            public virtual string showdetails()
            {
                string str;
                str = "Name: " + name + "\nCity: " + city + "\nEmail: " + email;
                return str;
            }
            protected void getdetails(string _name, string _city, string _email)
            {
                name = _name;
                city = _city;
                email = _email;
            }
        }
        class faculty : Person
        {
            string degree;
            Single salary;

            public void getdetails(string _name, string _city, string _email,string _degree,Single _salary)
            {
                base.getdetails(_name, _city, _email);
                degree = _degree;
                salary = _salary;
            }
            public override string showdetails()
            {
                string str;
                str = base.showdetails();
                str = str + "\nDegree: " + degree + "\nSalary: " +Convert.ToString(salary);
                return str;
            }
        }
        public unit3_2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            faculty f = new faculty();
            f.getdetails("Miral","Ahmedabad","m@g.com","MCA",25050);
            MessageBox.Show(f.showdetails());
        }
    }
}
