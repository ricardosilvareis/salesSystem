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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frm_category category = new frm_category();
            category.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frm_products products = new frm_products();
            products.Show();
        }

        private void produtosCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_queryProducts queryProducts = new frm_queryProducts();
            queryProducts.Show();
        }

        private void btnMarketplace_Click(object sender, EventArgs e)
        {
            frm_marketplace marketplace = new frm_marketplace();
            marketplace.Show();
        }

        private void btnSalespeople_Click(object sender, EventArgs e)
        {
            frm_salespeople salespeople = new frm_salespeople();
            salespeople.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_category category = new frm_category();
            category.Show();
        }

        private void marketplacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_marketplace marketplace = new frm_marketplace();
            marketplace.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_products products = new frm_products();
            products.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_salespeople salespeople = new frm_salespeople();
            salespeople.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            frm_queryProducts queryProducts = new frm_queryProducts();
            queryProducts.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
