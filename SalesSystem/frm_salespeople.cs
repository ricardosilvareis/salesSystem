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
    public partial class frm_salespeople : Form
    {
        public frm_salespeople()
        {
            InitializeComponent();
        }

        
        private void frm_salespeople_Load(object sender, EventArgs e)
        {

            // Chama o arquivo de conexao Datacontext e exibe o Grid em tela com as
            //informação do banco.
            this.sellerBindingSource.DataSource = DataContextFactory.DataContext.seller;
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Cria uma um novo campo no grid para ser inserido um novo cadastro.
            this.sellerBindingSource.AddNew();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            validate();

            // Ao clicar no Botão "Cadastrar" , verifica se o mesmo está sendo editado
            //, caso não estiver ele salva as informaçoes inseridas no formulario dento
            // do banco de dados através do método "SubmitChanges"
            this.sellerBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Vendedor Cadastrado com Sucesso!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("Deseja realmente excluir este registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))

            {
                //Botão "EXCLUIR" , através do método "RemoveCurrent", faz a exclusão
                // da linha selecionada no Grid, e logo em seguida faz as alterações no 
                // banco.
                this.sellerBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Vendedor excluido com sucesso!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.sellerBindingSource.CancelEdit();

            txtFantayName.Text = "";
            txtEmail.Text = "";
            txtCompanyName.Text = "";
            txtAddress.Text = "";
            mskCNPJ.Text = "";
            mskTelephone.Text = "";
        }


        //Método que faz a verificação do campo que são obrigatóris se está vazio ou não.
        //Caso estiver o mesmo não deixará fazer o cadastramento da categoria.
        private bool validate()
        {
            if (txtFantayName.Text.Trim() == string.Empty && txtCompanyName.Text == string.Empty && mskCNPJ.Text == string.Empty && mskTelephone.Text == string.Empty)
            {
                MessageBox.Show("Preenchimento de campos obrigatórios!");
                txtFantayName.Focus();
                return false;
            }
            return true;

        }
    }
}
