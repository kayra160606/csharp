using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void unit41ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unit4_1 frm1 = new Unit4_1();
            frm1.MdiParent = this;
            frm1.Show();
        }
        private void unit43ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unit4_3 frm3 = new Unit4_3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            frm.Close(); // close the active MDI child form
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // close the MDI form
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
