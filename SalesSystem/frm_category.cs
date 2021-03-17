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
    public partial class frm_category : Form
    {
        public frm_category()
        {
            InitializeComponent();
        }

        private void frm_category_Load(object sender, EventArgs e)
        {
            // Chama o arquivo de conexao Datacontext e exibe o Grid em tela com as
            //informação do banco.
            this.categoryBindingSource.DataSource = DataContextFactory.DataContext.category;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Cria uma um novo campo no grid para ser inserido um novo cadastro.
            this.categoryBindingSource.AddNew();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            validate();

            // Ao clicar no Botão "Cadastrar" , verifica se o mesmo está sendo editado
            //, caso não estiver ele salva as informaçoes inseridas no formulario dento
            // do banco de dados através do método "SubmitChanges"
            this.categoryBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Categoria inserida com sucesso!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente excluir esta categoria?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                if (this.productsCategory(this.currentCategory))
                    MessageBox.Show("Você não pode excluir esta categoria por possuir outros produtos cadastrados.");
                else
                {
                    //Botão "EXCLUIR" , através do método "RemoveCurrent", faz a exclusão
                    // da linha selecionada no Grid, e logo em seguida faz as alterações no 
                    // banco.
                    this.categoryBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluida com sucesso!");
                }
                
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.categoryBindingSource.CancelEdit();

            txtNameCategory.Text = "";
            txtDescriptionCategory.Text = "";
        }

        //Método que faz a verificação do campo NOME se está vazio ou não.
        //Caso estiver o mesmo não deixará fazer o cadastramento da categoria.
        private bool validate()
        {
            if (txtNameCategory.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O Campo Nome é obrigatório.");
                txtNameCategory.Focus();
                return false;
            }
            return true;

        }

        /// <summary>
        /// Métodos para Verificar se há produtos com as categorias cadastradas.
        /// Caso estiver, o mesmo não deixara fazer a exclusão da categoria quando 
        /// houver um produto cadastrado.
        /// </summary>
        public category currentCategory
        {
            get
            {
                return (category)this.categoryBindingSource.Current;
            }
        }

        private bool productsCategory(category category)
        {
            var products = DataContextFactory.DataContext.products.Where(x => x.id_category == category.id_category1);
            if(products.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
                

    }
}
