namespace ATIVIDADE4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVereficaDesc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mTxtNome = new System.Windows.Forms.MaskedTextBox();
            this.mTxtNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mTxtSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mTxtAliInss = new System.Windows.Forms.MaskedTextBox();
            this.mTxtAliIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mTxtSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mTxtSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDesInss = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDesIrpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtM = new System.Windows.Forms.RadioButton();
            this.rbtF = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de filhos";
            // 
            // lblDados
            // 
            this.lblDados.BackColor = System.Drawing.SystemColors.Window;
            this.lblDados.Location = new System.Drawing.Point(52, 187);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(270, 51);
            this.lblDados.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aliquota INSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aliquota IRPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salario Familia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salario Liquido";
            // 
            // btnVereficaDesc
            // 
            this.btnVereficaDesc.Location = new System.Drawing.Point(150, 153);
            this.btnVereficaDesc.Name = "btnVereficaDesc";
            this.btnVereficaDesc.Size = new System.Drawing.Size(111, 23);
            this.btnVereficaDesc.TabIndex = 15;
            this.btnVereficaDesc.Text = "Verifica Desconto";
            this.btnVereficaDesc.UseVisualStyleBackColor = true;
            this.btnVereficaDesc.Click += new System.EventHandler(this.btnVereficaDesc_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Desconto INSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Desconto IRPF";
            // 
            // mTxtNome
            // 
            this.mTxtNome.Location = new System.Drawing.Point(183, 40);
            this.mTxtNome.Name = "mTxtNome";
            this.mTxtNome.Size = new System.Drawing.Size(100, 20);
            this.mTxtNome.TabIndex = 20;
            // 
            // mTxtNumFilhos
            // 
            this.mTxtNumFilhos.Location = new System.Drawing.Point(183, 110);
            this.mTxtNumFilhos.Mask = "00";
            this.mTxtNumFilhos.Name = "mTxtNumFilhos";
            this.mTxtNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.mTxtNumFilhos.TabIndex = 21;
            // 
            // mTxtSalBruto
            // 
            this.mTxtSalBruto.Location = new System.Drawing.Point(183, 72);
            this.mTxtSalBruto.Name = "mTxtSalBruto";
            this.mTxtSalBruto.Size = new System.Drawing.Size(100, 20);
            this.mTxtSalBruto.TabIndex = 22;
            // 
            // mTxtAliInss
            // 
            this.mTxtAliInss.Enabled = false;
            this.mTxtAliInss.Location = new System.Drawing.Point(150, 260);
            this.mTxtAliInss.Name = "mTxtAliInss";
            this.mTxtAliInss.Size = new System.Drawing.Size(100, 20);
            this.mTxtAliInss.TabIndex = 23;
            // 
            // mTxtAliIrpf
            // 
            this.mTxtAliIrpf.Enabled = false;
            this.mTxtAliIrpf.Location = new System.Drawing.Point(150, 294);
            this.mTxtAliIrpf.Name = "mTxtAliIrpf";
            this.mTxtAliIrpf.Size = new System.Drawing.Size(100, 20);
            this.mTxtAliIrpf.TabIndex = 24;
            // 
            // mTxtSalFamilia
            // 
            this.mTxtSalFamilia.Enabled = false;
            this.mTxtSalFamilia.Location = new System.Drawing.Point(150, 326);
            this.mTxtSalFamilia.Name = "mTxtSalFamilia";
            this.mTxtSalFamilia.Size = new System.Drawing.Size(100, 20);
            this.mTxtSalFamilia.TabIndex = 25;
            // 
            // mTxtSalLiquido
            // 
            this.mTxtSalLiquido.Enabled = false;
            this.mTxtSalLiquido.Location = new System.Drawing.Point(150, 360);
            this.mTxtSalLiquido.Name = "mTxtSalLiquido";
            this.mTxtSalLiquido.Size = new System.Drawing.Size(100, 20);
            this.mTxtSalLiquido.TabIndex = 26;
            // 
            // mTxtDesInss
            // 
            this.mTxtDesInss.Enabled = false;
            this.mTxtDesInss.Location = new System.Drawing.Point(430, 249);
            this.mTxtDesInss.Name = "mTxtDesInss";
            this.mTxtDesInss.Size = new System.Drawing.Size(100, 20);
            this.mTxtDesInss.TabIndex = 27;
            // 
            // mTxtDesIrpf
            // 
            this.mTxtDesIrpf.Enabled = false;
            this.mTxtDesIrpf.Location = new System.Drawing.Point(430, 294);
            this.mTxtDesIrpf.Name = "mTxtDesIrpf";
            this.mTxtDesIrpf.Size = new System.Drawing.Size(100, 20);
            this.mTxtDesIrpf.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtM);
            this.groupBox1.Controls.Add(this.rbtF);
            this.groupBox1.Location = new System.Drawing.Point(372, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtM
            // 
            this.rbtM.AutoSize = true;
            this.rbtM.Location = new System.Drawing.Point(17, 70);
            this.rbtM.Name = "rbtM";
            this.rbtM.Size = new System.Drawing.Size(34, 17);
            this.rbtM.TabIndex = 1;
            this.rbtM.TabStop = true;
            this.rbtM.Text = "M";
            this.rbtM.UseVisualStyleBackColor = true;
            // 
            // rbtF
            // 
            this.rbtF.AutoSize = true;
            this.rbtF.Location = new System.Drawing.Point(17, 28);
            this.rbtF.Name = "rbtF";
            this.rbtF.Size = new System.Drawing.Size(31, 17);
            this.rbtF.TabIndex = 0;
            this.rbtF.TabStop = true;
            this.rbtF.Text = "F";
            this.rbtF.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCasado);
            this.groupBox2.Location = new System.Drawing.Point(372, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 70);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(17, 33);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(62, 17);
            this.chkCasado.TabIndex = 0;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mTxtDesIrpf);
            this.Controls.Add(this.mTxtDesInss);
            this.Controls.Add(this.mTxtSalLiquido);
            this.Controls.Add(this.mTxtSalFamilia);
            this.Controls.Add(this.mTxtAliIrpf);
            this.Controls.Add(this.mTxtAliInss);
            this.Controls.Add(this.mTxtSalBruto);
            this.Controls.Add(this.mTxtNumFilhos);
            this.Controls.Add(this.mTxtNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVereficaDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcula Tributo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVereficaDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mTxtNome;
        private System.Windows.Forms.MaskedTextBox mTxtNumFilhos;
        private System.Windows.Forms.MaskedTextBox mTxtSalBruto;
        private System.Windows.Forms.MaskedTextBox mTxtAliInss;
        private System.Windows.Forms.MaskedTextBox mTxtAliIrpf;
        private System.Windows.Forms.MaskedTextBox mTxtSalFamilia;
        private System.Windows.Forms.MaskedTextBox mTxtSalLiquido;
        private System.Windows.Forms.MaskedTextBox mTxtDesInss;
        private System.Windows.Forms.MaskedTextBox mTxtDesIrpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtM;
        private System.Windows.Forms.RadioButton rbtF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCasado;
    }
}

