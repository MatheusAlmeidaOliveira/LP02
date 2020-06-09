namespace Atividade7
{
    partial class Form1
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
            this.btnLer20Num = new System.Windows.Forms.Button();
            this.btnUsandoReverse = new System.Windows.Forms.Button();
            this.btnMercadorias = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnListaAlunos = new System.Windows.Forms.Button();
            this.btnNotasAlunos = new System.Windows.Forms.Button();
            this.btnExercicio7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLer20Num
            // 
            this.btnLer20Num.Location = new System.Drawing.Point(95, 59);
            this.btnLer20Num.Name = "btnLer20Num";
            this.btnLer20Num.Size = new System.Drawing.Size(104, 46);
            this.btnLer20Num.TabIndex = 0;
            this.btnLer20Num.Text = "Ler 20 numeros (Exercicio 1)";
            this.btnLer20Num.UseVisualStyleBackColor = true;
            this.btnLer20Num.Click += new System.EventHandler(this.btnLer20Num_Click);
            // 
            // btnUsandoReverse
            // 
            this.btnUsandoReverse.Location = new System.Drawing.Point(238, 59);
            this.btnUsandoReverse.Name = "btnUsandoReverse";
            this.btnUsandoReverse.Size = new System.Drawing.Size(112, 46);
            this.btnUsandoReverse.TabIndex = 1;
            this.btnUsandoReverse.Text = "Usando o reverse (Exercicio 2)";
            this.btnUsandoReverse.UseVisualStyleBackColor = true;
            this.btnUsandoReverse.Click += new System.EventHandler(this.btnUsandoReverse_Click);
            // 
            // btnMercadorias
            // 
            this.btnMercadorias.Location = new System.Drawing.Point(95, 138);
            this.btnMercadorias.Name = "btnMercadorias";
            this.btnMercadorias.Size = new System.Drawing.Size(104, 45);
            this.btnMercadorias.TabIndex = 2;
            this.btnMercadorias.Text = "Mercadorias (Exercicio 3)";
            this.btnMercadorias.UseVisualStyleBackColor = true;
            this.btnMercadorias.Click += new System.EventHandler(this.btnMercadorias_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(238, 138);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(112, 45);
            this.btnAlunos.TabIndex = 3;
            this.btnAlunos.Text = "Alunos(Exercicio 4)";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnListaAlunos
            // 
            this.btnListaAlunos.Location = new System.Drawing.Point(95, 205);
            this.btnListaAlunos.Name = "btnListaAlunos";
            this.btnListaAlunos.Size = new System.Drawing.Size(104, 46);
            this.btnListaAlunos.TabIndex = 4;
            this.btnListaAlunos.Text = "Lista de Aluno (Exercicio 5)";
            this.btnListaAlunos.UseVisualStyleBackColor = true;
            this.btnListaAlunos.Click += new System.EventHandler(this.btnListaAlunos_Click);
            // 
            // btnNotasAlunos
            // 
            this.btnNotasAlunos.Location = new System.Drawing.Point(238, 205);
            this.btnNotasAlunos.Name = "btnNotasAlunos";
            this.btnNotasAlunos.Size = new System.Drawing.Size(112, 46);
            this.btnNotasAlunos.TabIndex = 5;
            this.btnNotasAlunos.Text = "Notas Alunos (Exercicio 6)";
            this.btnNotasAlunos.UseVisualStyleBackColor = true;
            this.btnNotasAlunos.Click += new System.EventHandler(this.btnNotasAlunos_Click);
            // 
            // btnExercicio7
            // 
            this.btnExercicio7.Location = new System.Drawing.Point(172, 274);
            this.btnExercicio7.Name = "btnExercicio7";
            this.btnExercicio7.Size = new System.Drawing.Size(99, 45);
            this.btnExercicio7.TabIndex = 6;
            this.btnExercicio7.Text = "Exercicio 7";
            this.btnExercicio7.UseVisualStyleBackColor = true;
            this.btnExercicio7.Click += new System.EventHandler(this.btnExercicio7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 349);
            this.Controls.Add(this.btnExercicio7);
            this.Controls.Add(this.btnNotasAlunos);
            this.Controls.Add(this.btnListaAlunos);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.btnMercadorias);
            this.Controls.Add(this.btnUsandoReverse);
            this.Controls.Add(this.btnLer20Num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLer20Num;
        private System.Windows.Forms.Button btnUsandoReverse;
        private System.Windows.Forms.Button btnMercadorias;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnListaAlunos;
        private System.Windows.Forms.Button btnNotasAlunos;
        private System.Windows.Forms.Button btnExercicio7;
    }
}

