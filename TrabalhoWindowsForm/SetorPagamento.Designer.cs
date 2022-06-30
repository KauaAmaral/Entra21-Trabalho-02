﻿namespace TrabalhoWindowsForm
{
    partial class SetorPagamentoForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxValidade = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxParcelas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCpfCartao = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNomeCartao = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCodSeguranca = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxNumeroCartao = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancelarOp = new System.Windows.Forms.Button();
            this.buttonFinalizarCompra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(46, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Detalhes do seu Cartão";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 28);
            this.panel1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(112, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "PAGAMENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Validade";
            // 
            // maskedTextBoxValidade
            // 
            this.maskedTextBoxValidade.Location = new System.Drawing.Point(64, 254);
            this.maskedTextBoxValidade.Mask = "00 /00";
            this.maskedTextBoxValidade.Name = "maskedTextBoxValidade";
            this.maskedTextBoxValidade.Size = new System.Drawing.Size(74, 23);
            this.maskedTextBoxValidade.TabIndex = 30;
            this.maskedTextBoxValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxValidade.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nome no Cartão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Parcelas";
            // 
            // comboBoxParcelas
            // 
            this.comboBoxParcelas.FormattingEnabled = true;
            this.comboBoxParcelas.Items.AddRange(new object[] {
            "1 Parcela (À vista)",
            "20x",
            "21x",
            "22x",
            "23x"});
            this.comboBoxParcelas.Location = new System.Drawing.Point(55, 310);
            this.comboBoxParcelas.Name = "comboBoxParcelas";
            this.comboBoxParcelas.Size = new System.Drawing.Size(202, 23);
            this.comboBoxParcelas.TabIndex = 27;
            this.comboBoxParcelas.Text = "                         À Vista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "CVC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Numero do Cartão";
            // 
            // maskedTextBoxCpfCartao
            // 
            this.maskedTextBoxCpfCartao.Location = new System.Drawing.Point(64, 203);
            this.maskedTextBoxCpfCartao.Mask = "999.999.999-99";
            this.maskedTextBoxCpfCartao.Name = "maskedTextBoxCpfCartao";
            this.maskedTextBoxCpfCartao.Size = new System.Drawing.Size(156, 23);
            this.maskedTextBoxCpfCartao.TabIndex = 23;
            this.maskedTextBoxCpfCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxCpfCartao.ValidatingType = typeof(int);
            // 
            // textBoxNomeCartao
            // 
            this.textBoxNomeCartao.Location = new System.Drawing.Point(64, 162);
            this.textBoxNomeCartao.Name = "textBoxNomeCartao";
            this.textBoxNomeCartao.Size = new System.Drawing.Size(156, 23);
            this.textBoxNomeCartao.TabIndex = 22;
            this.textBoxNomeCartao.Tag = "";
            // 
            // maskedTextBoxCodSeguranca
            // 
            this.maskedTextBoxCodSeguranca.Location = new System.Drawing.Point(144, 254);
            this.maskedTextBoxCodSeguranca.Mask = "9 9 9";
            this.maskedTextBoxCodSeguranca.Name = "maskedTextBoxCodSeguranca";
            this.maskedTextBoxCodSeguranca.Size = new System.Drawing.Size(76, 23);
            this.maskedTextBoxCodSeguranca.TabIndex = 21;
            this.maskedTextBoxCodSeguranca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxCodSeguranca.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::TrabalhoWindowsForm.Properties.Resources.bandeira_dos_cartoes_de_credito;
            this.pictureBox1.Location = new System.Drawing.Point(11, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // maskedTextBoxNumeroCartao
            // 
            this.maskedTextBoxNumeroCartao.Location = new System.Drawing.Point(64, 118);
            this.maskedTextBoxNumeroCartao.Mask = "9999 9999 9999 9999";
            this.maskedTextBoxNumeroCartao.Name = "maskedTextBoxNumeroCartao";
            this.maskedTextBoxNumeroCartao.Size = new System.Drawing.Size(156, 23);
            this.maskedTextBoxNumeroCartao.TabIndex = 19;
            this.maskedTextBoxNumeroCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxNumeroCartao.ValidatingType = typeof(int);
            // 
            // buttonCancelarOp
            // 
            this.buttonCancelarOp.Location = new System.Drawing.Point(11, 421);
            this.buttonCancelarOp.Name = "buttonCancelarOp";
            this.buttonCancelarOp.Size = new System.Drawing.Size(141, 25);
            this.buttonCancelarOp.TabIndex = 18;
            this.buttonCancelarOp.Text = "Cancelar Operação";
            this.buttonCancelarOp.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizarCompra
            // 
            this.buttonFinalizarCompra.Location = new System.Drawing.Point(164, 421);
            this.buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            this.buttonFinalizarCompra.Size = new System.Drawing.Size(136, 25);
            this.buttonFinalizarCompra.TabIndex = 17;
            this.buttonFinalizarCompra.Text = "Finalizar Compra";
            this.buttonFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // SetorPagamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxValidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxParcelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxCpfCartao);
            this.Controls.Add(this.textBoxNomeCartao);
            this.Controls.Add(this.maskedTextBoxCodSeguranca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBoxNumeroCartao);
            this.Controls.Add(this.buttonCancelarOp);
            this.Controls.Add(this.buttonFinalizarCompra);
            this.Name = "SetorPagamentoForm";
            this.Text = "SetorPagamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private MaskedTextBox maskedTextBoxValidade;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxParcelas;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBoxCpfCartao;
        private TextBox textBoxNomeCartao;
        private MaskedTextBox maskedTextBoxCodSeguranca;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBoxNumeroCartao;
        private Button buttonCancelarOp;
        private Button buttonFinalizarCompra;
    }
}