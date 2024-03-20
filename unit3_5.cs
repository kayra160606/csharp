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
    public partial class unit3_5 : Form
    {
        class ProductItem
        {
            public int pcode;
            public string pname;
            public int qty;
            public int price;
            public int ordertotal;
        }
        class Invoice
        {
            public int invcode;
            public string custname;
            public DateTime dt;
            public List<ProductItem> PI = new List<ProductItem>();

            public void  AddProductItmes(int _pcode, string _pname, int _qty, int _Price)
            {
                ProductItem p = new ProductItem();
                p.pcode = _pcode;
                p.pname = _pname;
                p.qty = _qty;
                p.price = _Price;
                p.ordertotal = _qty * _Price;
                PI.Add(p);
            }

            public ProductItem GetProductItem(int i)
            {
                ProductItem p = PI[i];
                return p;
            }
            public int countProducts()
            {
                int i = PI.Count;
                return i;
            }
        }

        List<Invoice> Invs = new List<Invoice>();
        int pos;
        public unit3_5()
        {
            InitializeComponent();
        }

        private void unit3_5_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 1;
            dataGridView1.Columns[0].HeaderText = "PCode";
            dataGridView1.Columns[1].HeaderText = "PName";
            dataGridView1.Columns[2].HeaderText = "Qty";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].HeaderText = "Order Total";
            pos = 0;
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount - 1;
            dataGridView1.RowCount = dataGridView1.RowCount + 1;
            int OrderTotal = Convert.ToInt16(txtQty.Text) * Convert.ToInt16(txtPrice.Text);
            dataGridView1.Rows[i].Cells[0].Value = txtPcode.Text;
            dataGridView1.Rows[i].Cells[1].Value = txtPName.Text;
            dataGridView1.Rows[i].Cells[2].Value = txtQty.Text;
            dataGridView1.Rows[i].Cells[3].Value = txtPrice.Text;
            dataGridView1.Rows[i].Cells[4].Value = Convert.ToString(OrderTotal);
            txtPcode.Text = "";
            txtPName.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            txtPcode.Focus();
        }

        private void btnSaveInv_Click(object sender, EventArgs e)
        {
            Invoice invobj = new Invoice();
            invobj.invcode = Convert.ToInt16(txtInvNo.Text);
            invobj.custname = (txtCustName.Text);
            invobj.dt = Convert.ToDateTime(txtDOI.Text);
            int i;
            for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int pcode = Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value);
                string pname = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                int qty = Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value);
                int price = Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value);
                invobj.AddProductItmes(pcode, pname, qty, price);
            }
           // invobj.GetProductItem()
            Invs.Add(invobj);
        }
        private void btnCreateInv_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).Text = "";
                }
            }
            txtInvNo.Focus();
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 1;
        }
        private void ShowData()
        {
            Invoice tmp = Invs[pos];
            button1.PerformClick();
            txtInvNo.Text = Convert.ToString(tmp.invcode);
            txtCustName.Text = Convert.ToString(tmp.custname);
            txtDOI.Text = Convert.ToString(tmp.dt);
            int i = 0;
            for (i = 0; i < tmp.PI.Count; i++)
            {
                dataGridView1.RowCount = dataGridView1.Rows.Count + 1;
                dataGridView1.Rows[i].Cells[0].Value = tmp.PI[i].pcode;
                dataGridView1.Rows[i].Cells[1].Value = tmp.PI[i].pname;
                dataGridView1.Rows[i].Cells[2].Value = tmp.PI[i].qty;
                dataGridView1.Rows[i].Cells[3].Value = tmp.PI[i].price;
                dataGridView1.Rows[i].Cells[4].Value = tmp.PI[i].ordertotal;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            pos = 0; ShowData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos -= 1;
                ShowData();
            }          
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pos < Invs.Count - 1)
            {
                pos += 1;
                ShowData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = Invs.Count - 1;
            ShowData();
        }
    }
}

