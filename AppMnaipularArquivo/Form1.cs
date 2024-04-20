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
                txtNome.Text + ".txt");
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //Antes de criar o arquivo 
            //precisamos validar o diretorio
            //Se verdadeiro tudo ok
            //se false temos problemas e precimos
            //interromper a execução

            if (!ValidarDiretorio())
                return;

            //Recuperar o diretorio completo
            string diretorioCompleto = 
                GetDiretorioCompleto();

            //Verificamos se o arquivo ja existe
            if(File.Exists(diretorioCompleto))
                MessageBox.Show("O arquivo ja existe.");
            else
            {
                //Criamos um arquivo vazio
                File.WriteAllText(
                    diretorioCompleto, "");

                MessageBox.Show(
                    "Arquivo criado com sucesso.");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(!ValidarDiretorio())
                return;

            string diretorioCompleto =
                GetDiretorioCompleto();

            //Gravamos o conteudo do TextBox(txtTexto)
            //no arquivo
            //Todo o conteudo do arquivo será subistituido
            //Sempre adicionamos uma linha em branco
            //ao final do arquivo
            //Environment.NewLine serve para quebrar/adicionar 
            //linha
            File.WriteAllText(
                diretorioCompleto,
                txtTexto.Text + Environment.NewLine);

            MessageBox.Show("Dados gravados com sucesso");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidarDiretorio())
                return;

            string diretorioCompleto =
                GetDiretorioCompleto();

            //Iremos adicionar o conteduo do TextBox
            //dentro do arquivo
            //ou Será adicionado o novo conteudo
            //ao conteudo existente no arquivo
            File.AppendAllText(
                diretorioCompleto,
                txtTexto.Text + Environment.NewLine);

            MessageBox.Show(
                "Dados adicionados com sucesso.");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDiretorio())
                return;

            string diretorioCompleto = 
                GetDiretorioCompleto();

            if(File.Exists(diretorioCompleto))
            {
                MessageBox.Show(
                    "O arquivo não existe.");
            }
            else
            {
                //Iremos carregar o
                //conteudo do arquivo
                //ReadAllText responsavel
                //por ler o arquivo

                txtArquivo.Text = 
                    File.ReadAllText(
                        diretorioCompleto);

                MessageBox.Show(
                    "Conteudo carregado com sucesso.");
            }
        }
    }
}
