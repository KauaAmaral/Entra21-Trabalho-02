namespace TrabalhoWindowsForm
{
    partial class CadastroLojasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLojasForm));
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.checkBoxVendas = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDataDeAbertura = new System.Windows.Forms.DateTimePicker();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.textBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelRazaoSocial = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelEMail = new System.Windows.Forms.Label();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.labelNomeFantasia = new System.Windows.Forms.Label();
            this.textBoxNomeFantasia = new System.Windows.Forms.TextBox();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.labelNomeContato = new System.Windows.Forms.Label();
            this.textBoxNomeContato = new System.Windows.Forms.TextBox();
            this.labelDataDeAbertura = new System.Windows.Forms.Label();
            this.labelAtiva = new System.Windows.Forms.Label();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.labelServicos = new System.Windows.Forms.Label();
            this.checkBoxCompras = new System.Windows.Forms.CheckBox();
            this.checkBoxAlugueis = new System.Windows.Forms.CheckBox();
            this.checkBoxConsertos = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(358, 436);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(272, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(663, 190);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(168, 23);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(663, 225);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(168, 23);
            this.buttonApagar.TabIndex = 0;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // checkBoxVendas
            // 
            this.checkBoxVendas.AutoSize = true;
            this.checkBoxVendas.Location = new System.Drawing.Point(131, 385);
            this.checkBoxVendas.Name = "checkBoxVendas";
            this.checkBoxVendas.Size = new System.Drawing.Size(63, 19);
            this.checkBoxVendas.TabIndex = 1;
            this.checkBoxVendas.Text = "Vendas";
            this.checkBoxVendas.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataDeAbertura
            // 
            this.dateTimePickerDataDeAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDeAbertura.Location = new System.Drawing.Point(131, 184);
            this.dateTimePickerDataDeAbertura.MaxDate = new System.DateTime(2022, 6, 25, 0, 0, 0, 0);
            this.dateTimePickerDataDeAbertura.Name = "dateTimePickerDataDeAbertura";
            this.dateTimePickerDataDeAbertura.Size = new System.Drawing.Size(85, 23);
            this.dateTimePickerDataDeAbertura.TabIndex = 2;
            this.dateTimePickerDataDeAbertura.Value = new System.DateTime(2022, 6, 25, 0, 0, 0, 0);
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(31, 78);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(34, 15);
            this.labelCnpj.TabIndex = 3;
            this.labelCnpj.Text = "CNPJ";
            // 
            // textBoxRazaoSocial
            // 
            this.textBoxRazaoSocial.Location = new System.Drawing.Point(131, 110);
            this.textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            this.textBoxRazaoSocial.Size = new System.Drawing.Size(499, 23);
            this.textBoxRazaoSocial.TabIndex = 4;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Checked = true;
            this.radioButtonSim.Location = new System.Drawing.Point(131, 344);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(45, 19);
            this.radioButtonSim.TabIndex = 5;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(131, 75);
            this.maskedTextBoxCnpj.Mask = "99.999.999/9999-99";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(94, 23);
            this.maskedTextBoxCnpj.TabIndex = 6;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(31, 436);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(175, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // labelRazaoSocial
            // 
            this.labelRazaoSocial.AutoSize = true;
            this.labelRazaoSocial.Location = new System.Drawing.Point(31, 115);
            this.labelRazaoSocial.Name = "labelRazaoSocial";
            this.labelRazaoSocial.Size = new System.Drawing.Size(72, 15);
            this.labelRazaoSocial.TabIndex = 3;
            this.labelRazaoSocial.Text = "Razão Social";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(31, 267);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(51, 15);
            this.labelTelefone.TabIndex = 3;
            this.labelTelefone.Text = "Telefone";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(131, 264);
            this.maskedTextBoxTelefone.Mask = "(99) 9999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(75, 23);
            this.maskedTextBoxTelefone.TabIndex = 6;
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(31, 305);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(41, 15);
            this.labelEMail.TabIndex = 3;
            this.labelEMail.Text = "E-Mail";
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(131, 302);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(499, 23);
            this.textBoxEMail.TabIndex = 4;
            // 
            // labelNomeFantasia
            // 
            this.labelNomeFantasia.AutoSize = true;
            this.labelNomeFantasia.Location = new System.Drawing.Point(31, 153);
            this.labelNomeFantasia.Name = "labelNomeFantasia";
            this.labelNomeFantasia.Size = new System.Drawing.Size(86, 15);
            this.labelNomeFantasia.TabIndex = 3;
            this.labelNomeFantasia.Text = "Nome Fantasia";
            // 
            // textBoxNomeFantasia
            // 
            this.textBoxNomeFantasia.Location = new System.Drawing.Point(131, 148);
            this.textBoxNomeFantasia.Name = "textBoxNomeFantasia";
            this.textBoxNomeFantasia.Size = new System.Drawing.Size(499, 23);
            this.textBoxNomeFantasia.TabIndex = 4;
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(245, 225);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(69, 15);
            this.labelLogradouro.TabIndex = 3;
            this.labelLogradouro.Text = "Logradouro";
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(31, 225);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(28, 15);
            this.labelCep.TabIndex = 3;
            this.labelCep.Text = "CEP";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(131, 222);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(94, 23);
            this.maskedTextBoxCep.TabIndex = 6;
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(320, 223);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(310, 23);
            this.textBoxLogradouro.TabIndex = 4;
            // 
            // labelNomeContato
            // 
            this.labelNomeContato.AutoSize = true;
            this.labelNomeContato.Location = new System.Drawing.Point(228, 267);
            this.labelNomeContato.Name = "labelNomeContato";
            this.labelNomeContato.Size = new System.Drawing.Size(86, 15);
            this.labelNomeContato.TabIndex = 3;
            this.labelNomeContato.Text = "Nome Contato";
            // 
            // textBoxNomeContato
            // 
            this.textBoxNomeContato.Location = new System.Drawing.Point(320, 262);
            this.textBoxNomeContato.Name = "textBoxNomeContato";
            this.textBoxNomeContato.Size = new System.Drawing.Size(310, 23);
            this.textBoxNomeContato.TabIndex = 4;
            // 
            // labelDataDeAbertura
            // 
            this.labelDataDeAbertura.AutoSize = true;
            this.labelDataDeAbertura.Location = new System.Drawing.Point(31, 190);
            this.labelDataDeAbertura.Name = "labelDataDeAbertura";
            this.labelDataDeAbertura.Size = new System.Drawing.Size(96, 15);
            this.labelDataDeAbertura.TabIndex = 3;
            this.labelDataDeAbertura.Text = "Data de Abertura";
            // 
            // labelAtiva
            // 
            this.labelAtiva.AutoSize = true;
            this.labelAtiva.Location = new System.Drawing.Point(31, 346);
            this.labelAtiva.Name = "labelAtiva";
            this.labelAtiva.Size = new System.Drawing.Size(34, 15);
            this.labelAtiva.TabIndex = 3;
            this.labelAtiva.Text = "Ativa";
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(195, 344);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(47, 19);
            this.radioButtonNao.TabIndex = 5;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // labelServicos
            // 
            this.labelServicos.AutoSize = true;
            this.labelServicos.Location = new System.Drawing.Point(31, 385);
            this.labelServicos.Name = "labelServicos";
            this.labelServicos.Size = new System.Drawing.Size(50, 15);
            this.labelServicos.TabIndex = 3;
            this.labelServicos.Text = "Serviços";
            // 
            // checkBoxCompras
            // 
            this.checkBoxCompras.AutoSize = true;
            this.checkBoxCompras.Location = new System.Drawing.Point(200, 385);
            this.checkBoxCompras.Name = "checkBoxCompras";
            this.checkBoxCompras.Size = new System.Drawing.Size(74, 19);
            this.checkBoxCompras.TabIndex = 1;
            this.checkBoxCompras.Text = "Compras";
            this.checkBoxCompras.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlugueis
            // 
            this.checkBoxAlugueis.AutoSize = true;
            this.checkBoxAlugueis.Location = new System.Drawing.Point(280, 384);
            this.checkBoxAlugueis.Name = "checkBoxAlugueis";
            this.checkBoxAlugueis.Size = new System.Drawing.Size(72, 19);
            this.checkBoxAlugueis.TabIndex = 1;
            this.checkBoxAlugueis.Text = "Aluguéis";
            this.checkBoxAlugueis.UseVisualStyleBackColor = true;
            // 
            // checkBoxConsertos
            // 
            this.checkBoxConsertos.AutoSize = true;
            this.checkBoxConsertos.Location = new System.Drawing.Point(358, 385);
            this.checkBoxConsertos.Name = "checkBoxConsertos";
            this.checkBoxConsertos.Size = new System.Drawing.Size(79, 19);
            this.checkBoxConsertos.TabIndex = 1;
            this.checkBoxConsertos.Text = "Consertos";
            this.checkBoxConsertos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 126);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CadastroLojasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 531);
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
            this.Controls.Add(this.labelCnpj);
            this.Controls.Add(this.dateTimePickerDataDeAbertura);
            this.Controls.Add(this.checkBoxConsertos);
            this.Controls.Add(this.checkBoxAlugueis);
            this.Controls.Add(this.checkBoxCompras);
            this.Controls.Add(this.checkBoxVendas);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "CadastroLojasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Loja";
            this.Load += new System.EventHandler(this.CadastroLojasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonApagar;
        private CheckBox checkBoxVendas;
        private DateTimePicker dateTimePickerDataDeAbertura;
        private Label labelCnpj;
        private TextBox textBoxRazaoSocial;
        private RadioButton radioButtonSim;
        private MaskedTextBox maskedTextBoxCnpj;
        private Button buttonCancelar;
        private Label labelRazaoSocial;
        private Label labelTelefone;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label labelEMail;
        private TextBox textBoxEMail;
        private Label labelNomeFantasia;
        private TextBox textBoxNomeFantasia;
        private Label labelLogradouro;
        private Label labelCep;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox textBoxLogradouro;
        private Label labelNomeContato;
        private TextBox textBoxNomeContato;
        private Label labelDataDeAbertura;
        private Label labelAtiva;
        private RadioButton radioButtonNao;
        private Label labelServicos;
        private CheckBox checkBoxCompras;
        private CheckBox checkBoxAlugueis;
        private CheckBox checkBoxConsertos;
        private PictureBox pictureBox1;
    }
}