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
    public partial class ComprarVeiculosForm : Form
    {
        private ClienteServico clienteServico;
        private SetorPagamentoForm setorPagamento;
        public ComprarVeiculosForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();

            setorPagamento = new SetorPagamentoForm();

            // Preencher a Lista dos colaboradores
            PreencherComboBoxComOsNomesDosPacientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherComboBoxComOsNomesDosPacientes()
        {
            // Obter lista dos pacientes, que foram cadastrados, ou senha, armazenados no JSON
            var cliente = clienteServico.ObterTodos();

            //Percorrer todos os pacientes adicionando no ComboBox
            for (int i = 0; i < cliente.Count; i++)
            {
                var clientes = cliente[i];
                comboBoxClientesCompra.Items.Add(clientes.Nome);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setorPagamento.SetorPagamento();
        }
    }
}
