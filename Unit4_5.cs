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
    public partial class Unit4_5 : Form
    {


        public static SqlConnection cn = new SqlConnection();
        public static SqlDataAdapter da = new SqlDataAdapter("select * from Emp", cn);
        DataSet ds = new DataSet();
        SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);

        int pos;
        Boolean addmode;
        public Unit4_5()
        {
            InitializeComponent();
        }
        private void Unit4_5_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BookDetails;Integrated Security=True";
            cn.Open();
            da.Fill(ds, "Emp");
            pos = 0;
            showData();
        }
        private void showData()
        {
            txtEmpno.Text = ds.Tables[0].Rows[pos].ItemArray[0].ToString();
            txtEmpname.Text = ds.Tables[0].Rows[pos].ItemArray[1].ToString();
            txtsalary.Text = ds.Tables[0].Rows[pos].ItemArray[2].ToString();
            txtbirthdate.Text = ds.Tables[0].Rows[pos].ItemArray[3].ToString();
            txtdesignation.Text = ds.Tables[0].Rows[pos].ItemArray[4].ToString();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData();
            }
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (pos < ds.Tables[0].Rows.Count - 1)
            {
                pos = pos + 1;
                showData();
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = ds.Tables[0].Rows.Count - 1;
            showData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select max(Eno) from Emp";
            cmd.Connection = cn;
            int eno = Convert.ToInt16(cmd.ExecuteScalar());
            eno = eno + 1;
            txtEmpno.Text = eno.ToString();
            txtEmpname.Text = "";
            txtsalary.Text = "";
            txtbirthdate.Text = "";
            txtdesignation.Text = "";
            txtEmpname.Focus();         
            addmode = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addmode == true)//First time recored is inserted.
            {
                 DataRow dr = ds.Tables[0].NewRow();
                dr[0] = txtEmpno.Text;
                dr[1] = txtEmpname.Text;
                dr[2] = txtsalary.Text;
                dr[3] = txtbirthdate.Text;
                dr[4] = txtdesignation.Text;
                ds.Tables[0].Rows.Add(dr);
                da.Update(ds, "Emp");
                addmode = false;
                MessageBox.Show("Record inserted successfully");
            }
            else  // Make updation in old record.
            {
                DataRow dr = ds.Tables[0].Rows[pos];
                dr[0] = txtEmpno.Text;
                dr[1] = txtEmpname.Text;
                dr[2] = txtsalary.Text;
                dr[3] = txtbirthdate.Text;
                dr[4] = txtdesignation.Text;
                // ds.Tables[0].Rows.Add(dr);
                da.Update(ds, "Emp");
                MessageBox.Show("Record updated successfully");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Are you sure? Do you want to delete this record?", "Confirm!!",
                MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                ds.Tables[0].Rows[pos].Delete();
                da.Update(ds, "Emp");
                pos = 0;
                showData();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
