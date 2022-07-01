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
        ///===================================================================================================================================
        private CarroServico carroServico;
        private ComprarVeiculosForm comprarVeiculosForm;
        private List<Carro> carros;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        private string classe;
        ///===================================================================================================================================
        private Button buttonLimparCampos;
        private DataGridView dataGridViewVeiculos;
        private Label labelModelo;
        private TextBox textBoxModelo;
        private Label labelPlaca;
        private TextBox textBoxPlaca;
        private Label labelMarca;
        private Label labelPreco;
        private Button buttonSalvar;
        private Button buttonEditar;
        private Label labelCategoria;
        private RadioButton radioButtonSuv;
        private RadioButton radioButtonSedam;
        private RadioButton radioButtonHatch;
        private TextBox textBoxMarca;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnModelo;
        private DataGridViewTextBoxColumn ColumnPlaca;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPreco;
        private Button buttonApagar;
        private TextBox textBoxPreco;
        public CadastroCarrosForm()
        {
            InitializeComponent();
            carroServico = new CarroServico();
            ListarCarros();
        }

        private void InitializeComponent()
        {
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.dataGridViewVeiculos = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.radioButtonSuv = new System.Windows.Forms.RadioButton();
            this.radioButtonSedam = new System.Windows.Forms.RadioButton();
            this.radioButtonHatch = new System.Windows.Forms.RadioButton();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).BeginInit();
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
            // dataGridViewVeiculos
            // 
            this.dataGridViewVeiculos.AllowUserToAddRows = false;
            this.dataGridViewVeiculos.AllowUserToDeleteRows = false;
            this.dataGridViewVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnModelo,
            this.ColumnPlaca,
            this.ColumnMarca,
            this.ColumnCategoria,
            this.ColumnPreco});
            this.dataGridViewVeiculos.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewVeiculos.Name = "dataGridViewVeiculos";
            this.dataGridViewVeiculos.ReadOnly = true;
            this.dataGridViewVeiculos.RowHeadersWidth = 51;
            this.dataGridViewVeiculos.RowTemplate.Height = 25;
            this.dataGridViewVeiculos.Size = new System.Drawing.Size(680, 488);
            this.dataGridViewVeiculos.TabIndex = 2;
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
            this.labelModelo.Location = new System.Drawing.Point(702, 43);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(61, 20);
            this.labelModelo.TabIndex = 3;
            this.labelModelo.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(702, 66);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(236, 27);
            this.textBoxModelo.TabIndex = 4;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.BackColor = System.Drawing.Color.Transparent;
            this.labelPlaca.Location = new System.Drawing.Point(698, 93);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(44, 20);
            this.labelPlaca.TabIndex = 5;
            this.labelPlaca.Text = "Placa";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(702, 113);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(236, 27);
            this.textBoxPlaca.TabIndex = 6;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.Transparent;
            this.labelMarca.Location = new System.Drawing.Point(698, 149);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(50, 20);
            this.labelMarca.TabIndex = 7;
            this.labelMarca.Text = "Marca";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.BackColor = System.Drawing.Color.Transparent;
            this.labelPreco.Location = new System.Drawing.Point(702, 209);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(46, 20);
            this.labelPreco.TabIndex = 12;
            this.labelPreco.Text = "Preço";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(825, 499);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(113, 30);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategoria.Location = new System.Drawing.Point(702, 287);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(158, 38);
            this.labelCategoria.TabIndex = 15;
            this.labelCategoria.Text = "Categoria";
            // 
            // radioButtonSuv
            // 
            this.radioButtonSuv.AutoSize = true;
            this.radioButtonSuv.Location = new System.Drawing.Point(702, 330);
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
            this.radioButtonSedam.Location = new System.Drawing.Point(702, 360);
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
            this.radioButtonHatch.Location = new System.Drawing.Point(702, 390);
            this.radioButtonHatch.Name = "radioButtonHatch";
            this.radioButtonHatch.Size = new System.Drawing.Size(74, 24);
            this.radioButtonHatch.TabIndex = 18;
            this.radioButtonHatch.TabStop = true;
            this.radioButtonHatch.Text = "Hatcht";
            this.radioButtonHatch.UseVisualStyleBackColor = true;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(702, 172);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(236, 27);
            this.textBoxMarca.TabIndex = 19;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(665, 7);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 21;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(702, 232);
            this.textBoxPreco.Multiline = true;
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(236, 27);
            this.textBoxPreco.TabIndex = 22;
            // 
            // CadastroCarrosForm
            // 
            this.ClientSize = new System.Drawing.Size(950, 541);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.radioButtonHatch);
            this.Controls.Add(this.radioButtonSedam);
            this.Controls.Add(this.radioButtonSuv);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.dataGridViewVeiculos);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.buttonEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCarrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro  de Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Focar no primeiro TextBox
            textBoxModelo.Focus();
            //Obter as informaçoes dos campos
            var modelo = textBoxModelo.Text.Trim();
            var placa = textBoxPlaca.Text.Trim();
            var marca = textBoxMarca.Text.Trim();
            var preco = textBoxPreco.Text.Trim();
            var categoria = classe;

            if (dataGridViewVeiculos.SelectedRows.Count == 0)
            {
                AdicionarCarroSalvandoArquivo(modelo, placa, marca, preco, categoria);

                return;
            }

            EditarDados(modelo, placa, marca, categoria, preco);
        }
        public void LimparCampos()
        {
            textBoxModelo.Text = "";
            textBoxPlaca.Text = "";
            textBoxMarca.Text = "";
            textBoxPreco.Text = "";
            radioButtonSuv.Checked = false;
            radioButtonSedam.Checked = false;
            radioButtonHatch.Checked = false;
        }
        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void EditarDados(string modelo, string placa, string marca, string categoria, string preco)
        {
            var carro = new Carro();
            carro.Modelo = modelo;
            carro.Placa = placa;
            carro.Marca = marca;
            carro.Categoria = categoria;
            carro.Preco = preco;

            var linhaSelecionada = dataGridViewVeiculos.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            carro.Codigo = codigo;

            carroServico.Editar(carro);

            LimparCampos();

            ListarCarros();
        }
        private void ListarCarros()
        {
            var carros = carroServico.ObterTodos();

            dataGridViewVeiculos.Rows.Clear();

            for (int i = 0; i < carros.Count; i++)
            {
                var carro = carros[i];

                dataGridViewVeiculos.Rows.Add(new object[]
                {
                    carro.Codigo,
                    carro.Modelo,
                    carro.Placa,
                    carro.Marca,
                    carro.Categoria,
                    carro.Preco,
                });
            }
            dataGridViewVeiculos.ClearSelection();
        }
        private bool ValidarDadosDoVeiculo()
        {
            bool validar;
            if (textBoxModelo.Text == "")
            {
                validar = false;
                MessageBox.Show("Insira o modelo do carro.");
            }
            else if (textBoxPlaca.Text == "")
            {
                validar = false;
                MessageBox.Show("Insira a placa do carro.");
            }
            else if (textBoxMarca.Text == "")
            {
                validar = false;
                MessageBox.Show("Insira a marca do carro.");
            }
            else if (textBoxPreco.Text == "")
            {
                validar = false;
                MessageBox.Show("Insira o Preço do carro.");
            }
            else if ((radioButtonSuv.Checked == false) && (radioButtonSedam.Checked == false) && (radioButtonHatch.Checked == false))
            {
                validar = false;
                MessageBox.Show("Informe a categoria.");
            }
            else
                validar = true;

            return validar;
        }
        public void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um Veiculo, Antes de Editar!");
                return;
            }

            var linhaSelecionada = dataGridViewVeiculos.SelectedRows[0];

            var modelo = linhaSelecionada.Cells[1].Value.ToString();
            var placa = linhaSelecionada.Cells[2].Value.ToString();
            var marca = linhaSelecionada.Cells[3].Value.ToString();
            var categoria = linhaSelecionada.Cells[4].Value;
            var preco = Convert.ToDouble(linhaSelecionada.Cells[5].Value);

            textBoxModelo.Text = modelo;
            textBoxPlaca.Text = placa;
            textBoxMarca.Text = marca;
            textBoxPreco.Text = preco.ToString();
            radioButtonHatch.Checked = false;
            radioButtonSedam.Checked = false;
            radioButtonSuv.Checked = false;
        }

        private void AdicionarCarroSalvandoArquivo(string modelo, string placa, string marca, string preco, string classe)
        {
            var carro = new Carro
            {
                //Codigo = CarroServico.ObterUltimoCodigo() + 1,
                Modelo = modelo,
                Placa = placa,
                Marca = marca,
                Preco = preco,
                Categoria = classe,
            };

            carroServico.Cadastrar(carro);

            LimparCampos();

            ListarCarros();
        }
        private void ValidarCategorias()
        {
            if (radioButtonSuv.Checked == true)
                classe = "SUV";

            else if (radioButtonSedam.Checked == true)
                classe = "Sedam";

            else if (radioButtonHatch.Checked == true)
                classe = "Hatch";
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var quantidadeLinhasSelecionadas = dataGridViewVeiculos.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            var opcaoDesejada = MessageBox.Show(
                "Deseja realmente apagar esse paciente?", "Aviso", MessageBoxButtons.YesNo);

            if (opcaoDesejada == DialogResult.Yes)
            {

                var linhaSelecionada = dataGridViewVeiculos.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                carroServico.Apagar(codigoSelecionado);

                ListarCarros();
            }
        }
    }
}