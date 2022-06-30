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

        private void textBoxEnderecoCompleto_TextChanged(object sender, EventArgs e)
        {
            //ObterDadosCep();
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }
    }
}
