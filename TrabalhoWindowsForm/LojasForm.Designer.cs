namespace TrabalhoWindowsForm
{
    partial class LojasForm
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
            this.textBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelNomeFantasia = new System.Windows.Forms.Label();
            this.labelRazaoSocial = new System.Windows.Forms.Label();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.textBoxNomeFantasia = new System.Windows.Forms.TextBox();
            this.labelAtiva = new System.Windows.Forms.Label();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.labelServicos = new System.Windows.Forms.Label();
            this.checkBoxVendas = new System.Windows.Forms.CheckBox();
            this.checkBoxAlugueis = new System.Windows.Forms.CheckBox();
            this.checkBoxConsertos = new System.Windows.Forms.CheckBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labelSelecioneSeuPerfil = new System.Windows.Forms.Label();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRazaoSocial
            // 
            this.textBoxRazaoSocial.Location = new System.Drawing.Point(12, 148);
            this.textBoxRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            this.textBoxRazaoSocial.Size = new System.Drawing.Size(347, 27);
            this.textBoxRazaoSocial.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnCliente,
            this.ColumnCnpj,
            this.ColumnNomeFantasia,
            this.ColumnAtiva});
            this.dataGridView1.Location = new System.Drawing.Point(382, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(555, 604);
            this.dataGridView1.TabIndex = 11;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.MinimumWidth = 6;
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            this.ColumnCliente.Width = 125;
            // 
            // ColumnCnpj
            // 
            this.ColumnCnpj.HeaderText = "CNPJ";
            this.ColumnCnpj.MinimumWidth = 6;
            this.ColumnCnpj.Name = "ColumnCnpj";
            this.ColumnCnpj.ReadOnly = true;
            this.ColumnCnpj.Width = 125;
            // 
            // ColumnNomeFantasia
            // 
            this.ColumnNomeFantasia.HeaderText = "Nome Fantasia";
            this.ColumnNomeFantasia.MinimumWidth = 6;
            this.ColumnNomeFantasia.Name = "ColumnNomeFantasia";
            this.ColumnNomeFantasia.ReadOnly = true;
            this.ColumnNomeFantasia.Width = 125;
            // 
            // ColumnAtiva
            // 
            this.ColumnAtiva.HeaderText = "Ativa";
            this.ColumnAtiva.MinimumWidth = 6;
            this.ColumnAtiva.Name = "ColumnAtiva";
            this.ColumnAtiva.ReadOnly = true;
            this.ColumnAtiva.Width = 125;
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Location = new System.Drawing.Point(6, 627);
            this.buttonLimparCampos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(128, 31);
            this.buttonLimparCampos.TabIndex = 8;
            this.buttonLimparCampos.Text = "Limpar Campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(217, 627);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(143, 31);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelNomeFantasia
            // 
            this.labelNomeFantasia.AutoSize = true;
            this.labelNomeFantasia.Location = new System.Drawing.Point(12, 189);
            this.labelNomeFantasia.Name = "labelNomeFantasia";
            this.labelNomeFantasia.Size = new System.Drawing.Size(107, 20);
            this.labelNomeFantasia.TabIndex = 5;
            this.labelNomeFantasia.Text = "Nome Fantasia";
            // 
            // labelRazaoSocial
            // 
            this.labelRazaoSocial.AutoSize = true;
            this.labelRazaoSocial.Location = new System.Drawing.Point(12, 124);
            this.labelRazaoSocial.Name = "labelRazaoSocial";
            this.labelRazaoSocial.Size = new System.Drawing.Size(94, 20);
            this.labelRazaoSocial.TabIndex = 6;
            this.labelRazaoSocial.Text = "Razão Social";
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(12, 52);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(41, 20);
            this.labelCnpj.TabIndex = 7;
            this.labelCnpj.Text = "CNPJ";
            // 
            // textBoxNomeFantasia
            // 
            this.textBoxNomeFantasia.Location = new System.Drawing.Point(12, 213);
            this.textBoxNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNomeFantasia.Name = "textBoxNomeFantasia";
            this.textBoxNomeFantasia.Size = new System.Drawing.Size(347, 27);
            this.textBoxNomeFantasia.TabIndex = 12;
            // 
            // labelAtiva
            // 
            this.labelAtiva.AutoSize = true;
            this.labelAtiva.Location = new System.Drawing.Point(12, 256);
            this.labelAtiva.Name = "labelAtiva";
            this.labelAtiva.Size = new System.Drawing.Size(43, 20);
            this.labelAtiva.TabIndex = 5;
            this.labelAtiva.Text = "Ativa";
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Checked = true;
            this.radioButtonSim.Location = new System.Drawing.Point(12, 280);
            this.radioButtonSim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(55, 24);
            this.radioButtonSim.TabIndex = 14;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(84, 280);
            this.radioButtonNao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(58, 24);
            this.radioButtonNao.TabIndex = 14;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // labelServicos
            // 
            this.labelServicos.AutoSize = true;
            this.labelServicos.Location = new System.Drawing.Point(9, 322);
            this.labelServicos.Name = "labelServicos";
            this.labelServicos.Size = new System.Drawing.Size(63, 20);
            this.labelServicos.TabIndex = 5;
            this.labelServicos.Text = "Serviços";
            // 
            // checkBoxVendas
            // 
            this.checkBoxVendas.AutoSize = true;
            this.checkBoxVendas.Location = new System.Drawing.Point(12, 352);
            this.checkBoxVendas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxVendas.Name = "checkBoxVendas";
            this.checkBoxVendas.Size = new System.Drawing.Size(78, 24);
            this.checkBoxVendas.TabIndex = 15;
            this.checkBoxVendas.Text = "Vendas";
            this.checkBoxVendas.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlugueis
            // 
            this.checkBoxAlugueis.AutoSize = true;
            this.checkBoxAlugueis.Location = new System.Drawing.Point(101, 352);
            this.checkBoxAlugueis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxAlugueis.Name = "checkBoxAlugueis";
            this.checkBoxAlugueis.Size = new System.Drawing.Size(88, 24);
            this.checkBoxAlugueis.TabIndex = 15;
            this.checkBoxAlugueis.Text = "Alugueis";
            this.checkBoxAlugueis.UseVisualStyleBackColor = true;
            // 
            // checkBoxConsertos
            // 
            this.checkBoxConsertos.AutoSize = true;
            this.checkBoxConsertos.Location = new System.Drawing.Point(200, 352);
            this.checkBoxConsertos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxConsertos.Name = "checkBoxConsertos";
            this.checkBoxConsertos.Size = new System.Drawing.Size(96, 24);
            this.checkBoxConsertos.TabIndex = 15;
            this.checkBoxConsertos.Text = "Consertos";
            this.checkBoxConsertos.UseVisualStyleBackColor = true;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(9, 418);
            this.comboBoxCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(346, 28);
            this.comboBoxCliente.TabIndex = 16;
            // 
            // labelSelecioneSeuPerfil
            // 
            this.labelSelecioneSeuPerfil.AutoSize = true;
            this.labelSelecioneSeuPerfil.Location = new System.Drawing.Point(9, 394);
            this.labelSelecioneSeuPerfil.Name = "labelSelecioneSeuPerfil";
            this.labelSelecioneSeuPerfil.Size = new System.Drawing.Size(138, 20);
            this.labelSelecioneSeuPerfil.TabIndex = 5;
            this.labelSelecioneSeuPerfil.Text = "Selecione Seu Perfil";
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(12, 76);
            this.maskedTextBoxCnpj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxCnpj.Mask = "99.999.999/9999-99";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(110, 27);
            this.maskedTextBoxCnpj.TabIndex = 17;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(790, 13);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(147, 31);
            this.buttonApagar.TabIndex = 18;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(382, 13);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(147, 31);
            this.buttonEditar.TabIndex = 19;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // LojasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 671);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.maskedTextBoxCnpj);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.checkBoxConsertos);
            this.Controls.Add(this.checkBoxAlugueis);
            this.Controls.Add(this.checkBoxVendas);
            this.Controls.Add(this.radioButtonNao);
            this.Controls.Add(this.radioButtonSim);
            this.Controls.Add(this.textBoxNomeFantasia);
            this.Controls.Add(this.textBoxRazaoSocial);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelSelecioneSeuPerfil);
            this.Controls.Add(this.labelServicos);
            this.Controls.Add(this.labelAtiva);
            this.Controls.Add(this.labelNomeFantasia);
            this.Controls.Add(this.labelRazaoSocial);
            this.Controls.Add(this.labelCnpj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LojasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vendedor";
            this.Load += new System.EventHandler(this.LojasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxRazaoSocial;
        private DataGridView dataGridView1;
        private Button buttonLimparCampos;
        private Button buttonSalvar;
        private Label labelNomeFantasia;
        private Label labelRazaoSocial;
        private Label labelCnpj;
        private TextBox textBoxNomeFantasia;
        private Label labelAtiva;
        private RadioButton radioButtonSim;
        private RadioButton radioButtonNao;
        private Label labelServicos;
        private CheckBox checkBoxVendas;
        private CheckBox checkBoxAlugueis;
        private CheckBox checkBoxConsertos;
        private ComboBox comboBoxCliente;
        private Label labelSelecioneSeuPerfil;
        private MaskedTextBox maskedTextBoxCnpj;
        private Button buttonApagar;
        private Button buttonEditar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnCnpj;
        private DataGridViewTextBoxColumn ColumnNomeFantasia;
        private DataGridViewTextBoxColumn ColumnAtiva;
    }
}