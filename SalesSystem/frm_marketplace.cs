using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system.DAL;

namespace SalesSystem
{
    public partial class frm_marketplace : Form
    {
        public frm_marketplace()
        {
            InitializeComponent();
        }
        private void frm_marketplace_Load(object sender, EventArgs e)
        {
            // Chama o arquivo de conexao Datacontext e exibe o Grid em tela com as
            //informação do banco.
            this.marketplaceBindingSource.DataSource = DataContextFactory.DataContext.marketplace;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {   
            //Através do botão "NOVO" cria-se mais uma campo no grid para ser 
            // inserido as informações de cadastro.
            this.marketplaceBindingSource.AddNew();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            validate();

            // Ao clicar no Botão "Cadastrar" , verifica se o mesmo está sendo editado
            //, caso não estiver ele salva as informaçoes inseridas no formulario dento
            // do banco de dados através do método "SubmitChanges"
            this.marketplaceBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Cadastro efetuado com sucesso!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if((MessageBox.Show("Deseja realmente excluir esta categoria?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Botão "EXCLUIR" , através do método "RemoveCurrent", faz a exclusão
                // da linha selecionada no Grid, e logo em seguida faz as alterações no 
                // banco.
                this.marketplaceBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Cadastro excluido com sucesso!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.marketplaceBindingSource.CancelEdit();

            txtName.Text = "";
            txtDescription.Text = "";
            txtSite.Text = "";
            txtEmail.Text = "";
            txtContatct.Text = "";
            mskTelephone.Text = "";

        }

        ///Método que faz a verificação do campos obrigatórios constam-se vazios ou não.
        //Caso estiver o mesmo não deixará fazer o cadastramento.
        private bool validate()
        {
            if (txtName.Text.Trim() == string.Empty && txtContatct.Text == string.Empty && mskTelephone.Text == string.Empty)
            {
                MessageBox.Show("Obrigatório o preenchimentos dos campos!");
                txtName.Focus();
                return false;
            }
            return true;

        }
    }
}
