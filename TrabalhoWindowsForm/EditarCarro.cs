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
    public partial class RepararInformacaoCarro : Form
    {
        private Label labelModelo;
        private TextBox textBoxModelo;
        private Label labelPlaca;
        private TextBox textBoxPlaca;
        private Label labelMarca;
        private ComboBox comboBoxMarca;
        private Label labelCategoria;
        private Label labelPreco;
        private TextBox textBoxPreco;
        private Button buttonAlterar;

        private List<Carro> carros;
        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        private Button buttonLimparCampos;
        private CarroServico carroServico;
        private RadioButton radioButtonSuv;
        private RadioButton radioButtonSedam;
        private RadioButton radioButtonHatch;
        private CadastroCarrosForm cadastroCarroForm;
        
        public RepararInformacaoCarro()
        {
            InitializeComponent();
            carroServico = new CarroServico();
        }

        private void InitializeComponent()
        {
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.radioButtonSuv = new System.Windows.Forms.RadioButton();
            this.radioButtonSedam = new System.Windows.Forms.RadioButton();
            this.radioButtonHatch = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(12, 367);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(234, 36);
            this.buttonAlterar.TabIndex = 1;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(11, 16);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(61, 20);
            this.labelModelo.TabIndex = 2;
            this.labelModelo.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(11, 34);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(202, 27);
            this.textBoxModelo.TabIndex = 3;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(11, 69);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(44, 20);
            this.labelPlaca.TabIndex = 4;
            this.labelPlaca.Text = "Placa";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(11, 87);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(202, 27);
            this.textBoxPlaca.TabIndex = 5;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(11, 124);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(50, 20);
            this.labelMarca.TabIndex = 6;
            this.labelMarca.Text = "Marca";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(11, 142);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(202, 28);
            this.comboBoxMarca.TabIndex = 7;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(11, 182);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(74, 20);
            this.labelCategoria.TabIndex = 8;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(11, 311);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(46, 20);
            this.labelPreco.TabIndex = 10;
            this.labelPreco.Text = "Preço";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(11, 334);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(202, 27);
            this.textBoxPreco.TabIndex = 11;
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Location = new System.Drawing.Point(252, 367);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(186, 36);
            this.buttonLimparCampos.TabIndex = 12;
            this.buttonLimparCampos.Text = "Limpar os Campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            // 
            // radioButtonSuv
            // 
            this.radioButtonSuv.AutoSize = true;
            this.radioButtonSuv.Location = new System.Drawing.Point(14, 216);
            this.radioButtonSuv.Name = "radioButtonSuv";
            this.radioButtonSuv.Size = new System.Drawing.Size(53, 24);
            this.radioButtonSuv.TabIndex = 13;
            this.radioButtonSuv.TabStop = true;
            this.radioButtonSuv.Text = "Suv";
            this.radioButtonSuv.UseVisualStyleBackColor = true;
            // 
            // radioButtonSedam
            // 
            this.radioButtonSedam.AutoSize = true;
            this.radioButtonSedam.Location = new System.Drawing.Point(12, 251);
            this.radioButtonSedam.Name = "radioButtonSedam";
            this.radioButtonSedam.Size = new System.Drawing.Size(76, 24);
            this.radioButtonSedam.TabIndex = 14;
            this.radioButtonSedam.TabStop = true;
            this.radioButtonSedam.Text = "Sedam";
            this.radioButtonSedam.UseVisualStyleBackColor = true;
            // 
            // radioButtonHatch
            // 
            this.radioButtonHatch.AutoSize = true;
            this.radioButtonHatch.Location = new System.Drawing.Point(13, 281);
            this.radioButtonHatch.Name = "radioButtonHatch";
            this.radioButtonHatch.Size = new System.Drawing.Size(69, 24);
            this.radioButtonHatch.TabIndex = 15;
            this.radioButtonHatch.TabStop = true;
            this.radioButtonHatch.Text = "Hatch";
            this.radioButtonHatch.UseVisualStyleBackColor = true;
            // 
            // RepararInformacaoCarro
            // 
            this.ClientSize = new System.Drawing.Size(450, 415);
            this.Controls.Add(this.radioButtonHatch);
            this.Controls.Add(this.radioButtonSedam);
            this.Controls.Add(this.radioButtonSuv);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.buttonAlterar);
            this.Name = "RepararInformacaoCarro";
            this.Text = "Reparar Informação do Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            textBoxModelo.Text = "";
            textBoxPlaca.Text = "";
            comboBoxMarca.Text = "";
            radioButtonSuv.Checked = false;
            radioButtonSedam.Checked = false;
            radioButtonHatch.Checked = false;
            textBoxPreco.Text = "";
        }
        private void EditarDados(string modelo, string placa, string marca, string categoria, double preco)
        {
            carros[indiceLinhaSelecionada].Modelo = modelo;
            carros[indiceLinhaSelecionada].Placa = placa;
            carros[indiceLinhaSelecionada].Marca = marca;
            carros[indiceLinhaSelecionada].Categoria = categoria;
            carros[indiceLinhaSelecionada].Preco = preco;

            carroServico.SalvarArquivo();

            cadastroCarroForm.LimparCampos();
        }
    }
}