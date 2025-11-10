using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_02_714240061
{
    public partial class ParentForm1 : Form
    {
        public ParentForm1()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CascadeMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ParentForm1_Load(object sender, EventArgs e)
        {

        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildFrom newChild = new ChildFrom();
            newChild.MdiParent = this;
            newChild.Show();
        }
    }
}
