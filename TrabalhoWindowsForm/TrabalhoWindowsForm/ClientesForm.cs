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


        }
    }
}
