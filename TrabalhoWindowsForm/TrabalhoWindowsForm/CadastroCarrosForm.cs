using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoWindowsForm
{
    public partial class CadastroCarrosForm : Form
    {
        private Button buttonLimparCampos;
        private DataGridView dataGridView1;
        private Label labelModelo;
        private TextBox textBoxNome;
        private Label labelPlaca;
        private TextBox textBoxPlaca;
        private Label labelMarca;
        private Label labelCategoria;
        private Button buttonVoltar;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxMarca;
        private Label labelPreco;
        private TextBox textBoxPreco;
        private Button buttonSalvar;
        private Button buttonEditar;

        public CadastroCarrosForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(364, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Location = new System.Drawing.Point(459, 12);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(103, 23);
            this.buttonLimparCampos.TabIndex = 1;
            this.buttonLimparCampos.Text = "Limpar Campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(596, 285);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(603, 20);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(48, 15);
            this.labelModelo.TabIndex = 3;
            this.labelModelo.Text = "Modelo";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(603, 38);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(232, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(603, 64);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(35, 15);
            this.labelPlaca.TabIndex = 5;
            this.labelPlaca.Text = "Placa";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(603, 82);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(232, 23);
            this.textBoxPlaca.TabIndex = 6;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(603, 121);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 15);
            this.labelMarca.TabIndex = 7;
            this.labelMarca.Text = "Marca";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(603, 180);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(58, 15);
            this.labelCategoria.TabIndex = 8;
            this.labelCategoria.Text = "Categoria";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(813, 316);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "SUV",
            "Sedam",
            "SportBack"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(603, 198);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(232, 23);
            this.comboBoxCategoria.TabIndex = 10;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(603, 139);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(232, 23);
            this.comboBoxMarca.TabIndex = 11;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(603, 244);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(37, 15);
            this.labelPreco.TabIndex = 12;
            this.labelPreco.Text = "Preço";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(603, 262);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(232, 23);
            this.textBoxPreco.TabIndex = 13;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(708, 316);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // CadastroCarrosForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 351);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.buttonEditar);
            this.Name = "CadastroCarrosForm";
            this.Text = "Cadastro  de Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxPlaca.Text = "";
            comboBoxMarca.Text = "";
            comboBoxCategoria.Text = "";
            textBoxPreco = null;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Salvar();
        }
    }
}
