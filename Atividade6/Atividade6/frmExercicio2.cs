using System;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(txtN.Text);
            double h = 1;

            if (n==1)
            {
                MessageBox.Show("O numero H é igual a 1");
            }
            else
            {
                for (double i = 2; i <= n; i++)
                {
                    h += 1 / i;
                }
                MessageBox.Show($"O numero H é igual a {h}");
            }
            
        }
    }
}
