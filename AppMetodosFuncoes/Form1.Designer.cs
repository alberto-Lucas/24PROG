namespace AppMetodosFuncoes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIF = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOpcao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.btnFuncao = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtOperacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstLoop = new System.Windows.Forms.ListBox();
            this.btnFor0 = new System.Windows.Forms.Button();
            this.btnFor10 = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDoWhileTeste = new System.Windows.Forms.Button();
            this.btnWhileTeste = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSoNumero = new System.Windows.Forms.Button();
            this.txtSoNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(12, 52);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(75, 23);
            this.btnIF.TabIndex = 4;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(12, 81);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 5;
            this.btnSwitch.Text = "SWITCH";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Opções";
            // 
            // cbxOpcao
            // 
            this.cbxOpcao.FormattingEnabled = true;
            this.cbxOpcao.Items.AddRange(new object[] {
            "Opção 1",
            "Opção 2",
            "Opção 3",
            "Opção 4"});
            this.cbxOpcao.Location = new System.Drawing.Point(12, 25);
            this.cbxOpcao.Name = "cbxOpcao";
            this.cbxOpcao.Size = new System.Drawing.Size(121, 21);
            this.cbxOpcao.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor 1";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(12, 151);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 20);
            this.txtV1.TabIndex = 9;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(12, 197);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 20);
            this.txtV2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor 2";
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(140, 151);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo.TabIndex = 13;
            this.btnMetodo.Text = "METODO";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // btnFuncao
            // 
            this.btnFuncao.Location = new System.Drawing.Point(140, 180);
            this.btnFuncao.Name = "btnFuncao";
            this.btnFuncao.Size = new System.Drawing.Size(75, 23);
            this.btnFuncao.TabIndex = 12;
            this.btnFuncao.Text = "FUNCAO";
            this.btnFuncao.UseVisualStyleBackColor = true;
            this.btnFuncao.Click += new System.EventHandler(this.btnFuncao_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(12, 223);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 15;
            this.btnSoma.Text = "SOMAR";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(12, 252);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 14;
            this.btnSubtrair.Text = "SUBTRAIR";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(12, 280);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 17;
            this.btnMultiplicar.Text = "MULTIPLICAR";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(12, 309);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 16;
            this.btnDividir.Text = "DIVIDIR";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 360);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 19;
            // 
            // txtOperacao
            // 
            this.txtOperacao.Location = new System.Drawing.Point(140, 241);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.Size = new System.Drawing.Size(100, 20);
            this.txtOperacao.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Operação";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(140, 267);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstLoop
            // 
            this.lstLoop.FormattingEnabled = true;
            this.lstLoop.Location = new System.Drawing.Point(425, 12);
            this.lstLoop.Name = "lstLoop";
            this.lstLoop.Size = new System.Drawing.Size(120, 173);
            this.lstLoop.TabIndex = 23;
            // 
            // btnFor0
            // 
            this.btnFor0.Location = new System.Drawing.Point(309, 12);
            this.btnFor0.Name = "btnFor0";
            this.btnFor0.Size = new System.Drawing.Size(94, 23);
            this.btnFor0.TabIndex = 24;
            this.btnFor0.Text = "FOR 0 TO 10";
            this.btnFor0.UseVisualStyleBackColor = true;
            this.btnFor0.Click += new System.EventHandler(this.btnFor0_Click);
            // 
            // btnFor10
            // 
            this.btnFor10.Location = new System.Drawing.Point(309, 41);
            this.btnFor10.Name = "btnFor10";
            this.btnFor10.Size = new System.Drawing.Size(94, 23);
            this.btnFor10.TabIndex = 25;
            this.btnFor10.Text = "FOR 10 TO 0";
            this.btnFor10.UseVisualStyleBackColor = true;
            this.btnFor10.Click += new System.EventHandler(this.btnFor10_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(309, 70);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(94, 23);
            this.btnWhile.TabIndex = 26;
            this.btnWhile.Text = "WHILE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(309, 99);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(94, 23);
            this.btnDoWhile.TabIndex = 27;
            this.btnDoWhile.Text = "DO WHILE";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(309, 128);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 23);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDoWhileTeste
            // 
            this.btnDoWhileTeste.Location = new System.Drawing.Point(565, 41);
            this.btnDoWhileTeste.Name = "btnDoWhileTeste";
            this.btnDoWhileTeste.Size = new System.Drawing.Size(94, 23);
            this.btnDoWhileTeste.TabIndex = 30;
            this.btnDoWhileTeste.Text = "DO WHILE";
            this.btnDoWhileTeste.UseVisualStyleBackColor = true;
            this.btnDoWhileTeste.Click += new System.EventHandler(this.btnDoWhileTeste_Click);
            // 
            // btnWhileTeste
            // 
            this.btnWhileTeste.Location = new System.Drawing.Point(565, 12);
            this.btnWhileTeste.Name = "btnWhileTeste";
            this.btnWhileTeste.Size = new System.Drawing.Size(94, 23);
            this.btnWhileTeste.TabIndex = 29;
            this.btnWhileTeste.Text = "WHILE";
            this.btnWhileTeste.UseVisualStyleBackColor = true;
            this.btnWhileTeste.Click += new System.EventHandler(this.btnWhileTeste_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(425, 225);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 20);
            this.txtValor.TabIndex = 31;
            // 
            // btnSoNumero
            // 
            this.btnSoNumero.Location = new System.Drawing.Point(425, 254);
            this.btnSoNumero.Name = "btnSoNumero";
            this.btnSoNumero.Size = new System.Drawing.Size(94, 23);
            this.btnSoNumero.TabIndex = 32;
            this.btnSoNumero.Text = "SO NUMERO";
            this.btnSoNumero.UseVisualStyleBackColor = true;
            this.btnSoNumero.Click += new System.EventHandler(this.btnSoNumero_Click);
            // 
            // txtSoNumero
            // 
            this.txtSoNumero.Location = new System.Drawing.Point(425, 283);
            this.txtSoNumero.Name = "txtSoNumero";
            this.txtSoNumero.Size = new System.Drawing.Size(120, 20);
            this.txtSoNumero.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 397);
            this.Controls.Add(this.txtSoNumero);
            this.Controls.Add(this.btnSoNumero);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnDoWhileTeste);
            this.Controls.Add(this.btnWhileTeste);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor10);
            this.Controls.Add(this.btnFor0);
            this.Controls.Add(this.lstLoop);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtOperacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.btnFuncao);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxOpcao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnIF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxOpcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Button btnFuncao;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtOperacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstLoop;
        private System.Windows.Forms.Button btnFor0;
        private System.Windows.Forms.Button btnFor10;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDoWhileTeste;
        private System.Windows.Forms.Button btnWhileTeste;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSoNumero;
        private System.Windows.Forms.TextBox txtSoNumero;
    }
}

