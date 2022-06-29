namespace TrabalhoWindowsForm
{
    public partial class ClientesForm : Form
    {
        private List<Cliente> clientes;

        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;

        public ClientesForm()
        {
            InitializeComponent();

            clientes = new List<Cliente>();

            ListarClientes();
        }

        private void ListarClientes()
        {
            var clientes = clienteServico;

            dataGridView1.Rows.Clear();

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    cliente.Codigo,
                    cliente.Name,
                    cliente.EMail,
                    cliente.DataNascimento
                });
            }
            dataGridView1.ClearSelection();
        }
    }
}
