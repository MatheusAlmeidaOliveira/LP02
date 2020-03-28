using System;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Triângulo : Form
    {
        public Triângulo()
        {
            InitializeComponent();
        }

        #region ValidaText

        private void txtValorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion

        private void LimpaText()
        {
            txtValorA.Text = "";
            txtValorB.Text = "";
            txtValorC.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtValorA.Text == "" || txtValorB.Text == "" || txtValorC.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }
            else
            {
                var valorA = Convert.ToDouble(txtValorA.Text);
                var valorB = Convert.ToDouble(txtValorB.Text);
                var valorC = Convert.ToDouble(txtValorC.Text);

                if (valorB - valorC < valorA && valorB + valorC > valorA)
                {
                    if (valorA - valorC < valorB && valorA + valorC > valorB)
                    {
                        if (valorA - valorB < valorC && valorA + valorB > valorC)
                        {
                            if (valorA == valorB && valorA == valorC)
                            {
                                lblTexto.Text = "Triângulo Equilátero";
                            }
                            else if (valorA == valorB || valorB == valorC || valorC == valorA)
                            {
                                lblTexto.Text = "Triângulo Isóceles";
                            }
                            else if (!(valorA == valorB && valorA == valorC))
                            {
                                lblTexto.Text = "Triângulo Escaleno";
                            }
                        }
                    }

                    LimpaText();
                }
                else
                {
                    lblTexto.Text = "Os valores informados não podem pertencer à um triângulo.";
                    LimpaText();
                }
            }
            
        }
    }
}