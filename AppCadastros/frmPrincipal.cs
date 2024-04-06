using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Encerrar a aplicação por completo
            //Utilizar apenas na tela
            //Principal
            Application.Exit();

            //Encerro apenas o Form
            //Utilizar apenas nos 
            //Formularios Filhos
            //Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Neste ao fechar a tela
            //Sera realizada uma mensagem 
            //de confirmação de fechamento
            //para o usuário
            if (MessageBox.Show(
                "Deseja realmente sair?", //Mensagem
                "Atenção!", //Titulo Mensagem
                MessageBoxButtons.YesNo, //Defino o botões
                MessageBoxIcon.Warning, //Icone da Mensagem
                MessageBoxDefaultButton.Button2 //Botão Padrão
                ) == DialogResult.No)
            {
                //Aqui no evento FormClossing
                //Precisamos cancelar o fechamento
                e.Cancel = true;
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Criar a chamada de uma nova tela
            //Primeiro é preciso carregar
            //a tela em memoria

            //Utilizando a palavra new
            //para criar o objeto em memoria

            //Definir o que sera chamado
            //Definir a variavel que
            //recebera a instancia
            //Criamos a instancia em memoria

            frmCadCliente form =
                new frmCadCliente();

            //Utilizando a variavel form
            //iremos apresentar a tela 
            //para o usuario

            //Sera apresentado uma tela separada
            //da tela principal
            //podendo manipular a tela mae 
            //separa da tela filha
            //form.Show();


            //A tela é apresentada vinculada
            //a tela mae
            //portanto não é possivel mexer 
            //na tela mae, equanto a filha estiver
            //sendo apresentada.
            form.ShowDialog();
        }
    }
}
