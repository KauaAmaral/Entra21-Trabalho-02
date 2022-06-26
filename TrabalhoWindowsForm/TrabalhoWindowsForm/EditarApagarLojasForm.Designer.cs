namespace TrabalhoWindowsForm
{
    partial class EditarApagarLojasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarApagarLojasForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.textBoxNomeContato = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.textBoxNomeFantasia = new System.Windows.Forms.TextBox();
            this.labelNomeContato = new System.Windows.Forms.Label();
            this.textBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.labelServicos = new System.Windows.Forms.Label();
            this.labelAtiva = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.labelDataDeAbertura = new System.Windows.Forms.Label();
            this.labelNomeFantasia = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.labelRazaoSocial = new System.Windows.Forms.Label();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.dateTimePickerDataDeAbertura = new System.Windows.Forms.DateTimePicker();
            this.checkBoxConsertos = new System.Windows.Forms.CheckBox();
            this.checkBoxAlugueis = new System.Windows.Forms.CheckBox();
            this.checkBoxCompras = new System.Windows.Forms.CheckBox();
            this.checkBoxVendas = new System.Windows.Forms.CheckBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelSelecionarLoja = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(689, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 126);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(33, 492);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(175, 23);
            this.buttonCancelar.TabIndex = 39;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(133, 320);
            this.maskedTextBoxTelefone.Mask = "(99) 9999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(75, 23);
            this.maskedTextBoxTelefone.TabIndex = 38;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(133, 278);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(94, 23);
            this.maskedTextBoxCep.TabIndex = 37;
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(133, 131);
            this.maskedTextBoxCnpj.Mask = "99.999.999/9999-99";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(94, 23);
            this.maskedTextBoxCnpj.TabIndex = 36;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(197, 400);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(47, 19);
            this.radioButtonNao.TabIndex = 35;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Checked = true;
            this.radioButtonSim.Location = new System.Drawing.Point(133, 400);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(45, 19);
            this.radioButtonSim.TabIndex = 34;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeContato
            // 
            this.textBoxNomeContato.Location = new System.Drawing.Point(322, 318);
            this.textBoxNomeContato.Name = "textBoxNomeContato";
            this.textBoxNomeContato.Size = new System.Drawing.Size(310, 23);
            this.textBoxNomeContato.TabIndex = 33;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(133, 358);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(499, 23);
            this.textBoxEMail.TabIndex = 32;
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(322, 279);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(310, 23);
            this.textBoxLogradouro.TabIndex = 31;
            // 
            // textBoxNomeFantasia
            // 
            this.textBoxNomeFantasia.Location = new System.Drawing.Point(133, 204);
            this.textBoxNomeFantasia.Name = "textBoxNomeFantasia";
            this.textBoxNomeFantasia.Size = new System.Drawing.Size(499, 23);
            this.textBoxNomeFantasia.TabIndex = 30;
            // 
            // labelNomeContato
            // 
            this.labelNomeContato.AutoSize = true;
            this.labelNomeContato.Location = new System.Drawing.Point(230, 323);
            this.labelNomeContato.Name = "labelNomeContato";
            this.labelNomeContato.Size = new System.Drawing.Size(86, 15);
            this.labelNomeContato.TabIndex = 27;
            this.labelNomeContato.Text = "Nome Contato";
            // 
            // textBoxRazaoSocial
            // 
            this.textBoxRazaoSocial.Location = new System.Drawing.Point(133, 166);
            this.textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            this.textBoxRazaoSocial.Size = new System.Drawing.Size(499, 23);
            this.textBoxRazaoSocial.TabIndex = 29;
            // 
            // labelServicos
            // 
            this.labelServicos.AutoSize = true;
            this.labelServicos.Location = new System.Drawing.Point(33, 441);
            this.labelServicos.Name = "labelServicos";
            this.labelServicos.Size = new System.Drawing.Size(50, 15);
            this.labelServicos.TabIndex = 26;
            this.labelServicos.Text = "Serviços";
            // 
            // labelAtiva
            // 
            this.labelAtiva.AutoSize = true;
            this.labelAtiva.Location = new System.Drawing.Point(33, 402);
            this.labelAtiva.Name = "labelAtiva";
            this.labelAtiva.Size = new System.Drawing.Size(34, 15);
            this.labelAtiva.TabIndex = 28;
            this.labelAtiva.Text = "Ativa";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(33, 361);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(41, 15);
            this.labelEMail.TabIndex = 25;
            this.labelEMail.Text = "E-Mail";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(247, 281);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(69, 15);
            this.labelLogradouro.TabIndex = 24;
            this.labelLogradouro.Text = "Logradouro";
            // 
            // labelDataDeAbertura
            // 
            this.labelDataDeAbertura.AutoSize = true;
            this.labelDataDeAbertura.Location = new System.Drawing.Point(33, 246);
            this.labelDataDeAbertura.Name = "labelDataDeAbertura";
            this.labelDataDeAbertura.Size = new System.Drawing.Size(96, 15);
            this.labelDataDeAbertura.TabIndex = 23;
            this.labelDataDeAbertura.Text = "Data de Abertura";
            // 
            // labelNomeFantasia
            // 
            this.labelNomeFantasia.AutoSize = true;
            this.labelNomeFantasia.Location = new System.Drawing.Point(33, 209);
            this.labelNomeFantasia.Name = "labelNomeFantasia";
            this.labelNomeFantasia.Size = new System.Drawing.Size(86, 15);
            this.labelNomeFantasia.TabIndex = 22;
            this.labelNomeFantasia.Text = "Nome Fantasia";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(33, 323);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(51, 15);
            this.labelTelefone.TabIndex = 21;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(33, 281);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(28, 15);
            this.labelCep.TabIndex = 20;
            this.labelCep.Text = "CEP";
            // 
            // labelRazaoSocial
            // 
            this.labelRazaoSocial.AutoSize = true;
            this.labelRazaoSocial.Location = new System.Drawing.Point(33, 171);
            this.labelRazaoSocial.Name = "labelRazaoSocial";
            this.labelRazaoSocial.Size = new System.Drawing.Size(72, 15);
            this.labelRazaoSocial.TabIndex = 19;
            this.labelRazaoSocial.Text = "Razão Social";
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(33, 134);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(34, 15);
            this.labelCnpj.TabIndex = 18;
            this.labelCnpj.Text = "CNPJ";
            // 
            // dateTimePickerDataDeAbertura
            // 
            this.dateTimePickerDataDeAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDeAbertura.Location = new System.Drawing.Point(133, 240);
            this.dateTimePickerDataDeAbertura.MaxDate = new System.DateTime(2022, 6, 25, 0, 0, 0, 0);
            this.dateTimePickerDataDeAbertura.Name = "dateTimePickerDataDeAbertura";
            this.dateTimePickerDataDeAbertura.Size = new System.Drawing.Size(94, 23);
            this.dateTimePickerDataDeAbertura.TabIndex = 17;
            this.dateTimePickerDataDeAbertura.Value = new System.DateTime(2022, 6, 25, 0, 0, 0, 0);
            // 
            // checkBoxConsertos
            // 
            this.checkBoxConsertos.AutoSize = true;
            this.checkBoxConsertos.Location = new System.Drawing.Point(360, 441);
            this.checkBoxConsertos.Name = "checkBoxConsertos";
            this.checkBoxConsertos.Size = new System.Drawing.Size(79, 19);
            this.checkBoxConsertos.TabIndex = 16;
            this.checkBoxConsertos.Text = "Consertos";
            this.checkBoxConsertos.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlugueis
            // 
            this.checkBoxAlugueis.AutoSize = true;
            this.checkBoxAlugueis.Location = new System.Drawing.Point(282, 440);
            this.checkBoxAlugueis.Name = "checkBoxAlugueis";
            this.checkBoxAlugueis.Size = new System.Drawing.Size(72, 19);
            this.checkBoxAlugueis.TabIndex = 15;
            this.checkBoxAlugueis.Text = "Aluguéis";
            this.checkBoxAlugueis.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompras
            // 
            this.checkBoxCompras.AutoSize = true;
            this.checkBoxCompras.Location = new System.Drawing.Point(202, 441);
            this.checkBoxCompras.Name = "checkBoxCompras";
            this.checkBoxCompras.Size = new System.Drawing.Size(74, 19);
            this.checkBoxCompras.TabIndex = 14;
            this.checkBoxCompras.Text = "Compras";
            this.checkBoxCompras.UseVisualStyleBackColor = true;
            // 
            // checkBoxVendas
            // 
            this.checkBoxVendas.AutoSize = true;
            this.checkBoxVendas.Location = new System.Drawing.Point(133, 441);
            this.checkBoxVendas.Name = "checkBoxVendas";
            this.checkBoxVendas.Size = new System.Drawing.Size(63, 19);
            this.checkBoxVendas.TabIndex = 13;
            this.checkBoxVendas.Text = "Vendas";
            this.checkBoxVendas.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(360, 492);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(272, 23);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // labelSelecionarLoja
            // 
            this.labelSelecionarLoja.AutoSize = true;
            this.labelSelecionarLoja.Location = new System.Drawing.Point(289, 37);
            this.labelSelecionarLoja.Name = "labelSelecionarLoja";
            this.labelSelecionarLoja.Size = new System.Drawing.Size(86, 15);
            this.labelSelecionarLoja.TabIndex = 18;
            this.labelSelecionarLoja.Text = "Selecionar Loja";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(599, 23);
            this.comboBox1.TabIndex = 41;
            // 
            // EditarApagarLojasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 532);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.maskedTextBoxCnpj);
            this.Controls.Add(this.radioButtonNao);
            this.Controls.Add(this.radioButtonSim);
            this.Controls.Add(this.textBoxNomeContato);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.textBoxLogradouro);
            this.Controls.Add(this.textBoxNomeFantasia);
            this.Controls.Add(this.labelNomeContato);
            this.Controls.Add(this.textBoxRazaoSocial);
            this.Controls.Add(this.labelServicos);
            this.Controls.Add(this.labelAtiva);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.labelLogradouro);
            this.Controls.Add(this.labelDataDeAbertura);
            this.Controls.Add(this.labelNomeFantasia);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.labelRazaoSocial);
            this.Controls.Add(this.labelSelecionarLoja);
            this.Controls.Add(this.labelCnpj);
            this.Controls.Add(this.dateTimePickerDataDeAbertura);
            this.Controls.Add(this.checkBoxConsertos);
            this.Controls.Add(this.checkBoxAlugueis);
            this.Controls.Add(this.checkBoxCompras);
            this.Controls.Add(this.checkBoxVendas);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "EditarApagarLojasForm";
            this.Text = "EditarApagarLojasForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonCancelar;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxCep;
        private MaskedTextBox maskedTextBoxCnpj;
        private RadioButton radioButtonNao;
        private RadioButton radioButtonSim;
        private TextBox textBoxNomeContato;
        private TextBox textBoxEMail;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNomeFantasia;
        private Label labelNomeContato;
        private TextBox textBoxRazaoSocial;
        private Label labelServicos;
        private Label labelAtiva;
        private Label labelEMail;
        private Label labelLogradouro;
        private Label labelDataDeAbertura;
        private Label labelNomeFantasia;
        private Label labelTelefone;
        private Label labelCep;
        private Label labelRazaoSocial;
        private Label labelCnpj;
        private DateTimePicker dateTimePickerDataDeAbertura;
        private CheckBox checkBoxConsertos;
        private CheckBox checkBoxAlugueis;
        private CheckBox checkBoxCompras;
        private CheckBox checkBoxVendas;
        private Button buttonSalvar;
        private Label labelSelecionarLoja;
        private ComboBox comboBox1;
    }
}