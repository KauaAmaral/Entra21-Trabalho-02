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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMPRA EFETUADA COM SUCESSO");
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            maskedTextBoxNumeroCartao.Enabled = false;
            textBoxNomeCartao.Text = "";
            maskedTextBoxCpfCartao.Enabled = false;
            maskedTextBoxValidade.Enabled = false;
            maskedTextBoxCodSeguranca.Enabled = false;
            comboBoxParcelas.Text = "";
        }
    }
}
