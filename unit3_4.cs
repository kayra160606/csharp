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
    public partial class unit3_4 : Form
    {
        class Book
        {
            int bookid;
            string title;
            Single price;
            public void getdata(int bid)
            {
                bookid = bid;
            }
            public void getdata(int bid, string btitle)
            {
                bookid = bid;
                title = btitle;
            }
            public void getdata(int bid, string btitle, Single bprice)
            {
                bookid = bid;
                title = btitle;
                price = bprice;
            }
            public string showdata()
            {
                string str;
                str = "bookId : " + bookid + "\ntitle: " + title + "\nPrice : " + price;
                return str;
            }
        }
        public unit3_4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Book obj = new Book();
            obj.getdata(1);
            MessageBox.Show(obj.showdata());
            obj.getdata(1,"C#");
            MessageBox.Show(obj.showdata());
            obj.getdata(1,"C#",550);
            MessageBox.Show(obj.showdata());
        }
    }
}
