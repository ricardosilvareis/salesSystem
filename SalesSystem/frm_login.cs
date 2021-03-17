using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class frm_login : Form
    {
        
        public frm_login()
        {
            InitializeComponent();
        }

        
        private void btnGet_In_Click(object sender, EventArgs e)
        {
           
            //USUÁRIO: "Admin" SENHA: "Admin"

            if (txtLogin.Text == "Admin" && txtPassoword.Text == "Admin")
            {
                MessageBox.Show("Login Efetuado com Sucesso!");
                frm_menu menu = new frm_menu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida!");

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

          
    }
}
