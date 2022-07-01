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
            this.ColumnVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxContato = new System.Windows.Forms.TextBox();
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAvancar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxHatch = new System.Windows.Forms.CheckBox();
            this.checkBoxSuv = new System.Windows.Forms.CheckBox();
            this.checkBoxSedan = new System.Windows.Forms.CheckBox();
            this.comboBoxClientesCompra = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
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
            this.textBoxContato.Location = new System.Drawing.Point(453, 113);
            this.textBoxContato.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxContato.Name = "textBoxContato";
            this.textBoxContato.Size = new System.Drawing.Size(220, 23);
            this.textBoxContato.TabIndex = 5;
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(453, 177);
            this.textBoxEnderecoCompleto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(220, 23);
            this.textBoxEnderecoCompleto.TabIndex = 6;
            this.textBoxEnderecoCompleto.TextChanged += new System.EventHandler(this.textBoxEnderecoCompleto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(425, 87);
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
            this.label2.Location = new System.Drawing.Point(399, 116);
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
            this.label3.Location = new System.Drawing.Point(393, 180);
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
            this.label4.Location = new System.Drawing.Point(425, 149);
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
            // 
            // buttonAvancar
            // 
            this.buttonAvancar.Location = new System.Drawing.Point(583, 383);
            this.buttonAvancar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAvancar.Name = "buttonAvancar";
            this.buttonAvancar.Size = new System.Drawing.Size(90, 34);
            this.buttonAvancar.TabIndex = 13;
            this.buttonAvancar.Text = "Comprar";
            this.buttonAvancar.UseVisualStyleBackColor = true;
            this.buttonAvancar.Click += new System.EventHandler(this.buttonAvancar_Click);
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
            // checkBoxHatch
            // 
            this.checkBoxHatch.AutoSize = true;
            this.checkBoxHatch.Location = new System.Drawing.Point(492, 250);
            this.checkBoxHatch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxHatch.Name = "checkBoxHatch";
            this.checkBoxHatch.Size = new System.Drawing.Size(58, 19);
            this.checkBoxHatch.TabIndex = 15;
            this.checkBoxHatch.Text = "Hatch";
            this.checkBoxHatch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSuv
            // 
            this.checkBoxSuv.AutoSize = true;
            this.checkBoxSuv.Location = new System.Drawing.Point(550, 250);
            this.checkBoxSuv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxSuv.Name = "checkBoxSuv";
            this.checkBoxSuv.Size = new System.Drawing.Size(47, 19);
            this.checkBoxSuv.TabIndex = 16;
            this.checkBoxSuv.Text = "SUV";
            this.checkBoxSuv.UseVisualStyleBackColor = true;
            // 
            // checkBoxSedan
            // 
            this.checkBoxSedan.AutoSize = true;
            this.checkBoxSedan.Location = new System.Drawing.Point(609, 250);
            this.checkBoxSedan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxSedan.Name = "checkBoxSedan";
            this.checkBoxSedan.Size = new System.Drawing.Size(58, 19);
            this.checkBoxSedan.TabIndex = 17;
            this.checkBoxSedan.Text = "Sedan";
            this.checkBoxSedan.UseVisualStyleBackColor = true;
            // 
            // comboBoxClientesCompra
            // 
            this.comboBoxClientesCompra.FormattingEnabled = true;
            this.comboBoxClientesCompra.Location = new System.Drawing.Point(416, 42);
            this.comboBoxClientesCompra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxClientesCompra.Name = "comboBoxClientesCompra";
            this.comboBoxClientesCompra.Size = new System.Drawing.Size(258, 23);
            this.comboBoxClientesCompra.TabIndex = 18;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(453, 83);
            this.maskedTextBoxCpf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBoxCpf.Mask = "999.999.999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(220, 23);
            this.maskedTextBoxCpf.TabIndex = 19;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(453, 144);
            this.maskedTextBoxCep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(220, 23);
            this.maskedTextBoxCep.TabIndex = 20;
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave);
            // 
            // ComprarVeiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(689, 433);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.comboBoxClientesCompra);
            this.Controls.Add(this.checkBoxSedan);
            this.Controls.Add(this.checkBoxSuv);
            this.Controls.Add(this.checkBoxHatch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAvancar);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnderecoCompleto);
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
        private TextBox textBoxEnderecoCompleto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonClear;
        private Button buttonAvancar;
        private Label label5;
        private CheckBox checkBoxHatch;
        private CheckBox checkBoxSuv;
        private CheckBox checkBoxSedan;
        private ComboBox comboBoxClientesCompra;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxCep;
        private DataGridViewTextBoxColumn ColumnNomeEmpresa;
        private DataGridViewTextBoxColumn ColumnVeiculo;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnValorVeiculo;
    }
}