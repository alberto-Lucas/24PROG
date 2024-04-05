using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        //Aceitar somente números inteiros.
        //Validar se os números são maiores que 0 (zero) e menores que 100 (cem).
        //Se não forem, exibir uma mensagem alertando o usuário.
        //Validar se o segundo número é maior que o primeiro número.
        //Se não for, exibir uma mensagem alertando o usuário.
        //Utilizar o comando for para exibir os resultados em um ListBox.
        public Form1()
        {
            InitializeComponent();
        }

        //Função que retorno se uma string é somente numero inteiro
        bool IsNumero(string valor)
        {
            //Primeiro validmos se o valor sta vazio
            if (valor == "")
                return false;

            //Criamos um laço de repetição que passara por cada caracter do valor
            for(int i = 0; i < valor.Length; i++)
            {
                //Verficiamos se o cacter atual é um digito
                //Neste se não for um digito retornamos falso
                if (!char.IsDigit(valor[i]))
                    return false;

            }

            //Se chegou até aqui, é pq o valor estava prechido
            //e cada carater era somente numero
            //entao podemos retorno que verdadeiro
            return true;
        }

        //Criamos uma função para retorna se os campos estão validos
        bool IsCamposValidos()
        {
            //Aqui podemos validar os 2 campos junto e retornar apenas uma mensagem
            //Ou podemos validar os campos individualmente
            //indicando o campo errado ao usuario

            //Iremos validar campo a campo
            if (IsNumero(txtNumInicial.Text))
            {
                if (IsNumero(txtNumFinal.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Informe um número Final válido.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Informe um número Inicial válido.");
                return false;
            }
                
        }

        //Função para validar o intervalo do valor
        bool IsIntervaloValido(int valor)
        {
            //Estou retornando o resultado da condição direto
            //Seria o mesmo que:
            /*
                if (valor > 0 && valor < 100)
                    return true;
                else
                    return false;
             */

            //Varificando se ov alor é maior que zero ou menor que cem
            return (valor > 0 && valor < 100);
        }

        //Função para validar o intervalos dos valores
        bool IsValoresValidos(int valor1, int valor2)
        {
            if(IsIntervaloValido(valor1))
            {
                if (IsIntervaloValido(valor2))
                {
                    if(valor2 >= valor1)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("O número Final deve maior que o número Inicial");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Informe um número Final maior que 0(zero) e menor que cem(100).");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Informe um número Inical maior que 0(zero) e menor que cem(100).");
                return false;
            }
        }

        //Método para calcular a tabuada
        void Tabuada(int vInicial, int vFinal)
        {
            //Crio um laço de repetição que ira passar
            //por cada valor do intervalor
            //Ou seja temos o intervalo da 2 ao 4
            //Então iremos passar pelo 2 depois pelo 3 e depois pelo 4
            for(int i = vInicial; i <= vFinal; i++)
            {
                //A cada passado do intervalo iremos calcular
                //a tabuada do intervalo de 1 a 10
                //Ou seja se o for intervalo 3
                //Iremos calular a tabuda do 3 do 1 ao 10

                for(int j = 1; j <= 10; j++)
                {
                    string resultado;

                    //Criamos uma variavel resultado que ira armazenar
                    //a concatenção dos valores e o resultado
                    
                    //Um recurso legal do método ToString é que podemos adicionar
                    //Zero a esquerda sobre o valores
                    //Ex: 5 -> 05
                    //Bastando dentro do parenteses () adicionar a
                    //quantidade de zeros desejado
                    resultado = i.ToString("00") + " x " + j.ToString("00") + " = " + (i * j).ToString("00");
                    //Adicionamos o resultado ao listBox
                    //Aqui poderiamos passar a concatenação direto
                    //separamos apenas para uma melhor organização
                    lstResultado.Items.Add(resultado);
                }

                //A cada intervalo será adicionado uma linha 
                //para sepração dos intervalos
                lstResultado.Items.Add("----------------------");
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validamos se o valor inserido é valido
            if(IsCamposValidos())
            {
                //Como sabemos que agora o valor é somente numeros
                //podemos converter para inteiro
                int numInicial, numFinal;

                numInicial = int.Parse(txtNumInicial.Text);
                numFinal = int.Parse(txtNumFinal.Text); 

                //Agora precisamos identificar se o valores estão dentro do intervalo correto
                if(IsValoresValidos(numInicial, numFinal))
                {
                    //Se chegamos até aqui, todos os valores estão corretos
                    //Podemos calcular nossa tabuada

                    //Iniciamos limpando o listBox
                    lstResultado.Items.Clear();

                    //Chamamos o método que irá calcular e exibir o resultado da tabuada
                    Tabuada(numInicial, numFinal);
                }
            }
        }
    }
}
