using System;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var raio = Convert.ToDouble(txtRaio.Text);
            var altura = Convert.ToDouble(txtAltura.Text);
            var volume = Math.PI * Math.Pow(raio, 2) * altura;
            lblVolume.Text = Convert.ToString(volume);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Clear();
            txtAltura.Clear();
            lblVolume.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
