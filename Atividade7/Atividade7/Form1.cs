using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace Atividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLer20Num_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            int x = 0;
            string auxiliar = "";
            string valor = "";

            for (x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado" + (x+1),
                "Entrada de dados");

                if (int.TryParse(valor, out vetor[x]))
                {
                    //auxiliar = auxiliar + "\n" + vetor[x].ToString(); //Crescente
                    auxiliar = vetor[x].ToString() + "\n" + auxiliar; //Decrescente

                }
                else
                {
                    MessageBox.Show("Número Inválido");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void btnUsandoReverse_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            int x = 0;
            string auxiliar = "";
            string valor = "";

            for (x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado: " + (x + 1),
                "Entrada de dados");

                if (!int.TryParse(valor, out vetor[x]))
                {
                    MessageBox.Show("Número Inválido!");
                    x--;
                }
            }
            Array.Reverse(vetor);

            for (x = 0; x < 20; x++)
                auxiliar += vetor[x] + "\n";

            MessageBox.Show(auxiliar);
        }

        private void btnMercadorias_Click(object sender, EventArgs e)
        {
            double[] vetor1 = new double[10];
            double[] vetor2 = new double[10];
            string quantidade = "";
            string valor = "";
            double faturamentoMensal = 0;


            for (int i = 0; i < 10; i++)
            {
                quantidade = Interaction.InputBox("Digite a quantidade vendida do produto " + (i+1),
                    "Entrada de dados");

                if (!double.TryParse(quantidade, out vetor1[i]))
                {
                    MessageBox.Show("Digite uma quantidade valida!");
                    i--;
                }
                else
                {
                    while (vetor2[i]<0)
                    {
                        valor = Interaction.InputBox("Digite o preço vendido do produto " + (i + 1),
                            "Entrada de dados");
                        if (!double.TryParse(valor, out vetor2[i]))
                        {
                            MessageBox.Show("Valor inválido");
                            vetor2[i] = - 1;
                        }
                    }
                    faturamentoMensal += vetor2[i] * vetor1[i];
                }
            }
            //double faturamentoMensal = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    faturamentoMensal += vetor2[i] * vetor1[i];
            //}
            MessageBox.Show($"O faturamento do mês foi de {faturamentoMensal}");
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
                "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }

            MessageBox.Show(Total.ToString());
        }

        private void btnListaAlunos_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();

            lista.Add("Ana");
            lista.Add("André");
            lista.Add("Débora");
            lista.Add("Fátima");
            lista.Add("João");
            lista.Add("Janete");
            lista.Add("Otávio");
            lista.Add("Marcelo");
            lista.Add("Pedro");
            lista.Add("Thais");

            lista.Remove("Otávio");

            foreach (string item in lista)
            {
                MessageBox.Show(item);
            }
        }

        private void btnNotasAlunos_Click(object sender, EventArgs e)
        {
            double[,] notasAlunos = new double[20, 3];
            String notas = "";
            double soma = 0,media = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    notas = Interaction.InputBox($"Digite a nota {j+1} do Aluno " + (i + 1),
                    "Entrada de dados");

                    double.TryParse(notas, out notasAlunos[i, j]);
                    soma += Convert.ToDouble(notas);                    
                }
                media = soma / 3;
                MessageBox.Show($"Aluno {i+1}: média: {media}");
                media = 0;
                soma = 0;
            }
        }

        private void btnExercicio7_Click(object sender, EventArgs e)
        {
            frmExercicio7 frm = new frmExercicio7();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
