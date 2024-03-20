using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit3
{
    public partial class unit3_7 : Form
    {
        public unit3_7()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // refreshListbox();
            listBox1.Items.Clear();
            String[] df = new String[] { };
            df = Directory.GetFileSystemEntries(comboBox1.SelectedItem.ToString(), "*.*");
            listBox1.Items.AddRange(df);
        }
        private void unit3_7_Load(object sender, EventArgs e)
        {
            String[] drvs = new String[] { };
            drvs = System.IO.Directory.GetLogicalDrives();
            foreach (String str in drvs)
            {
                comboBox1.Items.Add(str);
            }
        }
        private void refreshListbox()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            String[] dirs = new String[] { };
            dirs = System.IO.Directory.GetDirectories(label2.Text);
            foreach (String str in dirs)
            {
                listBox1.Items.Add(str);
            }
            string[] files;
            files = System.IO.Directory.GetFiles(label2.Text);
            foreach (String str in dirs)
            {
                listBox2.Items.Add(str);
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedItem.ToString();
            refreshListbox();
        }
    }
}
