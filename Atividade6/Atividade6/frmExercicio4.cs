using System;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCargo.Text == "" || txtGratificacao.Text == "" || txtInscricao.Text == "" || txtProducao.Text == "" || txtSalario.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios");
            }
            else
            {
                double pro = Convert.ToDouble(txtProducao.Text);
                double A = Convert.ToDouble(txtSalario.Text);
                double B = 0, C = 0, D = 0;
                double grati = Convert.ToDouble(txtGratificacao.Text);

                if (pro >= 100)
                    B = 1;
                else
                    B = 0;

                if (pro >= 120)
                    C = 1;
                else
                    C = 0;

                if (pro >= 150)
                    D = 1;
                else
                    D = 0;

                double bruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + grati;

                if (bruto > 7000.00)
                {
                    if (pro >= 150 && grati > 0)
                    {
                        MessageBox.Show($"O salario bruto é de R$ {bruto.ToString("0.00")}");
                    }
                    else
                    {
                        bruto = 7000.00;
                        MessageBox.Show($"O salario bruto é de R$ {bruto.ToString("0.00")}");
                    }
                }
                else
                {
                    MessageBox.Show($"O salario bruto é de R$ {bruto.ToString("0.00")}");
                }
            }
        }
    }
}
