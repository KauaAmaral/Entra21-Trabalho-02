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
    public partial class MenuListar : Form
    {
        public MenuListar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            var comprarVeiculo = new ComprarVeiculosForm();
            //comprarVeiculo.MdiParent = this;
            comprarVeiculo.Show();
            //comprarVeiculo.WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cadastroCarros = new CadastroCarrosForm();
            //cadastroCarros.MdiParent = this;
            cadastroCarros.Show();
            //cadastroCarros.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cliente = new ClientesForm();
            //cliente.MdiParent = this;
            cliente.Show();
            //cliente.WindowState = FormWindowState.Maximized;
        }
    }
}
