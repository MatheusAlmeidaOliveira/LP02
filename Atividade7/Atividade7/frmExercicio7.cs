using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade7
{
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            String[] nomes;
            nomes = new string[2];
            int[] valor = new int[2];

            nomes[0] = Interaction.InputBox(" Digite o nome da pessoa 1 completo: ").Replace(" ", "").ToUpper();
            nomes[1] = Interaction.InputBox(" Digite o nome da pessoa 2 completo: ").Replace(" ", "").ToUpper();

            for (int i = 0; i < 2; i++)
            {
                valor[i] = nomes[i].Length;
                lstNomes.Items.Add($"nome: {nomes[i]} tem {valor[i]} caracteres");
            }
            

        }
    }
}
