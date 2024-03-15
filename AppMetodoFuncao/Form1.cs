using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMetodoFuncao
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

            if (cbbOpcao.SelectedIndex == 0)
                opcao = "Primeiro Iten selecionado";
            else if(cbbOpcao.SelectedIndex == 1)
                opcao = "Segundo Iten selecionado";
            else if (cbbOpcao.SelectedIndex == 2)
                opcao = "Terceiro Iten selecionado";
            else if (cbbOpcao.SelectedIndex == 3)
                opcao = "Quarto Iten selecionado";
            else
                opcao = "Nenhum selecinado";

            MessageBox.Show(opcao);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string opcao;

            switch(cbbOpcao.SelectedIndex)
            {
                case 0:
                    opcao = "Primeiro Item";
                    break;
                case 1:
                    opcao = "Segundo Item";
                    break;
                case 2:
                    opcao = "Terceiro Item";
                    break;
                case 3:
                    opcao = "Quarto Item";
                    break;
                default:
                    opcao = "Nenhum item";
                    break;
            }

            MessageBox.Show(opcao);
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            MetodoSomar();
        }

        //Método
        //Void - não retorna nada
        void MetodoSomar()
        {
            int v1, v2, resultado;

            v1 = int.Parse(txtV1.Text);
            v2 = int.Parse(txtV2.Text);

            resultado = v1 + v2;

            MessageBox.Show("O resulta da soma é: " +
                resultado.ToString());
        }

        //Função
        //int define o tipo do retorno
        //obrigatorio usa da palavra return
        int FuncaoSomar()
        {
            int v1, v2;

            v1 = int.Parse(txtV1.Text);
            v2 = int.Parse(txtV2.Text);

            return v1 + v2;
        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {
            int resultado;
            resultado = FuncaoSomar();

            MessageBox.Show("O resultado é: " + resultado);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.Text =
                Calcular(
                            int.Parse(txtV1.Text),
                            int.Parse(txtV2.Text),
                            txtOperacao.Text
                        ).ToString();
        }

        int Calcular(int v1, int v2, string operacao)
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

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text =
                Calcular(2, 2, "*").ToString();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = 
            Calcular(int.Parse(txtV1.Text),
                int.Parse(txtV2.Text),
                "+").ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bool resposta;

            resposta =
                MessageBox.Show(
                "O Lucas é o melhor professor?",
                "Pergunta",
                MessageBoxButtons.YesNo) == 
                DialogResult.Yes;

            while(!resposta)
            {
                resposta =
                MessageBox.Show(
                "O Lucas é o melhor professor?",
                "Pergunta",
                MessageBoxButtons.YesNo) ==
                DialogResult.Yes;
            }
        }

        private void btnIniciar_MouseHover(object sender, EventArgs e)
        {
            MoverBotao();
        }

        void MoverBotao()
        {
            Random randon = new Random();
            int x, y;

            x = randon.Next(0, this.Width - 30);
            y = randon.Next(0, this.Height - 30);

            btnIniciar.Left = x;
            btnIniciar.Top = y;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            MoverBotao();
        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            MoverBotao();
        }
    }
}
