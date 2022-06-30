namespace TrabalhoWindowsForm
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
            this.ColumnColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbaComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAbaComprar
            // 
            this.dataGridViewAbaComprar.AllowUserToAddRows = false;
            this.dataGridViewAbaComprar.AllowUserToDeleteRows = false;
            this.dataGridViewAbaComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbaComprar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnColaborador});
            this.dataGridViewAbaComprar.Location = new System.Drawing.Point(42, 51);
            this.dataGridViewAbaComprar.Name = "dataGridViewAbaComprar";
            this.dataGridViewAbaComprar.ReadOnly = true;
            this.dataGridViewAbaComprar.RowHeadersWidth = 51;
            this.dataGridViewAbaComprar.RowTemplate.Height = 29;
            this.dataGridViewAbaComprar.Size = new System.Drawing.Size(357, 416);
            this.dataGridViewAbaComprar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxContato
            // 
            this.textBoxContato.Location = new System.Drawing.Point(583, 140);
            this.textBoxContato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxContato.Name = "textBoxContato";
            this.textBoxContato.Size = new System.Drawing.Size(243, 27);
            this.textBoxContato.TabIndex = 5;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(583, 220);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(243, 27);
            this.textBoxEndereco.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(547, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(515, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(508, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(547, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "CEP";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(610, 479);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 43);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(729, 479);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Avançar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(656, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "CATEGORIA";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(616, 353);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Hatch";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(689, 353);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 24);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "SUV";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(762, 353);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 24);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Sedan";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBoxClientesCompra
            // 
            this.comboBoxClientesCompra.FormattingEnabled = true;
            this.comboBoxClientesCompra.Location = new System.Drawing.Point(536, 51);
            this.comboBoxClientesCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxClientesCompra.Name = "comboBoxClientesCompra";
            this.comboBoxClientesCompra.Size = new System.Drawing.Size(290, 28);
            this.comboBoxClientesCompra.TabIndex = 18;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(583, 103);
            this.maskedTextBoxCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxCpf.Mask = "999.999.999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(243, 27);
            this.maskedTextBoxCpf.TabIndex = 19;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(583, 179);
            this.maskedTextBoxCep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(243, 27);
            this.maskedTextBoxCep.TabIndex = 20;
            // 
            // ColumnColaborador
            // 
            this.ColumnColaborador.HeaderText = "Nome do Colaborador";
            this.ColumnColaborador.MinimumWidth = 6;
            this.ColumnColaborador.Name = "ColumnColaborador";
            this.ColumnColaborador.ReadOnly = true;
            this.ColumnColaborador.Width = 300;
            // 
            // ComprarVeiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(861, 541);
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
        private DataGridViewTextBoxColumn ColumnColaborador;
    }
}