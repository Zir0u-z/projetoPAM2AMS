using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_MultipleForms
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
           
            if (txtUsuário.Text == "admin" && txtSenha.Text == "admin")
            {
                MessageBox.Show("Login feito com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            } 
            else
            {
                MessageBox.Show("coloque o mesmo para o usuario e senha", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuário.Text = "";
                txtSenha.Text = "";
                txtUsuário.Focus();
            }
           
        }
    }
}
