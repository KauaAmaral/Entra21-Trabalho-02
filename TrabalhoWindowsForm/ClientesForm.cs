namespace TrabalhoWindowsForm
{
    public partial class ClientesForm : Form
    {
        private ClienteServico clienteServico;

        public ClientesForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();

            ListarClientes();
        }
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var eMail = textBoxEMail.Text.Trim();
            var dataNascimento = dateTimePickerDataNascimento.Value;
            

            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarCliente(nome, eMail, dataNascimento);

                return;
            }
            EditarDados(nome, eMail, dataNascimento);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var eMail = linhaSelecionada.Cells[2].Value.ToString();
            var dataNascimento = linhaSelecionada.Cells[3].Value.ToString();

            textBoxNome.Text = nome;
            textBoxEMail.Text = eMail;
            dateTimePickerDataNascimento.Text = dataNascimento;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var quantidadeLinhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um cliente");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                var linhaSelecionada = dataGridView1.SelectedRows[0];

                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                clienteServico.Apagar(codigoSelecionado);

                ListarClientes();
            }
        }

        private void AdicionarCliente(string nome, string eMail, DateTime dataNascimento)
        {
            var cliente = new Cliente
            {
                Codigo = clienteServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                EMail = eMail,
                DataNascimento = dataNascimento
            };

            clienteServico.Cadastrar(cliente);

            LimparCampos();

            ListarClientes();
        }

        private void EditarDados(string nome, string eMail, DateTime dataNascimento)
        {
            var cliente = new Cliente();
            cliente.Nome = nome;
            cliente.EMail = eMail;
            cliente.DataNascimento = dataNascimento;

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            cliente.Codigo = codigo;

            clienteServico.Editar(cliente);

            LimparCampos();

            ListarClientes();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxEMail.Clear();
            dateTimePickerDataNascimento.ResetText();

            dataGridView1.ClearSelection();
        }

        private void ListarClientes()
        {
            var clientes = clienteServico.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    cliente.Codigo,
                    cliente.Nome,
                    cliente.EMail,
                    cliente.DataNascimento
                });
            }
            dataGridView1.ClearSelection();
        }

    }
}
