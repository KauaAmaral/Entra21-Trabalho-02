﻿namespace TrabalhoWindowsForm
{
    partial class MenuListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCadastrarVeiculos = new System.Windows.Forms.Button();
            this.buttonHistorico = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCadastroClientes = new System.Windows.Forms.Button();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.BlueViolet;
            this.panelCabecalho.Controls.Add(this.buttonSair);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1126, 40);
            this.panelCabecalho.TabIndex = 0;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Transparent;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSair.Location = new System.Drawing.Point(1082, 1);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(40, 37);
            this.buttonSair.TabIndex = 0;
            this.buttonSair.Text = "X";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu.Controls.Add(this.buttonCadastrarVeiculos);
            this.panelMenu.Controls.Add(this.buttonHistorico);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.buttonCadastroClientes);
            this.panelMenu.Controls.Add(this.buttonComprar);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(187, 667);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonCadastrarVeiculos
            // 
            this.buttonCadastrarVeiculos.AutoSize = true;
            this.buttonCadastrarVeiculos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrarVeiculos.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.buttonCadastrarVeiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrarVeiculos.Location = new System.Drawing.Point(0, 221);
            this.buttonCadastrarVeiculos.Name = "buttonCadastrarVeiculos";
            this.buttonCadastrarVeiculos.Size = new System.Drawing.Size(226, 52);
            this.buttonCadastrarVeiculos.TabIndex = 5;
            this.buttonCadastrarVeiculos.Text = "Cadastrar Veiculos";
            this.buttonCadastrarVeiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrarVeiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastrarVeiculos.UseVisualStyleBackColor = true;
            this.buttonCadastrarVeiculos.Click += new System.EventHandler(this.buttonCadastrarVeiculos_Click);
            // 
            // buttonHistorico
            // 
            this.buttonHistorico.AutoSize = true;
            this.buttonHistorico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHistorico.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.buttonHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistorico.Location = new System.Drawing.Point(0, 369);
            this.buttonHistorico.Name = "buttonHistorico";
            this.buttonHistorico.Size = new System.Drawing.Size(223, 52);
            this.buttonHistorico.TabIndex = 4;
            this.buttonHistorico.Text = "Historico";
            this.buttonHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHistorico.UseVisualStyleBackColor = true;
            this.buttonHistorico.Click += new System.EventHandler(this.buttonHistorico_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Vender";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCadastroClientes
            // 
            this.buttonCadastroClientes.AutoSize = true;
            this.buttonCadastroClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastroClientes.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.buttonCadastroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastroClientes.Location = new System.Drawing.Point(0, 172);
            this.buttonCadastroClientes.Name = "buttonCadastroClientes";
            this.buttonCadastroClientes.Size = new System.Drawing.Size(210, 52);
            this.buttonCadastroClientes.TabIndex = 2;
            this.buttonCadastroClientes.Text = "Cadastro Cliente";
            this.buttonCadastroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastroClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastroClientes.UseVisualStyleBackColor = true;
            this.buttonCadastroClientes.Click += new System.EventHandler(this.buttonCadastroClientes_Click);
            // 
            // buttonComprar
            // 
            this.buttonComprar.AutoSize = true;
            this.buttonComprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonComprar.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.buttonComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComprar.Location = new System.Drawing.Point(0, 271);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(191, 52);
            this.buttonComprar.TabIndex = 0;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::TrabalhoWindowsForm.Properties.Resources.emp;
            this.pictureBox1.Location = new System.Drawing.Point(-33, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(187, 40);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(939, 667);
            this.panelForm.TabIndex = 3;
            // 
            // MenuListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1126, 707);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MenuListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuListar";
            this.panelCabecalho.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCabecalho;
        private Button buttonSair;
        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Button buttonComprar;
        private Button buttonHistorico;
        private Button button3;
        private Button buttonCadastroClientes;
        private Button buttonCadastrarVeiculos;
        private Panel panelForm;
    }
}