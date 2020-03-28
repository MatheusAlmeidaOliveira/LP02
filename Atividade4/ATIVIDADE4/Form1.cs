using System;
using System.Windows.Forms;

namespace ATIVIDADE4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVereficaDesc_Click(object sender, EventArgs e)
        {
            if (mTxtNome.Text == "" || mTxtNumFilhos.Text == "" || mTxtSalBruto.Text == "" || !rbtF.Checked && !rbtM.Checked)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
            else
            {
                double salBruto = double.Parse(mTxtSalBruto.Text);
                double descontoInss = 0;

                //Aliquota INSS
                if (salBruto <= 800.47)
                {
                    mTxtAliInss.Text = "7,65%";
                    descontoInss = 7.65 / 100 * salBruto;
                    mTxtDesInss.Text = descontoInss.ToString("0.00");
                }
                else if (salBruto >= 800.48 && salBruto <= 1050.00)
                {
                    mTxtAliInss.Text = "8,65%";
                    descontoInss = 8.65 / 100 * salBruto;
                    mTxtDesInss.Text = descontoInss.ToString("0.00");
                }
                else if (salBruto >= 1050.01 && salBruto <= 1400.77)
                {
                    mTxtAliInss.Text = "9,00%";
                    descontoInss = 9.00 / 100 * salBruto;
                    mTxtDesInss.Text = descontoInss.ToString("0.00");
                }
                else if (salBruto >= 1400.78 && salBruto <= 2801.56)
                {
                    mTxtAliInss.Text = "11,00%";
                    descontoInss = 11.00 / 100 * salBruto;
                    mTxtDesInss.Text = descontoInss.ToString("0.00");
                }
                else
                {
                    mTxtAliInss.Text = "308,17 (teto)";
                    descontoInss = 308.17;
                    mTxtDesInss.Text = "308,17";
                }

                double descontoIfpf;

                //Aliquota IRPF
                if (salBruto <= 1257.12)
                {
                    mTxtAliIrpf.Text = "Isento";
                    descontoIfpf = 0.00;
                    mTxtDesIrpf.Text = descontoIfpf.ToString("0.00");
                }
                else if (salBruto >= 1257.12 && salBruto <= 2512.08)
                {
                    mTxtAliIrpf.Text = "15,00%";
                    descontoIfpf = 15.00 / 100 * salBruto;
                    mTxtDesIrpf.Text = descontoIfpf.ToString("0.00");
                }
                else
                {
                    mTxtAliIrpf.Text = "27,5%";
                    descontoIfpf = 27.5 / 100 * salBruto;
                    mTxtDesIrpf.Text = descontoIfpf.ToString("0.00");
                }

                short numerofilhos = Convert.ToInt16(mTxtNumFilhos.Text);
                double salFamilia;

                //Salario Família
                if (salBruto <= 435.52)
                {
                    salFamilia = numerofilhos * 22.33;
                    mTxtSalFamilia.Text = Convert.ToString(salFamilia);
                }
                else if (salBruto >= 435.53 && salBruto <= 654.61)
                {
                    salFamilia = numerofilhos * 15.74;
                    mTxtSalFamilia.Text = Convert.ToString(salFamilia);
                }
                else
                {
                    mTxtSalFamilia.Text = "0,00";
                    salFamilia = 0.00;
                }

                //Salário Líquido
                double salLiquido = salBruto - descontoInss - descontoIfpf + salFamilia;
                mTxtSalLiquido.Text = salLiquido.ToString("0.00");

                //CheckBox Casado
                string casadoOuSolteiro;

                if (chkCasado.Checked == true)
                {
                    casadoOuSolteiro = "Casado(a)";
                }
                else
                {
                    casadoOuSolteiro = "Solteiro(a)";
                }

                //Label dados 
                lblDados.Text = $"Os descontos do salário do(a) Sr(a).{mTxtNome.Text} que é {casadoOuSolteiro} \ne que tem {mTxtNumFilhos.Text} filho(s) são";
            }
        }
    }
}
