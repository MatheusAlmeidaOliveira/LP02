using System;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            string s = txtFrase.Text.Replace(" ", "").ToUpper();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = "";
            foreach (char c in arr)
            {
                s = s + c.ToString();
            }

            string palavra = txtFrase.Text.Replace(" ", "").ToUpper();

            if (s.Equals(palavra))
            {
                MessageBox.Show($"{s}, É um palíndromo");
            }
            else
                MessageBox.Show("Não é um palíndromo");
        }
    }
}
