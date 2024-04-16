using System;
using System.IO;
using System.Windows.Forms;

namespace AppManipulaArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarCaminho_Click(object sender, EventArgs e)
        {
            //Utilizando o componenete folderBrowserDialog1
            //Iremos apresentar a tela de seleção de pastas
            //para o usuario e iremos coletar o resutado 
            //da seleção
            DialogResult result = folderBrowserDialog1.ShowDialog();
            //Verificamos se foi clicar no botão ok ou cancelar
            //se clicado no cancelar iremos ignorar
            //se clicado no ok, iremos validar o diretorio
            //selecionado
            //se tudo ok, iremos apresentar o diretorio
            //ao usuario no textbox
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                txtCaminho.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //Função para validar diretorio
        bool ValidarDiretorio()
        {
            //Iremos recuperar os dados informados pelo usuario
            string diretorio = txtCaminho.Text;
            string nomeArquivo = txtNomeArquivo.Text;

            //Validamos o preenchimento dos campos
            if (string.IsNullOrWhiteSpace(diretorio) || string.IsNullOrWhiteSpace(nomeArquivo))
            {
                MessageBox.Show("Por favor, selecione um diretório e informe um nome de arquivo.");
                //Utilizamso o return para encerrar o método
                //visto que se os campos não forem validos
                //não tem como prosseguir
                //então podemos encerrar
                return false;
            }

            //Validamos se o diretorio é valido
            if (!Directory.Exists(diretorio))
            {
                MessageBox.Show("O diretório especificado não existe.");
                return false;
            }

            return true;
        }

        //Função para retorno o diretorio completo
        string GetDiretorioCompleto()
        {
            //Diretorio + Nome arquivo
            return Path.Combine(txtCaminho.Text, txtNomeArquivo.Text + ".txt");
        }


        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            //Validamos os dados do diretorio
            if (!ValidarDiretorio())
                return;

            //Recuperamos o diretorio completo
            string caminhoCompleto = GetDiretorioCompleto();

            //utilizamos o Try Catch para criação do arquivo
            //pois caso ocorra uma falha iremos tratar
            //Pode ocorrer falha de permissão da pasta
            try
            {
                //Verificação se o arquivo existe no diretorio
                if (!File.Exists(caminhoCompleto))
                {
                    //Se não existir criamos um arquivo vazios
                    File.WriteAllText(caminhoCompleto, "");
                    //E notificamos o usuario
                    MessageBox.Show("Arquivo criado com sucesso!");
                }
                else
                {
                    //Se ja existir, notificamos o usuario
                    MessageBox.Show("O arquivo já existe.");
                }
            }
            catch (Exception ex)
            {
                //Caso ocorra uma falha, notificamos o usuario
                //Só ira notificar caso ocorra algum erro na execução
                MessageBox.Show("Ocorreu um erro ao criar o arquivo: " + ex.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Validamos os dados do diretorio
            if (!ValidarDiretorio())
                return;

            //Obtém o caminho completo do arquivo
            string caminhoCompleto = GetDiretorioCompleto();

            try
            {
                //Grava o texto do TextBox no arquivo
                //Todo o conteudo do arquivo será subistituido
                //Utiliazado Environment.NewLine para gerar uma nova linha no final do arquivo
                File.WriteAllText(caminhoCompleto, txtTexto.Text + Environment.NewLine);
                MessageBox.Show("Dados gravados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gravar os dados no arquivo: " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Validamos os dados do diretorio
            if (!ValidarDiretorio())
                return;

            //Obtém o caminho completo do arquivo
            string caminhoCompleto = GetDiretorioCompleto();

            try
            {
                //Grava o texto do TextBox no arquivo
                //Será adicionado o texto ao arquivo
                //Utiliazado Environment.NewLine para gerar uma nova linha no final do arquivo
                File.AppendAllText(caminhoCompleto, txtTexto.Text + Environment.NewLine);
                MessageBox.Show("Dados gravados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gravar os dados no arquivo: " + ex.Message);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // Verifica se o diretório e o nome do arquivo são válidos
            if (!ValidarDiretorio())
                return;

            // Obtém o caminho completo do arquivo
            string caminhoCompleto = GetDiretorioCompleto();

            try
            {
                // Verifica se o arquivo existe
                if (File.Exists(caminhoCompleto))
                {
                    // Lê todo o texto do arquivo e o exibe no TextBox
                    string conteudo = File.ReadAllText(caminhoCompleto);
                    txtArquivo.Text = conteudo;
                    MessageBox.Show("Conteúdo carregado com sucesso!");
                }
                else
                {
                    MessageBox.Show("O arquivo não existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar o arquivo: " + ex.Message);
            }
        }

        private void btnCarregarTodos_Click(object sender, EventArgs e)
        {
            //Limpar o txtArquivo
            txtArquivo.Clear();

            try
            {
                //Obtém todos os arquivos .txt do diretorio
                //E armazena cada arquivo em um array de diretorios
                string[] diretorios = Directory.GetFiles(txtCaminho.Text, "*.txt");

                //Realiza um loop, passadno por cada aquivo
                //e lendo seu conteudo
                foreach (string arquivo in diretorios)
                {
                    // Lê o conteúdo do arquivo
                    string conteudo = File.ReadAllText(arquivo);

                    // Exibe o conteúdo em um TextBox multiline
                    txtArquivo.AppendText("Conteúdo do arquivo: " + Path.GetFileName(arquivo) + Environment.NewLine);
                    txtArquivo.AppendText(conteudo + Environment.NewLine);
                    txtArquivo.AppendText("------------------------------------" + Environment.NewLine);
                }

                MessageBox.Show("Todos os arquivos .txt foram lidos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler os arquivos .txt: " + ex.Message);
            }
        }
    }
}
