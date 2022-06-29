namespace TrabalhoWindowsForm
{
    partial class ClientesForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelDataDeNascimento = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(48, 143);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(48, 209);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(41, 15);
            this.labelEMail.TabIndex = 0;
            this.labelEMail.Text = "E-Mail";
            // 
            // labelDataDeNascimento
            // 
            this.labelDataDeNascimento.AutoSize = true;
            this.labelDataDeNascimento.Location = new System.Drawing.Point(48, 280);
            this.labelDataDeNascimento.Name = "labelDataDeNascimento";
            this.labelDataDeNascimento.Size = new System.Drawing.Size(112, 15);
            this.labelDataDeNascimento.TabIndex = 0;
            this.labelDataDeNascimento.Text = "Data de nascimento";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(807, 618);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(210, 23);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(441, 618);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(210, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Location = new System.Drawing.Point(48, 619);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(210, 23);
            this.buttonLimparCampos.TabIndex = 1;
            this.buttonLimparCampos.Text = "Limpar Campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(576, 525);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(48, 171);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(350, 23);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(48, 241);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(350, 23);
            this.textBoxEMail.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 309);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelDataDeNascimento);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.labelNome);
            this.Name = "ClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private Label labelEMail;
        private Label labelDataDeNascimento;
        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonLimparCampos;
        private DataGridView dataGridView1;
        private TextBox textBoxNome;
        private TextBox textBoxEMail;
        private DateTimePicker dateTimePicker1;
    }
}