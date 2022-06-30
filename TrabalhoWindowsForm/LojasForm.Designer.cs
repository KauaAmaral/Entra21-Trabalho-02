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
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRazaoSocial
            // 
            this.textBoxRazaoSocial.Location = new System.Drawing.Point(49, 229);
            this.textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            this.textBoxRazaoSocial.Size = new System.Drawing.Size(350, 23);
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
            this.dataGridView1.Location = new System.Drawing.Point(440, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 525);
            this.dataGridView1.TabIndex = 11;
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Location = new System.Drawing.Point(49, 618);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(210, 23);
            this.buttonLimparCampos.TabIndex = 8;
            this.buttonLimparCampos.Text = "Limpar Campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(806, 618);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(210, 23);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelNomeFantasia
            // 
            this.labelNomeFantasia.AutoSize = true;
            this.labelNomeFantasia.Location = new System.Drawing.Point(49, 282);
            this.labelNomeFantasia.Name = "labelNomeFantasia";
            this.labelNomeFantasia.Size = new System.Drawing.Size(86, 15);
            this.labelNomeFantasia.TabIndex = 5;
            this.labelNomeFantasia.Text = "Nome Fantasia";
            // 
            // labelRazaoSocial
            // 
            this.labelRazaoSocial.AutoSize = true;
            this.labelRazaoSocial.Location = new System.Drawing.Point(49, 211);
            this.labelRazaoSocial.Name = "labelRazaoSocial";
            this.labelRazaoSocial.Size = new System.Drawing.Size(72, 15);
            this.labelRazaoSocial.TabIndex = 6;
            this.labelRazaoSocial.Text = "Razão Social";
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(49, 145);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(34, 15);
            this.labelCnpj.TabIndex = 7;
            this.labelCnpj.Text = "CNPJ";
            // 
            // textBoxNomeFantasia
            // 
            this.textBoxNomeFantasia.Location = new System.Drawing.Point(49, 300);
            this.textBoxNomeFantasia.Name = "textBoxNomeFantasia";
            this.textBoxNomeFantasia.Size = new System.Drawing.Size(350, 23);
            this.textBoxNomeFantasia.TabIndex = 12;
            // 
            // labelAtiva
            // 
            this.labelAtiva.AutoSize = true;
            this.labelAtiva.Location = new System.Drawing.Point(49, 354);
            this.labelAtiva.Name = "labelAtiva";
            this.labelAtiva.Size = new System.Drawing.Size(34, 15);
            this.labelAtiva.TabIndex = 5;
            this.labelAtiva.Text = "Ativa";
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(49, 372);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(45, 19);
            this.radioButtonSim.TabIndex = 14;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(112, 372);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(47, 19);
            this.radioButtonNao.TabIndex = 14;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // labelServicos
            // 
            this.labelServicos.AutoSize = true;
            this.labelServicos.Location = new System.Drawing.Point(49, 420);
            this.labelServicos.Name = "labelServicos";
            this.labelServicos.Size = new System.Drawing.Size(50, 15);
            this.labelServicos.TabIndex = 5;
            this.labelServicos.Text = "Serviços";
            // 
            // checkBoxVendas
            // 
            this.checkBoxVendas.AutoSize = true;
            this.checkBoxVendas.Location = new System.Drawing.Point(51, 442);
            this.checkBoxVendas.Name = "checkBoxVendas";
            this.checkBoxVendas.Size = new System.Drawing.Size(63, 19);
            this.checkBoxVendas.TabIndex = 15;
            this.checkBoxVendas.Text = "Vendas";
            this.checkBoxVendas.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlugueis
            // 
            this.checkBoxAlugueis.AutoSize = true;
            this.checkBoxAlugueis.Location = new System.Drawing.Point(129, 442);
            this.checkBoxAlugueis.Name = "checkBoxAlugueis";
            this.checkBoxAlugueis.Size = new System.Drawing.Size(72, 19);
            this.checkBoxAlugueis.TabIndex = 15;
            this.checkBoxAlugueis.Text = "Alugueis";
            this.checkBoxAlugueis.UseVisualStyleBackColor = true;
            // 
            // checkBoxConsertos
            // 
            this.checkBoxConsertos.AutoSize = true;
            this.checkBoxConsertos.Location = new System.Drawing.Point(216, 442);
            this.checkBoxConsertos.Name = "checkBoxConsertos";
            this.checkBoxConsertos.Size = new System.Drawing.Size(79, 19);
            this.checkBoxConsertos.TabIndex = 15;
            this.checkBoxConsertos.Text = "Consertos";
            this.checkBoxConsertos.UseVisualStyleBackColor = true;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(49, 541);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(350, 23);
            this.comboBoxCliente.TabIndex = 16;
            // 
            // labelSelecioneSeuPerfil
            // 
            this.labelSelecioneSeuPerfil.AutoSize = true;
            this.labelSelecioneSeuPerfil.Location = new System.Drawing.Point(49, 523);
            this.labelSelecioneSeuPerfil.Name = "labelSelecioneSeuPerfil";
            this.labelSelecioneSeuPerfil.Size = new System.Drawing.Size(109, 15);
            this.labelSelecioneSeuPerfil.TabIndex = 5;
            this.labelSelecioneSeuPerfil.Text = "Selecione Seu Perfil";
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(49, 163);
            this.maskedTextBoxCnpj.Mask = "99.999.999/9999-99";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(97, 23);
            this.maskedTextBoxCnpj.TabIndex = 17;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(578, 618);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(129, 23);
            this.buttonApagar.TabIndex = 18;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(441, 617);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(129, 23);
            this.buttonEditar.TabIndex = 19;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
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
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
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
            // LojasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
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