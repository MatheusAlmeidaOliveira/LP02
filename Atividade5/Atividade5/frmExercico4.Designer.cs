namespace Atividade5
{
    partial class frmExercico4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNumerico = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfebetico = new System.Windows.Forms.Button();
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNumerico
            // 
            this.btnNumerico.Location = new System.Drawing.Point(83, 236);
            this.btnNumerico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNumerico.Name = "btnNumerico";
            this.btnNumerico.Size = new System.Drawing.Size(91, 57);
            this.btnNumerico.TabIndex = 0;
            this.btnNumerico.Text = "Caracter Numerico";
            this.btnNumerico.UseVisualStyleBackColor = true;
            this.btnNumerico.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(193, 236);
            this.btnBranco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(101, 57);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Primeiro Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfebetico
            // 
            this.btnAlfebetico.Location = new System.Drawing.Point(308, 236);
            this.btnAlfebetico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlfebetico.Name = "btnAlfebetico";
            this.btnAlfebetico.Size = new System.Drawing.Size(114, 57);
            this.btnAlfebetico.TabIndex = 2;
            this.btnAlfebetico.Text = "Caracteres Alfabeticos";
            this.btnAlfebetico.UseVisualStyleBackColor = true;
            this.btnAlfebetico.Click += new System.EventHandler(this.btnAlfebetico_Click);
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(83, 49);
            this.rchtxtTexto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(327, 126);
            this.rchtxtTexto.TabIndex = 3;
            this.rchtxtTexto.Text = "";
            // 
            // frmExercico4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 373);
            this.Controls.Add(this.rchtxtTexto);
            this.Controls.Add(this.btnAlfebetico);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumerico);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmExercico4";
            this.Text = "Exercico4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumerico;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfebetico;
        private System.Windows.Forms.RichTextBox rchtxtTexto;
    }
}