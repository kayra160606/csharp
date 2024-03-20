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
    public partial class Unit3_3 : Form
    {
        class employee
        {
            int empcode;
            string empname;
            Single salary;
            public employee() { }
            public employee(int Ecode) { empcode = Ecode; }

            public employee(int Ecode, string Ename)
            {
                empcode = Ecode;
                empname = Ename;
            }
            public employee(int Ecode, string Ename, Single sal)
            {
                empcode = Ecode;
                empname = Ename;
                salary = sal;
            }
            public string showData()
            {
                string str;
                str = "EmpCode :" + empcode + "\nEmpName: " +empname +"\nSalary: "+salary;
                return str;
            }
        }

        public Unit3_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee e1 = new employee();
            MessageBox.Show(e1.showData());

            employee e3 = new employee(101,"Miral");
            MessageBox.Show(e3.showData());

            employee e2 = new employee(101);
            MessageBox.Show(e2.showData());

            employee e4 = new employee(101,"Miral",10000);
            MessageBox.Show(e4.showData());
        }
    }
}
