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
    public partial class SetorPagamentoForm : Form
    {
        public SetorPagamentoForm()
        {
            InitializeComponent();
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            maskedTextBoxNumeroCartao.Enabled = false;
            textBoxNomeCartao.Text = "";
            maskedTextBoxCpfCartao.Enabled = false;
            dateTimePickerVencParcela.Enabled = false;
            maskedTextBoxCodSeguranca.Enabled = false;
            comboBoxParcelas.Text = "";
        }

        private void buttonFinalizarCompra_Click_1(object sender, EventArgs e)
        {
            var dadosCartao = maskedTextBoxNumeroCartao.Text;
            var cpfCliente = maskedTextBoxCpfCartao.Text; 

            var dadosCliente = ValidarDados(dadosCartao, cpfCliente);

            if (dadosCliente == false)
            {
                return;
            }

            MessageBox.Show("COMPRA EFETUADA COM SUCESSO");
        }

        private void buttonCancelarOp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ObterDados()
        {
            var dadosCartao = maskedTextBoxNumeroCartao.Text.Replace(".", "");

            if (dadosCartao.Length != 16)
            {
                return;
            }
        }

        private bool ValidarDados(string dadosCartao, string cpfCliente)
        {
            if (dadosCartao.Replace(" ", "").Trim().Length != 16)
            {
                MessageBox.Show("Número do Cartão Inválido");

                maskedTextBoxNumeroCartao.Focus();

                return false;
            }

            if (cpfCliente.Replace(".", "").Trim().Length != 14)
            {
                MessageBox.Show("Número do CPF Inválido");

                maskedTextBoxNumeroCartao.Focus();

                return false;
            }

            return true;
        }

        private void SetorPagamentoForm_Load(object sender, EventArgs e)
        {
            dateTimePickerVencParcela.CustomFormat = "MM/yy";
            dateTimePickerVencParcela.Format = DateTimePickerFormat.Custom;
        }

        private string DataVencimentoParcela()
        {
            var parcela = "";

            if (radioButtonDataUm.Checked == true)
            {
                parcela = "08";
            }
            else if (radioButtonDataDois.Checked == true)
            {
                parcela = "17";
            }
            else if(radioButtonDataTres.Checked == true)
            {
                parcela = "26";
            }

            return parcela;
        }
    }
}
