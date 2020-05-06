using System;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(mtxAltura.Text);

            if (rbtFeminino.Checked)
            {
                double result = 62.1 * altura - 44.7;
                double peso = Convert.ToDouble(mtxPeso.Text);
                if (peso > result)
                {
                    MessageBox.Show("Regime Obrigatório Já");
                }
                else if (peso < result)
                {
                    MessageBox.Show("Coma bastante massas e doces");
                }
                else
                {
                    MessageBox.Show("Você está com o peso ideal");
                }
            }
            else if (rbtMasculino.Checked)
            {
                double result = 72.7 * altura - 58;
                double peso = Convert.ToDouble(mtxPeso.Text);
                if (peso > result)
                {
                    MessageBox.Show("Regime Obrigatório Já");
                }
                else if (peso < result)
                {
                    MessageBox.Show("Coma bastante massas e doces");
                }
                else
                {
                    MessageBox.Show("Você está com o peso ideal");
                }
            }
        }
    }
}
