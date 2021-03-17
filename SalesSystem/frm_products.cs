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
    public partial class frm_products : Form
    {
        public frm_products()
        {
            InitializeComponent();
        }

        private void frm_products_Load(object sender, EventArgs e)
        {
            // Chama o arquivo de conexao Datacontext e exibe o Grid em tela com as
            //informação do banco.
            this.productsBindingSource.DataSource = DataContextFactory.DataContext.products;
            this.categoryBindingSource.DataSource = DataContextFactory.DataContext.category;

           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Cria uma um novo campo no grid para ser inserido um novo cadastro.
            this.productsBindingSource.AddNew();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Ao clicar no Botão "Cadastrar" , verifica se o mesmo está sendo editado
            //, caso não estiver ele salva as informaçoes inseridas no formulario dento
            // do banco de dados através do método "SubmitChanges"
            this.productsBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Produto Cadastrado com Sucesso!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este produto?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                //Botão "EXCLUIR" , através do método "RemoveCurrent", faz a exclusão
                // da linha selecionada no Grid, e logo em seguida faz as alterações no 
                // banco.
                this.productsBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Produto excluido com sucesso!");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.CancelEdit();

            txtNameProducts.Text = "";
            txtValueProducts.Text = "";
            txtDescriptionProducts.Text = "";
            cbxCategory.Text = "";
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
                e.Value = ((category)e.Value).name;
        }
    }
}
