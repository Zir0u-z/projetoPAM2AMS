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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfimar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form_op1 formOp1 = new Form_op1();
                formOp1.ShowDialog();
            }
            else if (radioButton2.Checked == true)
            {
                Form_op2 formOp2 = new Form_op2();
                formOp2.ShowDialog();

            }
            else if (radioButton3.Checked == true)
            {
                Form_Op3 formOp3 = new Form_Op3();
                formOp3.ShowDialog();

            }
        }
    }
}
