using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit4
{
    public partial class Unit4_2 : Form
    {
        public Unit4_2()
        {
            InitializeComponent();
        }

        public static SqlConnection cn;
        SqlCommand cmd;
        private void Unit4_2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BookDetails;Integrated Security=True";
            cn.Open();
            MessageBox.Show(cn.State.ToString());
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "select UName from Login where Uname = '" + txtUname.Text + "'";
            cmd.Connection = cn;
            string usernam, pass;
            usernam = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "select Upass from Login where UPass = '" + txtPassword.Text + "' ";
            pass = Convert.ToString(cmd.ExecuteScalar());
            if (pass != "")
            {
                if (pass == txtPassword.Text && usernam == txtUname.Text)
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error!!");
                    txtUname.Text = "";
                    txtPassword.Text = "";
                    txtUname.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter Password", "Information!!");
                /// txtUname.Text = "";
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }
    }
}
