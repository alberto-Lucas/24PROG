using System;
using System.IO;
using System.Windows.Forms;

namespace AppMnaipularArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Utilizar o compoente Folder
            //para selecionar uma pasta de diretorio
            //para o usuario, e iremos
            //coletar o resultado da selação
            DialogResult resultado =
                folderBrowserDialog1.ShowDialog();
            //Verificar se foi clicado no botão 
            //ok ou cancelar
            //se clicado em cancelar, iremos ignorar
            //se clicado em ok, iremos validar o diretorio
            //após validado e estivar tudo certo
            //iremos apresentar o diretorio para o usuario
            if(resultado == DialogResult.OK &&
                !string.IsNullOrEmpty(
                    folderBrowserDialog1.SelectedPath))
            {
                txtCaminho.Text = 
                    folderBrowserDialog1.SelectedPath;
            }
        }

        //Função para validar o diretorio
        bool ValidarDiretorio()
        {
            //Recuperar os dados informados
            //pelo usuario
            string diretorio = txtCaminho.Text;
            string nomeArquivo = txtNome.Text;

            //Validar o preenchimento dos campos
            if(string.IsNullOrEmpty(diretorio) ||
                string.IsNullOrEmpty(nomeArquivo))
            {
                MessageBox.Show(
                    "Por favor, informe os " +
                    "dados corretamente");

                //Encerremos a execução da rotina
                return false;
            }

            //Validar o existencia do diretorio
            //using System.IO;
            if(!Directory.Exists(diretorio))
            {
                MessageBox.Show("" +
                    "O diretório especificado não existe.");
                
                return false;
            }
            return true;
        }

        //Função para retornar o diretorio complept
        string GetDiretorioCompleto()
        {
            //Direto + nome + extensão
            //C:/
            //Teste
            //.txt
            //c:/Teste.txt
            return
                Path.Combine(txtCaminho.Text,
                txtArquivo.Text + ".txt");
        }
    }
}
