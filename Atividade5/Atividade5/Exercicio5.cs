using System;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            int numero = objRandom.Next(Convert.ToInt32(txtNumero1.Text),
                Convert.ToInt32(txtNumero2.Text));

            MessageBox.Show("O numero sorteado é: " + numero);
        }
    }
}
