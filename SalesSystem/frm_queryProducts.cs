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
    public partial class frm_queryProducts : Form
    {
        public frm_queryProducts()
        {
            InitializeComponent();
        }

        private void frm_queryProducts_Load(object sender, EventArgs e)
        {
            // Chama o arquivo de conexao Datacontext e exibe o Grid em tela com as
            //informação do banco.
            this.categoryBindingSource.DataSource = DataContextFactory.DataContext.category;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Método que faz a busca dentro das categorias cadatradas para verificar se tem algum valor.
            this.Search((int)(cbxSearchCategory.SelectedValue));
        }


        // Método que verifica dentro do banco de dados na tabele produto se possui 
        // o mesmo código que está dentro da tabela categorias.
        //Ou seja, ao cliclar no botão "Buscar" irá filtrar todos os produtos com a 
        // a mesma categoria cadastrada.
        public void Search(int codeCategory)
        {
            productsBindingSource.DataSource = DataContextFactory.DataContext.products.Where(x => x.id_category == codeCategory);
        }
    }
}
