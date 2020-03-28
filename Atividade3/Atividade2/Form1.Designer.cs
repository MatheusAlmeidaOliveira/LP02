namespace Atividade2
{
    partial class Triângulo
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
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorC = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(101, 66);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 20);
            this.txtValorB.TabIndex = 1;
            this.txtValorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorB_KeyPress);
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(101, 30);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 20);
            this.txtValorA.TabIndex = 0;
            this.txtValorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorA_KeyPress);
            // 
            // txtValorC
            // 
            this.txtValorC.Location = new System.Drawing.Point(101, 100);
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(100, 20);
            this.txtValorC.TabIndex = 2;
            this.txtValorC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorC_KeyPress);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(21, 33);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(74, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Primeiro Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Terceiro Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segundo Valor:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(76, 141);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.SystemColors.Window;
            this.lblTexto.Location = new System.Drawing.Point(21, 182);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(190, 37);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Triângulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 240);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtValorC);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.txtValorB);
            this.Name = "Triângulo";
            this.Text = "Analisa Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTexto;
    }
}

