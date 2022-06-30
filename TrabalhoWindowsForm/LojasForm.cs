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

        private void CadastrarLoja(string cliente, string cnpj, string razaoSocial, string nomeFantasia, bool ativa, bool vendas, bool alugueis, bool consertos)
        {
            var loja = new Loja();
            loja.Codigo = lojaServico.ObterUltimoCodigo() + 1;
            loja.Cliente.Nome = cliente;
            loja.Cnpj = cnpj;
            loja.RazaoSocial = razaoSocial;
            loja.NomeFantasia = nomeFantasia;
            loja.Ativa = ativa;
            loja.Vendas = vendas;
            loja.Alugueis = alugueis;
            loja.Consertos = consertos;

            lojaServico.Cadastrar(loja);
        }

        private void EditarLoja(string cliente, string cnpj, string razaoSocial, string nomeFantasia, bool ativa, bool vendas, bool alugueis, bool consertos)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var loja = new Loja();
            loja.Codigo = codigoSelecionado;
            loja.Cliente = clienteServico.ObterPorNomeCliente(cliente);
            loja.Cnpj = cnpj;
            loja.RazaoSocial = razaoSocial;
            loja.NomeFantasia = nomeFantasia;
            loja.Ativa = ativa;
            loja.Vendas = vendas;
            loja.Alugueis = alugueis;
            loja.Consertos = consertos;

            lojaServico.Editar(loja);
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
                    loja.Cliente.Nome,
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
            var cliente = Convert.ToString(comboBoxCliente.SelectedItem);
            var cnpj = maskedTextBoxCnpj.Text;
            var razaoSocial = textBoxRazaoSocial.Text.Trim();
            var nomeFantasia = textBoxNomeFantasia.Text.Trim();
            var ativa = radioButtonSim.Checked;
            var vendas = checkBoxVendas.Checked;
            var alugueis = checkBoxAlugueis.Checked;
            var consertos = checkBoxConsertos.Checked;

            var dadosValidos = ValidarDados(cnpj, razaoSocial, nomeFantasia);

            if (dadosValidos = false)
            {
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarLoja(cliente, cnpj, razaoSocial, nomeFantasia, ativa, vendas, alugueis, consertos);
            else
                EditarLoja(cliente, cnpj, razaoSocial, nomeFantasia, ativa, vendas, alugueis, consertos);

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

        private bool ValidarDados(string cnpj, string razaoSocial, string nomeFantasia)
        {
            if (cnpj.Replace("-", "").Trim().Length != 14)
            {
                MessageBox.Show("CNPJ inválido");

                maskedTextBoxCnpj.Focus();

                return false;
            }

            if (razaoSocial.Trim().Length < 10)
            {
                MessageBox.Show("Razão Social deeve conter no mínimo 10 caracteres");

                textBoxRazaoSocial.Focus();

                return false;
            }

            if (nomeFantasia.Trim().Length < 5)
            {
                MessageBox.Show("Nome Fantasia deve conter no mínimo 5 caracteres");

                textBoxNomeFantasia.Focus();

                return false;
            }

            if (checkBoxVendas.Checked == false && checkBoxAlugueis.Checked == false && checkBoxAlugueis.Checked == false)
            {
                MessageBox.Show("Selecione um searviço");

                return false;
            }
            return true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PreencherComboBoxComCliente();
        }

        //public bool ValidarAtiva()
        //{
        //    if (radioButtonSim.Checked == true)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }
}
