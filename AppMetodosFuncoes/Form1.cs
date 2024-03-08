using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMetodosFuncoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            string opcao;

            //utilizado quando podemos ter condições diferentes
            if (cbxOpcao.SelectedIndex == 0)
                opcao = "Opção 1 Selecionada";
            else if (cbxOpcao.SelectedIndex == 1)
                opcao = "Opção 2 Selecionada";
            else if (cbxOpcao.SelectedIndex == 2)
                opcao = "Opção 3 Selecionada";
            else if (cbxOpcao.SelectedIndex == 3)
                opcao = "Opção 4 Selecionada";
            else
                opcao = "Nenhuma Opção Selecionada";

            MessageBox.Show(opcao);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string opcao;

            //utilizando quando possui variação de uma tipo de dados
            switch(cbxOpcao.SelectedIndex)
            {
                case 0:
                    opcao = "Opção 1 Selecionada";
                    break;
                case 1:
                    opcao = "Opção 2 Selecionada";
                    break;
                case 2:
                    opcao = "Opção 3 Selecionada";
                    break;
                case 3:
                    opcao = "Opção 4 Selecionada";
                    break;
                default:
                    opcao = "Nenhuma Opção Selecionada";
                    break;
            }

            MessageBox.Show(opcao);
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            //Chamo o metodo Somar que ira processar todo o codigo
            MetodoSomar();
        }

        private void MetodoSomar()
        {

            //Um metodo vai executar um bloco de código
            //Não possui nenhum tipo de dados
            //portanto não possui retorno
            int v1, v2, resultado;

            v1 = int.Parse(txtV1.Text);
            v2 = int.Parse(txtV2.Text);

            resultado = v1 + v2;

            MessageBox.Show("A soma de " + txtV1.Text + " e " + txtV2.Text + " é: " + resultado.ToString());
        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {
            //Chamo a funcao Somar que ira processar apenas a soma dos valores
            int resultado;
            resultado = FuncaoSomar();
            MessageBox.Show("A soma de " + txtV1.Text + " e " + txtV2.Text + " é: " + resultado.ToString());
        }

        private int FuncaoSomar()
        {
            //Uma funcao vai executar um bloco de código
            //Deve possuir um tipo de dado
            //portanto deve retorna um valor do mesmo tipo da funcao
            //usado a palavra reservada return para retornar o valor

            int v1, v2;
            v1 = int.Parse(txtV1.Text);
            v2 = int.Parse(txtV2.Text);

            return v1 + v2;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Somar(int.Parse(txtV1.Text), int.Parse(txtV2.Text)).ToString();
        }

        private int Somar(int v1, int v2)
        {
            return v1 + v2;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Subtrair(int.Parse(txtV1.Text), int.Parse(txtV2.Text)).ToString();
        }

        private int Subtrair(int v1, int v2)
        {
            return v1 - v2;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Multiplicar(int.Parse(txtV1.Text), int.Parse(txtV2.Text)).ToString();
        }

        private int Multiplicar(int v1, int v2)
        {
            return v1 * v2;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Dividir(int.Parse(txtV1.Text), int.Parse(txtV2.Text)).ToString();
        }


        private int Dividir(int v1, int v2)
        {
            return v1 / v2;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.Text = 
                Calcular(txtOperacao.Text, 
                        int.Parse(txtV1.Text), 
                        int.Parse(txtV2.Text)).ToString();
        }

        private int Calcular(string operacao, int v1, int v2)
        {
            switch(operacao)
            {
                case "+": return v1 + v2;
                case "-": return v1 - v2;
                case "*": return v1 * v2;
                case "/": return v1 / v2;
                default: return 0;
            }
        }

        private void btnFor0_Click(object sender, EventArgs e)
        {
            //Laço de repetição FOR
            //Executa um loop de valor que sabemos a quantidade de repetição
            for(int i = 0; i <= 10; i++)
                lstLoop.Items.Add(i.ToString());
        }

        private void btnFor10_Click(object sender, EventArgs e)
        {
            for (int i = 10; i >= 0; i--)
                lstLoop.Items.Add(i.ToString());
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //Laço de repetição While
            //Utilizado quando não soubermos a quantidade de repetição
            //Primeiro ocorre a validação para depois executar
            //Ou seja se a primeira condição for satisfeita
            //Não é executada nenhuma vez
            int i = 0;

            while (i <= 10)
            {
                lstLoop.Items.Add(i.ToString());
                i++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            //Laço de repetição Do-While
            //Utilizado quando não soubermos a quantidade de repetição
            //Primeiro executa a ação depois a validação
            //Ou seja garante que o codigo seja executado pelo menos uma vez

            int i = 0;

            do
            {
                lstLoop.Items.Add(i.ToString());
                i++;
            }
            while (i <= 10);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstLoop.Items.Clear();
        }

        private void btnWhileTeste_Click(object sender, EventArgs e)
        {
            bool resposta;

            resposta =
            MessageBox.Show(
                "O professor Lucas é o melhor professor?",
                "Valendo 1 ponto",
                MessageBoxButtons.YesNo) == DialogResult.Yes;

            while (!resposta)
            {
                resposta =
                MessageBox.Show(
                    "O professor Lucas é o melhor professor?",
                    "Valendo 1 ponto",
                    MessageBoxButtons.YesNo) == DialogResult.Yes;
            }
        }

        private void btnDoWhileTeste_Click(object sender, EventArgs e)
        {
            bool resposta;

            do
            {
                resposta =
                MessageBox.Show(
                    "O professor Lucas é o melhor professor?",
                    "Valendo 1 ponto",
                    MessageBoxButtons.YesNo) == DialogResult.Yes;
            }
            while (!resposta);
        }

        private void btnSoNumero_Click(object sender, EventArgs e)
        {
            txtSoNumero.Text = SoNumero(txtValor.Text);
        }

        private string SoNumero(string valor)
        {
            string resultado = "";

            // Percorre cada caractere da string
            for (int i = 0; i < valor.Length; i++)
            {
                // Verifica se o caractere é um dígito numérico
                if (char.IsDigit(valor[i]))
                {
                    resultado += valor[i];
                }
            }

            return resultado;
        }
    }
}
