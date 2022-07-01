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
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbaComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAbaComprar
            // 
            this.dataGridViewAbaComprar.AllowUserToAddRows = false;
            this.dataGridViewAbaComprar.AllowUserToDeleteRows = false;
            this.dataGridViewAbaComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbaComprar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnModelo,
            this.ColumnPlaca,
            this.ColumnMarca,
            this.ColumnCategoria,
            this.ColumnPreco});
            this.dataGridViewAbaComprar.Location = new System.Drawing.Point(14, 71);
            this.dataGridViewAbaComprar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAbaComprar.Name = "dataGridViewAbaComprar";
            this.dataGridViewAbaComprar.ReadOnly = true;
            this.dataGridViewAbaComprar.RowHeadersWidth = 51;
            this.dataGridViewAbaComprar.RowTemplate.Height = 29;
            this.dataGridViewAbaComprar.Size = new System.Drawing.Size(483, 416);
            this.dataGridViewAbaComprar.TabIndex = 2;
            // 
            // textBoxContato
            // 
            this.textBoxContato.Location = new System.Drawing.Point(568, 143);
            this.textBoxContato.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxContato.Name = "textBoxContato";
            this.textBoxContato.Size = new System.Drawing.Size(274, 27);
            this.textBoxContato.TabIndex = 5;
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(568, 223);
            this.textBoxEnderecoCompleto.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(274, 27);
            this.textBoxEnderecoCompleto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(532, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(500, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(497, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(532, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "CEP";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(610, 479);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 42);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAvancar
            // 
            this.buttonAvancar.Location = new System.Drawing.Point(729, 479);
            this.buttonAvancar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonAvancar.Name = "buttonAvancar";
            this.buttonAvancar.Size = new System.Drawing.Size(112, 42);
            this.buttonAvancar.TabIndex = 13;
            this.buttonAvancar.Text = "Comprar";
            this.buttonAvancar.UseVisualStyleBackColor = true;
            this.buttonAvancar.Click += new System.EventHandler(this.buttonAvancar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(655, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "CATEGORIA";
            // 
            // checkBoxHatch
            // 
            this.checkBoxHatch.AutoSize = true;
            this.checkBoxHatch.Location = new System.Drawing.Point(615, 312);
            this.checkBoxHatch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.checkBoxHatch.Name = "checkBoxHatch";
            this.checkBoxHatch.Size = new System.Drawing.Size(70, 24);
            this.checkBoxHatch.TabIndex = 15;
            this.checkBoxHatch.Text = "Hatch";
            this.checkBoxHatch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSuv
            // 
            this.checkBoxSuv.AutoSize = true;
            this.checkBoxSuv.Location = new System.Drawing.Point(688, 312);
            this.checkBoxSuv.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.checkBoxSuv.Name = "checkBoxSuv";
            this.checkBoxSuv.Size = new System.Drawing.Size(58, 24);
            this.checkBoxSuv.TabIndex = 16;
            this.checkBoxSuv.Text = "SUV";
            this.checkBoxSuv.UseVisualStyleBackColor = true;
            // 
            // checkBoxSedan
            // 
            this.checkBoxSedan.AutoSize = true;
            this.checkBoxSedan.Location = new System.Drawing.Point(761, 312);
            this.checkBoxSedan.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.checkBoxSedan.Name = "checkBoxSedan";
            this.checkBoxSedan.Size = new System.Drawing.Size(72, 24);
            this.checkBoxSedan.TabIndex = 17;
            this.checkBoxSedan.Text = "Sedan";
            this.checkBoxSedan.UseVisualStyleBackColor = true;
            // 
            // comboBoxClientesCompra
            // 
            this.comboBoxClientesCompra.FormattingEnabled = true;
            this.comboBoxClientesCompra.Location = new System.Drawing.Point(520, 52);
            this.comboBoxClientesCompra.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBoxClientesCompra.Name = "comboBoxClientesCompra";
            this.comboBoxClientesCompra.Size = new System.Drawing.Size(322, 28);
            this.comboBoxClientesCompra.TabIndex = 18;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(568, 106);
            this.maskedTextBoxCpf.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.maskedTextBoxCpf.Mask = "999.999.999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(274, 27);
            this.maskedTextBoxCpf.TabIndex = 19;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(568, 182);
            this.maskedTextBoxCep.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(274, 27);
            this.maskedTextBoxCep.TabIndex = 20;
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnModelo
            // 
            this.ColumnModelo.HeaderText = "Modelo";
            this.ColumnModelo.MinimumWidth = 6;
            this.ColumnModelo.Name = "ColumnModelo";
            this.ColumnModelo.ReadOnly = true;
            this.ColumnModelo.Width = 80;
            // 
            // ColumnPlaca
            // 
            this.ColumnPlaca.HeaderText = "Placa";
            this.ColumnPlaca.MinimumWidth = 6;
            this.ColumnPlaca.Name = "ColumnPlaca";
            this.ColumnPlaca.ReadOnly = true;
            this.ColumnPlaca.Width = 90;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.MinimumWidth = 6;
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
            this.ColumnMarca.Width = 90;
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.MinimumWidth = 6;
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.ReadOnly = true;
            this.ColumnCategoria.Width = 80;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.MinimumWidth = 6;
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            this.ColumnPreco.Width = 90;
            // 
            // ComprarVeiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(861, 541);
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
            this.Controls.Add(this.dataGridViewAbaComprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ComprarVeiculosForm";
            this.Text = "ComprarVeiculosForm";
            this.Load += new System.EventHandler(this.ComprarVeiculosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbaComprar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAbaComprar;
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
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnModelo;
        private DataGridViewTextBoxColumn ColumnPlaca;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPreco;
    }
}