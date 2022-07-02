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
    public partial class PainelLogin : Form
    {
        public PainelLogin()
        {
            InitializeComponent();
        }

        private void buttonFecharLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUser.Text.Equals("Admin") && textBoxPassword.Text.Equals("Admin"))
                {
                    var menuListar = new MenuListar();
                    menuListar.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usúario ou Senha Invalido!",
                                    "Aviso!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    textBoxUser.Focus();
                    textBoxPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso!",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void linkLabelSuporte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var enderecoSuporte = "https://www.linkedin.com/in/felipeecorrea/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = enderecoSuporte;
            System.Diagnostics.Process.Start(psi);
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
            textBoxPassword.Focus();
        }
    }
}
