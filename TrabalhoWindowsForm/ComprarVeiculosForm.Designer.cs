﻿namespace TrabalhoWindowsForm
{
    partial class ComprarVeiculosForm
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
            this.dataGridViewAbaComprar = new System.Windows.Forms.DataGridView();
            this.ColumnVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxContato = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBoxClientesCompra = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbaComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAbaComprar
            // 
            this.dataGridViewAbaComprar.AllowUserToAddRows = false;
            this.dataGridViewAbaComprar.AllowUserToDeleteRows = false;
            this.dataGridViewAbaComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbaComprar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVeiculo,
            this.ColumnMarca,
            this.ColumnValorVeiculo});
            this.dataGridViewAbaComprar.Location = new System.Drawing.Point(11, 57);
            this.dataGridViewAbaComprar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAbaComprar.Name = "dataGridViewAbaComprar";
            this.dataGridViewAbaComprar.ReadOnly = true;
            this.dataGridViewAbaComprar.RowHeadersWidth = 51;
            this.dataGridViewAbaComprar.RowTemplate.Height = 29;
            this.dataGridViewAbaComprar.Size = new System.Drawing.Size(378, 333);
            this.dataGridViewAbaComprar.TabIndex = 2;
            // 
            // ColumnVeiculo
            // 
            this.ColumnVeiculo.HeaderText = "Veiculo";
            this.ColumnVeiculo.Name = "ColumnVeiculo";
            this.ColumnVeiculo.ReadOnly = true;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
            // 
            // ColumnValorVeiculo
            // 
            this.ColumnValorVeiculo.HeaderText = "Valor";
            this.ColumnValorVeiculo.Name = "ColumnValorVeiculo";
            this.ColumnValorVeiculo.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxContato
            // 
            this.textBoxContato.Location = new System.Drawing.Point(466, 112);
            this.textBoxContato.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxContato.Name = "textBoxContato";
            this.textBoxContato.Size = new System.Drawing.Size(195, 23);
            this.textBoxContato.TabIndex = 5;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(466, 176);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(195, 23);
            this.textBoxEndereco.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(438, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(412, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(406, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(438, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "CEP";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(488, 383);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 34);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 383);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Avançar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(524, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "CATEGORIA";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(492, 250);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Hatch";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(550, 250);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 19);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "SUV";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(609, 250);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 19);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Sedan";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBoxClientesCompra
            // 
            this.comboBoxClientesCompra.FormattingEnabled = true;
            this.comboBoxClientesCompra.Location = new System.Drawing.Point(429, 41);
            this.comboBoxClientesCompra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxClientesCompra.Name = "comboBoxClientesCompra";
            this.comboBoxClientesCompra.Size = new System.Drawing.Size(233, 23);
            this.comboBoxClientesCompra.TabIndex = 18;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(466, 82);
            this.maskedTextBoxCpf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBoxCpf.Mask = "999.999.999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(195, 23);
            this.maskedTextBoxCpf.TabIndex = 19;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(466, 143);
            this.maskedTextBoxCep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(195, 23);
            this.maskedTextBoxCep.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 23);
            this.textBox1.TabIndex = 21;
            // 
            // ComprarVeiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(689, 433);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.comboBoxClientesCompra);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxContato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAbaComprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ComprarVeiculosForm";
            this.Text = "ComprarVeiculosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbaComprar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAbaComprar;
        private Button button1;
        private TextBox textBoxContato;
        private TextBox textBoxEndereco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonClear;
        private Button button3;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ComboBox comboBoxClientesCompra;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxCep;
        private DataGridViewTextBoxColumn ColumnNomeEmpresa;
        private DataGridViewTextBoxColumn ColumnVeiculo;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnValorVeiculo;
        private TextBox textBox1;
    }
}