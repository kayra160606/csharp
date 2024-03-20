using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Unit4
{
    public partial class Unit4_1 : Form
    {
        public Unit4_1()
        {
            InitializeComponent();
        }
        public static SqlConnection cn = new SqlConnection();
        public static SqlDataAdapter da = new SqlDataAdapter("select * from Book", cn);
        DataSet ds = new DataSet();
        SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);

        int pos;
        Boolean addmode;
        private void Form1_Load(object sender, EventArgs e)
        {
            //cn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0; DataSource=E:\\Kameshwar college\\BookDetails\\library.mdb";
            cn.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BookDetails;Integrated Security=True";
            cn.Open();
            da.Fill(ds, "Book");
            pos = 0;
            showData();
        }
        private void showData()
        {
            txtbookid.Text = ds.Tables[0].Rows[pos].ItemArray[0].ToString();
            txtbookname.Text = ds.Tables[0].Rows[pos].ItemArray[1].ToString();
            txtauther.Text = ds.Tables[0].Rows[pos].ItemArray[2].ToString();
            txtqty.Text = ds.Tables[0].Rows[pos].ItemArray[3].ToString();
            txtprice.Text = ds.Tables[0].Rows[pos].ItemArray[4].ToString();
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
            txtbookid.Text = "";
            txtbookname.Text = "";
            txtauther.Text = "";
            txtqty.Text = "";
            txtprice.Text = "";
            txtbookid.Focus();
            addmode = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addmode == true)//First time recored is inserted.
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = txtbookid.Text;
                dr[1] = txtbookname.Text;
                dr[2] = txtauther.Text;
                dr[3] = txtqty.Text;
                dr[4] = txtprice.Text;
                ds.Tables[0].Rows.Add(dr);
                da.Update(ds, "Book");
                addmode = false;
                MessageBox.Show("Record inserted successfully");
            }
            else  // Make updation in old record.
            {
                DataRow dr = ds.Tables[0].Rows[pos];
                dr[0] = txtbookid.Text;
                dr[1] = txtbookname.Text;
                dr[2] = txtauther.Text;
                dr[3] = txtqty.Text;
                dr[4] = txtprice.Text;
                // ds.Tables[0].Rows.Add(dr);
                da.Update(ds, "Book");
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
                da.Update(ds, "Book");
                pos = 0;
                showData();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}