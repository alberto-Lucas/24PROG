namespace AppTipoDados
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
            this.btnCliqueAqui = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbBeber = new System.Windows.Forms.CheckBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliqueAqui
            // 
            this.btnCliqueAqui.Location = new System.Drawing.Point(47, 93);
            this.btnCliqueAqui.Name = "btnCliqueAqui";
            this.btnCliqueAqui.Size = new System.Drawing.Size(75, 23);
            this.btnCliqueAqui.TabIndex = 0;
            this.btnCliqueAqui.Text = "Clique aqui";
            this.btnCliqueAqui.UseVisualStyleBackColor = true;
            this.btnCliqueAqui.Click += new System.EventHandler(this.btnCliqueAqui_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(37, 21);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Você bebe?";
            // 
            // ckbBeber
            // 
            this.ckbBeber.AutoSize = true;
            this.ckbBeber.Location = new System.Drawing.Point(83, 48);
            this.ckbBeber.Name = "ckbBeber";
            this.ckbBeber.Size = new System.Drawing.Size(15, 14);
            this.ckbBeber.TabIndex = 3;
            this.ckbBeber.UseVisualStyleBackColor = true;
            this.ckbBeber.CheckedChanged += new System.EventHandler(this.ckbBeber_CheckedChanged);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(47, 122);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 4;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Location = new System.Drawing.Point(12, 61);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(55, 13);
            this.lblRetorno.TabIndex = 5;
            this.lblRetorno.Text = "lblRetorno";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(256, 95);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.Text = "123";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(256, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Mostrar senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(256, 40);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(269, 144);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 285);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblRetorno);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.ckbBeber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.btnCliqueAqui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliqueAqui;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbBeber;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEntrar;
    }
}

