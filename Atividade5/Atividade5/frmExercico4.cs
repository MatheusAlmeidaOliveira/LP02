using System;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class frmExercico4 : Form
    {
        public frmExercico4()
        {
            InitializeComponent();
        }

        private void btnNumerico_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var x = 0; x <= rchtxtTexto.Text.Length-1; x++)
            {
                if (char.IsNumber(rchtxtTexto.Text[x]))
                {
                    contador += 1;
                }
            }

            MessageBox.Show("Caracteres numericos " + contador);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;

            while (x<rchtxtTexto.Text.Length)
            {
                if (char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro caracter branco: " + (x+1));
                    break;
                }
                x += 1;
            }
        }

        private void btnAlfebetico_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char c in rchtxtTexto.Text)
            {
                if (char.IsLetter(c))
                {
                    contador += 1;
                }
            }
            MessageBox.Show("Caracteres Alfabeticos: " + contador);
        }
    }
}
