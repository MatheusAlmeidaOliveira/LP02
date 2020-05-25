using System;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0,count=0;

            while (x < rchtxtTexto.Text.Length)
            {
                if (char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    count++;
                }
                x += 1;
            }
            MessageBox.Show($"Tem {count} espaços em branco na frase ");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int count = 0;
            char letra = 'R';

            foreach (char itemR in rchtxtTexto.Text.ToUpper())
            {
                if (itemR.Equals(letra))
                    count++;
            }
            MessageBox.Show($"O número de letra(s) R é de {count}");
        }

        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string a = rchtxtTexto.Text.ToUpper();
            char[] word = a.ToCharArray();

            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i].Equals(word[i+1]))
                {
                    contador++;
                }
            }
            MessageBox.Show($"A quantidade de pares de letras na frase é de {contador}");
        }
    }
}
