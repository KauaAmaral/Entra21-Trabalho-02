﻿using System;
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
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "Admin" && textBoxPassword.Text != "Admin")
            {
                MessageBox.Show("Usuario ou Senha Invalido!");
                return;
            }

            if (textBoxPassword.Text != "Admin")
            {
                MessageBox.Show("Usuario ou Senha Invalido!");
                return;
            }
        }

        private void linkLabelSuporte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var uri = "https://www.linkedin.com/in/felipeecorrea/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
    }
}
