namespace TrabalhoWindowsForm
{
    public partial class MenuListar : Form
    {
        private Form frmAtivo;

        public MenuListar()
        {
            InitializeComponent();
        }
        private void FormShow(Form frm)
        {
            VerificarTelaAberta();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void VerificarTelaAberta()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        // Área de Seleção dos botões
        private void buttonCadastroClientes_Click(object sender, EventArgs e)
        {
            FormShow(new ClientesForm());
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            FormShow(new ComprarVeiculosForm());
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCadastrarVeiculos_Click(object sender, EventArgs e)
        {
            FormShow(new CadastroCarrosForm());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            FormShow(new LojasForm());
        }
    }
}
