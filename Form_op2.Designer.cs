namespace F_MultipleForms
{
    partial class Form_op2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuantiProd = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.lblSelecPedi = new System.Windows.Forms.Label();
            this.DataPedi = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblNumPedi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxPedido = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(208, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 23);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Finalizar Pedido";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(0, 205);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 23);
            this.btnConfirm.TabIndex = 31;
            this.btnConfirm.Text = "Adicionar Pedido";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "SubTotal:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblQuantiProd
            // 
            this.lblQuantiProd.AutoSize = true;
            this.lblQuantiProd.Location = new System.Drawing.Point(17, 142);
            this.lblQuantiProd.Name = "lblQuantiProd";
            this.lblQuantiProd.Size = new System.Drawing.Size(104, 13);
            this.lblQuantiProd.TabIndex = 25;
            this.lblQuantiProd.Text = "Digite a Quantidade:";
            this.lblQuantiProd.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.AutoSize = true;
            this.lblTypeValue.Location = new System.Drawing.Point(12, 116);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(109, 13);
            this.lblTypeValue.TabIndex = 24;
            this.lblTypeValue.Text = "Digite o valor do item:";
            this.lblTypeValue.Click += new System.EventHandler(this.lblCEP_Click);
            // 
            // lblSelecPedi
            // 
            this.lblSelecPedi.AutoSize = true;
            this.lblSelecPedi.Location = new System.Drawing.Point(23, 91);
            this.lblSelecPedi.Name = "lblSelecPedi";
            this.lblSelecPedi.Size = new System.Drawing.Size(102, 13);
            this.lblSelecPedi.TabIndex = 22;
            this.lblSelecPedi.Text = "Selecione o Pedido:";
            this.lblSelecPedi.Click += new System.EventHandler(this.lblEndereço_Click);
            // 
            // DataPedi
            // 
            this.DataPedi.AutoSize = true;
            this.DataPedi.Location = new System.Drawing.Point(41, 61);
            this.DataPedi.Name = "DataPedi";
            this.DataPedi.Size = new System.Drawing.Size(80, 13);
            this.DataPedi.TabIndex = 20;
            this.DataPedi.Text = "Data do pedido";
            this.DataPedi.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(127, 32);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 19;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // lblNumPedi
            // 
            this.lblNumPedi.AutoSize = true;
            this.lblNumPedi.Location = new System.Drawing.Point(28, 35);
            this.lblNumPedi.Name = "lblNumPedi";
            this.lblNumPedi.Size = new System.Drawing.Size(97, 13);
            this.lblNumPedi.TabIndex = 18;
            this.lblNumPedi.Text = "Numero do pedido:";
            this.lblNumPedi.Click += new System.EventHandler(this.lblCod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Total R$:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(127, 142);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 35;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(127, 116);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 37;
            // 
            // cbxPedido
            // 
            this.cbxPedido.FormattingEnabled = true;
            this.cbxPedido.Location = new System.Drawing.Point(132, 82);
            this.cbxPedido.Name = "cbxPedido";
            this.cbxPedido.Size = new System.Drawing.Size(121, 21);
            this.cbxPedido.TabIndex = 38;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(132, 56);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 39;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(150, 242);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 40;
            // 
            // Form_op2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 283);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cbxPedido);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblQuantiProd);
            this.Controls.Add(this.lblTypeValue);
            this.Controls.Add(this.lblSelecPedi);
            this.Controls.Add(this.DataPedi);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblNumPedi);
            this.Name = "Form_op2";
            this.Text = "Form_OP21";
            this.Load += new System.EventHandler(this.Form_op2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuantiProd;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label lblSelecPedi;
        private System.Windows.Forms.Label DataPedi;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblNumPedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxPedido;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblTotal;
    }
}