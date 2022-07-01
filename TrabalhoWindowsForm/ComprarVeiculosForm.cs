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
    public partial class ComprarVeiculosForm : Form
    {
        DataTable dt = new DataTable();
        private CarroServico carroServico;
        private ClienteServico clienteServico;
        private SetorPagamentoForm setorPagamento;
        public ComprarVeiculosForm()
        {
            InitializeComponent();

            carroServico = new CarroServico();

            clienteServico = new ClienteServico();

            setorPagamento = new SetorPagamentoForm();

            PreencherComboBoxComOsNomesDosPacientes();

            ListarCarros();
        }

        private void ListarCarros()
        {
            var carros = carroServico.ObterTodos();

            dataGridViewAbaComprar.Rows.Clear();

            for (int i = 0; i < carros.Count; i++)
            {
                var carro = carros[i];

                dataGridViewAbaComprar.Rows.Add(new object[]
                {
                    carro.Codigo,
                    carro.Modelo,
                    carro.Placa,
                    carro.Marca,
                    carro.Categoria,
                    carro.Preco,
                });
            }
            dataGridViewAbaComprar.ClearSelection();
        }
        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "");

            if (cep.Length != 8)
            {
                return;
            }

            // HttpCliente permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisição para o Site ViaCep para obter dados de enderço de cep
            var resultado = httpClient.GetAsync(
                $"https://viacep.com.br/ws/{cep}/json/").Result;

            // Verificar se a requisição deu certo
            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Obter a resposta da requisição
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoLocalidade>(resposta);

                textBoxEnderecoCompleto.Text = $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
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

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private void ObterSelecaoCategoria()
        {
            if (checkBoxHatch.Checked != false)
            {
                var categoria = "Hatch";
            }

            if (checkBoxSedan.Checked != false)
            {
                var categoria = "Sedan";
            }

            if (checkBoxSuv.Checked != false)
            {
                var categoria = "SUV";
            }
        }

        private void buttonAvancar_Click(object sender, EventArgs e)
        {
            var apresentarPagamento = new SetorPagamentoForm();
            apresentarPagamento.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxClientesCompra.SelectedIndex = -1;
            maskedTextBoxCep.Text = "";
            maskedTextBoxCpf.Text = "";
            textBoxContato.Text = "";
            textBoxEnderecoCompleto.Text = "";
            checkBoxHatch.Checked = false;
            checkBoxSedan.Checked = false;
            checkBoxSuv.Checked = false;

        }
    }
}
