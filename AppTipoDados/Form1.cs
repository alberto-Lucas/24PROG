using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTipoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {
            int idade;
            string texto;

            idade = int.Parse(txtIdade.Text);

            /*
            if (idade >= 18)
                texto = "Voce é maior de idade";
            else
                texto = "Voce é menor de idade";
            */

            texto = 
                idade >= 18 ? 
                "Voce é maior de idade" : 
                "Voce é menor de idade";

            // codigo para quebrar linha
            // \n
            // Environment.NewLine

            MessageBox.Show("Sua idade é: " + 
                idade.ToString() + "\n" +
                texto);
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você bebe? " +
                            "\n" +
                            "Resposta: " + 
                            (ckbBeber.Checked ? "Sim" : "Não"));
        }

        private void ckbBeber_CheckedChanged(object sender, EventArgs e)
        {
            lblRetorno.Text =
                ckbBeber.Checked ? "Sim" : "Não";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" &&
                txtSenha.Text == "admin")
                MessageBox.Show("Usuário Logado");
            else
                MessageBox.Show("Login incorreto");
        }
    }
}
