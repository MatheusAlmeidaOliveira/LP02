using System;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            posicao = txtPalavra2.Text.ToUpper().IndexOf(txtPalavra1.Text.ToUpper());

            while (posicao >=0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = "";
            foreach (char c in arr)
            {
                s = s + c.ToString();
            }
            MessageBox.Show(s);
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.ToUpper().Replace(txtPalavra1.Text.ToUpper(), "");
        }
    }
}
