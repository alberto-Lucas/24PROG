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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();

            //Iremos desativar a validação
            //automatica
            AutoValidate = AutoValidate.Disable;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //Neste iremos validar o campo
            //txtNome

            //Validar se o campo está preenchido
            if(string.IsNullOrEmpty(txtNome.Text))
            { 
                //Caso o campo esteja vazio
                //sera cancela a operação da tela
                //Ou seja irei cancelar o processo
                //de cadastro do registro
                e.Cancel = true;

                //Definir a mensagem a ser exibida
                //Vincular o campo a mensagem
                errorProvider1.SetError(
                    txtNome, "Preencha o Nome.");
            }
            else
            {
                //Aqui resetemos a notificação
                //de erro

                //Cancelar o cancelamento
                e.Cancel = false;

                //Resetar a mensagem
                errorProvider1.SetError(
                    txtNome, "");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Validando se possui
            //alguma notificação configurada
            //Se possuir um cancelamento do cancelamento
            //Esta tudo ok
            //Se tiver cancelamento ativo,
            //temos um problema
            if(!ValidateChildren(
                ValidationConstraints.Enabled))
            {
                MessageBox.Show(
                    "É nescessario o preenchimento" +
                    "de todos os campos, obrigatorios",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    "Registro salvo com sucesso!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
