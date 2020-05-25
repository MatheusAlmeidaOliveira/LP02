using System;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            frmExercicio1 frm = new frmExercicio1();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            frmExercicio2 frm = new frmExercicio2();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            frmExercicio3 frm = new frmExercicio3();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            frmExercicio4 frm = new frmExercicio4();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
