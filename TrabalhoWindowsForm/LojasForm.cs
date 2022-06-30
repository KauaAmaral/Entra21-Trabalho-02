namespace TrabalhoWindowsForm
{
    public partial class LojasForm : Form
    {
        private LojaServico lojaServico;
        private ClienteServico clienteServico;

        public LojasForm()
        {
            InitializeComponent();

            lojaServico = new LojaServico();

            clienteServico = new ClienteServico();

            PreencherComboBoxComCliente();

            ListarLojas();
        }

        private void PreencherComboBoxComCliente()
        {
            var clientes = clienteServico.ObterTodos();

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];
                comboBoxCliente.Items.Add(cliente.Nome);
            }
        }

        private void LimparCampos()
        {
            maskedTextBoxCnpj.Text = "";
            textBoxRazaoSocial.Text = "";
            textBoxNomeFantasia.Text = "";
            radioButtonSim.Checked = true;
            radioButtonNao.Checked = false;
            checkBoxVendas.Checked = false;
            checkBoxAlugueis.Checked = false;
            checkBoxConsertos.Checked = false;

            dataGridView1.ClearSelection();
        }

        public void ListarLojas()
        {
            var lojas = lojaServico.ObterTodas();

            dataGridView1.Rows.Clear();

            for (var i = 0; i < lojas.Count; i++)
            {
                var loja = lojas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    loja.Codigo,
                    loja.Cnpj,
                    loja.NomeFantasia,
                    loja.Ativa
                });
            }
            dataGridView1.ClearSelection();
        }

        private void ApresentarDadosEditar()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma loja para editar");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var loja = lojaServico.ObterPorCodigo(codigo);

            maskedTextBoxCnpj.Text = loja.Cnpj;
            textBoxRazaoSocial.Text = loja.RazaoSocial;
            textBoxNomeFantasia.Text = loja.NomeFantasia;
            radioButtonSim.Checked = loja.Ativa;
            checkBoxVendas.Checked = loja.Vendas;
            checkBoxAlugueis.Checked = loja.Alugueis;
            checkBoxConsertos.Checked = loja.Consertos;
        }

        private void LojasForm_Load(object sender, EventArgs e)
        {
            ListarLojas();
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var cnpj = maskedTextBoxCnpj.Text;
            var razaoSocial = textBoxRazaoSocial.Text.Trim();
            var nomeFantasia = textBoxNomeFantasia.Text.Trim();
            var ativa = radioButtonSim.Checked;
            var Vendas = checkBoxVendas.Checked;
            var alugueis = checkBoxAlugueis.Checked;
            var consertos = checkBoxConsertos.Checked;

            ListarLojas();

            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosEditar();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Selecione uma loja para remover");

                return;
            }

            var confirmacao = MessageBox.Show("Deseja realmente apagar a loja?", "Aviso", MessageBoxButtons.YesNo);

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var loja = lojaServico.ObterPorCodigo(codigo);

            lojaServico.Apagar(loja);

            ListarLojas();

            dataGridView1.ClearSelection();
        }

        public bool ValidarAtiva()
        {
            if (radioButtonSim.Checked == true)
            {
                return true;
            }
            return false;
        }

    }
}
