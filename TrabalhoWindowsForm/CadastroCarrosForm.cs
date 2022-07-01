﻿using Newtonsoft.Json;
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
        private Button buttonVoltar;
        private Label labelPreco;
        private Button buttonSalvar;
        private Button buttonEditar;

        private List<Carro> carros;
        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        private string classe;

        private DataGridViewTextBoxColumn ColumnModelo;
        private DataGridViewTextBoxColumn ColumnPlaca;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPreco;
        private Label labelCategoria;
        private RadioButton radioButtonSuv;
        private RadioButton radioButtonSedam;
        private RadioButton radioButtonHatch;
        private TextBox textBoxMarca;
        private MaskedTextBox maskedTextBoxPreco;
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
            this.ColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelPreco = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.radioButtonSuv = new System.Windows.Forms.RadioButton();
            this.radioButtonSedam = new System.Windows.Forms.RadioButton();
            this.radioButtonHatch = new System.Windows.Forms.RadioButton();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(322, 7);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(146, 28);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Location = new System.Drawing.Point(486, 7);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(156, 28);
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnModelo
            // 
            this.ColumnModelo.HeaderText = "Modelo";
            this.ColumnModelo.MinimumWidth = 6;
            this.ColumnModelo.Name = "ColumnModelo";
            this.ColumnModelo.ReadOnly = true;
            this.ColumnModelo.Width = 125;
            // 
            // ColumnPlaca
            // 
            this.ColumnPlaca.HeaderText = "Placa";
            this.ColumnPlaca.MinimumWidth = 6;
            this.ColumnPlaca.Name = "ColumnPlaca";
            this.ColumnPlaca.ReadOnly = true;
            this.ColumnPlaca.Width = 125;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.MinimumWidth = 6;
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
            this.ColumnMarca.Width = 125;
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
            this.ColumnPreco.Width = 125;
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
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(770, 499);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 30);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.BackColor = System.Drawing.Color.Transparent;
            this.labelPreco.Location = new System.Drawing.Point(613, 209);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(46, 20);
            this.labelPreco.TabIndex = 12;
            this.labelPreco.Text = "Preço";
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
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategoria.Location = new System.Drawing.Point(634, 298);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(135, 40);
            this.labelCategoria.TabIndex = 15;
            this.labelCategoria.Text = "Categoria";
            // 
            // radioButtonSuv
            // 
            this.radioButtonSuv.AutoSize = true;
            this.radioButtonSuv.Location = new System.Drawing.Point(634, 341);
            this.radioButtonSuv.Name = "radioButtonSuv";
            this.radioButtonSuv.Size = new System.Drawing.Size(57, 24);
            this.radioButtonSuv.TabIndex = 16;
            this.radioButtonSuv.TabStop = true;
            this.radioButtonSuv.Text = "SUV";
            this.radioButtonSuv.UseVisualStyleBackColor = true;
            // 
            // radioButtonSedam
            // 
            this.radioButtonSedam.AutoSize = true;
            this.radioButtonSedam.Location = new System.Drawing.Point(634, 371);
            this.radioButtonSedam.Name = "radioButtonSedam";
            this.radioButtonSedam.Size = new System.Drawing.Size(76, 24);
            this.radioButtonSedam.TabIndex = 17;
            this.radioButtonSedam.TabStop = true;
            this.radioButtonSedam.Text = "Sedam";
            this.radioButtonSedam.UseVisualStyleBackColor = true;
            // 
            // radioButtonHatch
            // 
            this.radioButtonHatch.AutoSize = true;
            this.radioButtonHatch.Location = new System.Drawing.Point(634, 401);
            this.radioButtonHatch.Name = "radioButtonHatch";
            this.radioButtonHatch.Size = new System.Drawing.Size(74, 24);
            this.radioButtonHatch.TabIndex = 18;
            this.radioButtonHatch.TabStop = true;
            this.radioButtonHatch.Text = "Hatcht";
            this.radioButtonHatch.UseVisualStyleBackColor = true;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(613, 172);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(236, 27);
            this.textBoxMarca.TabIndex = 19;
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(613, 242);
            this.maskedTextBoxPreco.Mask = "R$ 00.000";
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(236, 27);
            this.maskedTextBoxPreco.TabIndex = 20;
            // 
            // CadastroCarrosForm
            // 
            this.ClientSize = new System.Drawing.Size(950, 541);
            this.Controls.Add(this.maskedTextBoxPreco);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.radioButtonHatch);
            this.Controls.Add(this.radioButtonSedam);
            this.Controls.Add(this.radioButtonSuv);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.buttonVoltar);
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

        public void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxPlaca.Text = "";
            textBoxMarca.Text = "";
            radioButtonSuv.Checked = false;
            radioButtonSedam.Checked = false;
            radioButtonHatch.Checked = false;
            maskedTextBoxPreco = null;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var modelo = textBoxNome.Text.Trim();
            var placa = textBoxPlaca.Text.Trim();
            var marca = textBoxMarca.Text.Trim();
            var preco = Convert.ToDouble(maskedTextBoxPreco.Text.Trim());
            var categoria = classe;

            if (indiceLinhaSelecionada == -1)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    ++codigo, modelo, placa, marca, preco, categoria
                });

                textBoxNome.Text = "";
                textBoxPlaca.Text = "";
                textBoxMarca.Text = "";
                maskedTextBoxPreco.Text = "";
                radioButtonSuv.Checked = false;
                radioButtonSedam.Checked = false;
                radioButtonHatch.Checked = false;
            }

            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Insira o modelo do carro.");
                return;
            }
            else if (textBoxPlaca.Text == "")
            {
                MessageBox.Show("Insira a placa do carro.");
                return;
            }
            else if (textBoxMarca.Text == "")
            {
                MessageBox.Show("Insira a marca do carro.");
                return;
            }
            else if (maskedTextBoxPreco.Text == "")
            {
                MessageBox.Show("Insira o Preço do carro.");
                return;
            }
            else if ((radioButtonSuv.Checked == false) && (radioButtonSedam.Checked == false) && (radioButtonHatch.Checked == false))
            {
                MessageBox.Show("Informe a categoria.");
                return;
            }

            AdicionarCarroSalvandoArquivo(modelo, placa, marca, preco, classe);
        }

        public void buttonEditar_Click(object sender, EventArgs e)
        {
            var modelo = textBoxNome.Text.Trim();
            var placa = textBoxPlaca.Text.Trim();
            var marca = textBoxMarca.Text.Trim();
            var preco = maskedTextBoxPreco.Text.Trim();

            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um carro.");
                return;
            }
            // Obter a linha que o usuário selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter a informação da linha selecionada passado a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxPlaca.Text = placa;
            textBoxMarca.Text = marca;
            var categoria = classe;
            maskedTextBoxPreco.Text = preco;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarCarroSalvandoArquivo(string modelo, string placa, string marca, double preco, string classe)
        {
            var carro = new Carro
            {
                Modelo = modelo,
                Placa = placa,
                Marca = marca,
                Preco = preco,
                Categoria = classe
            };
            carros.Add(carro);

            SalvarArquivo();

            LimparCampos();
        }
        private void SalvarArquivo()
        {
            var carroJson = JsonConvert.SerializeObject(carros);
            File.WriteAllText("carro.json", carroJson);
        }

        private void ValidarSuvSedamHatch()
        {
            if (radioButtonSuv.Checked == true)
                classe = "SUV";

            else if (radioButtonSedam.Checked == true)
                classe = "Sedam";

            else if (radioButtonHatch.Checked == true)
                classe = "Hatch";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void EditarDados(string modelo, string placa, string marca, string categoria, double preco)
        {
            carros[indiceLinhaSelecionada].Modelo = modelo;
            carros[indiceLinhaSelecionada].Placa = placa;
            carros[indiceLinhaSelecionada].Marca = marca;
            carros[indiceLinhaSelecionada].Categoria = categoria;
            carros[indiceLinhaSelecionada].Preco = preco;

            SalvarArquivo();

            LimparCampos();
        }
    }
}