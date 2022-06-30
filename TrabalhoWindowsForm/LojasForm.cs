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

            PreencherDataGridViewComCliente();
        }

        private void PreencherDataGridViewComCliente()
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



    }
}
