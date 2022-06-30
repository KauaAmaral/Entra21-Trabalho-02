using Newtonsoft.Json;
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

        private List<Carro> carros;
        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        private DataGridViewTextBoxColumn ColumnModelo;
        private DataGridViewTextBoxColumn ColumnPlaca;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPreco;
        private CarroServico carroServico;
        public CadastroCarrosForm()
        {
            InitializeComponent();
            carroServico = new CarroServico();
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
            this.ColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(393, 7);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 28);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Location = new System.Drawing.Point(488, 7);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(103, 28);
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModelo,
            this.ColumnPlaca,
            this.ColumnMarca,
            this.ColumnCategoria,
            this.ColumnPreco});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(579, 488);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.BackColor = System.Drawing.Color.Transparent;
            this.labelModelo.Location = new System.Drawing.Point(613, 43);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(61, 20);
            this.labelModelo.TabIndex = 3;
            this.labelModelo.Text = "Modelo";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(613, 66);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(236, 27);
            this.textBoxNome.TabIndex = 4;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.BackColor = System.Drawing.Color.Transparent;
            this.labelPlaca.Location = new System.Drawing.Point(609, 93);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(44, 20);
            this.labelPlaca.TabIndex = 5;
            this.labelPlaca.Text = "Placa";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(613, 113);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(236, 27);
            this.textBoxPlaca.TabIndex = 6;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.Transparent;
            this.labelMarca.Location = new System.Drawing.Point(609, 149);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(50, 20);
            this.labelMarca.TabIndex = 7;
            this.labelMarca.Text = "Marca";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.labelCategoria.Location = new System.Drawing.Point(609, 198);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(74, 20);
            this.labelCategoria.TabIndex = 8;
            this.labelCategoria.Text = "Categoria";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(770, 499);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 30);
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
            this.comboBoxCategoria.Location = new System.Drawing.Point(613, 221);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(236, 28);
            this.comboBoxCategoria.TabIndex = 10;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(613, 167);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(236, 28);
            this.comboBoxMarca.TabIndex = 11;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.BackColor = System.Drawing.Color.Transparent;
            this.labelPreco.Location = new System.Drawing.Point(613, 252);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(46, 20);
            this.labelPreco.TabIndex = 12;
            this.labelPreco.Text = "Preço";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(613, 275);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(236, 27);
            this.textBoxPreco.TabIndex = 13;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(665, 499);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 30);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // ColumnModelo
            // 
            this.ColumnModelo.HeaderText = "Modelo";
            this.ColumnModelo.MinimumWidth = 6;
            this.ColumnModelo.Name = "ColumnModelo";
            this.ColumnModelo.ReadOnly = true;
            // 
            // ColumnPlaca
            // 
            this.ColumnPlaca.HeaderText = "Placa";
            this.ColumnPlaca.MinimumWidth = 6;
            this.ColumnPlaca.Name = "ColumnPlaca";
            this.ColumnPlaca.ReadOnly = true;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.MinimumWidth = 6;
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.MinimumWidth = 6;
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.ReadOnly = true;
            this.ColumnCategoria.Width = 125;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.MinimumWidth = 6;
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            // 
            // CadastroCarrosForm
            // 
            this.ClientSize = new System.Drawing.Size(861, 541);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCarrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro  de Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxPlaca.Text = "";
            comboBoxMarca.Text = "";
            comboBoxCategoria.Text = "";
            textBoxPreco = null;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        public void buttonEditar_Click(object sender, EventArgs e)
        {
            AlteraCarro();
            //var editarCarro = new EditarCarro();
        }

        private void AlteraCarro()
        {
            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um carro.");
                return;
            }
            // Obter a linha que o usuário selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}