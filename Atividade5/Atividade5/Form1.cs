using System;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 frm = new frmExercicio2();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void exercio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercico4 frm = new frmExercico4();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void exercio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 frm = new frmExercicio3();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void sairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 frm = new frmExercicio5();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
