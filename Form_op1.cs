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
    public partial class Form_op1 : Form
    {
        public Form_op1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtNome.Clear();
            txtEndereço.Clear();
            mskCEP.Clear();
            msknascimento.Clear();
            mskFone.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O seu aplicativo irá fechar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }
    }
}
