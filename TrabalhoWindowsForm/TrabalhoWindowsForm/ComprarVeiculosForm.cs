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
        public ComprarVeiculosForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
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
                var paciente = cliente[i];
                comboBoxClientesCompra.Items.Add(cliente.Nome);
            }
        }
    }
}
