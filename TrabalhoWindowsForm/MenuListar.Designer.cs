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
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCadastrarVeiculos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCadastroClientes = new System.Windows.Forms.Button();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.BlueViolet;
            this.panelCabecalho.Controls.Add(this.button1);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(965, 30);
            this.panelCabecalho.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(925, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu.Controls.Add(this.buttonCadastrarVeiculos);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.buttonCadastroClientes);
            this.panelMenu.Controls.Add(this.buttonComprar);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(212, 406);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonCadastrarVeiculos
            // 
            this.buttonCadastrarVeiculos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrarVeiculos.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.buttonCadastrarVeiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrarVeiculos.Location = new System.Drawing.Point(0, 166);
            this.buttonCadastrarVeiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCadastrarVeiculos.Name = "buttonCadastrarVeiculos";
            this.buttonCadastrarVeiculos.Size = new System.Drawing.Size(212, 39);
            this.buttonCadastrarVeiculos.TabIndex = 5;
            this.buttonCadastrarVeiculos.Text = "Cadastrar Veiculos";
            this.buttonCadastrarVeiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadastrarVeiculos.UseVisualStyleBackColor = true;
            this.buttonCadastrarVeiculos.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 277);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clientes";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 240);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Venda";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonCadastroClientes
            // 
            this.buttonCadastroClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastroClientes.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.buttonCadastroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastroClientes.Location = new System.Drawing.Point(0, 129);
            this.buttonCadastroClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCadastroClientes.Name = "buttonCadastroClientes";
            this.buttonCadastroClientes.Size = new System.Drawing.Size(212, 39);
            this.buttonCadastroClientes.TabIndex = 2;
            this.buttonCadastroClientes.Text = "Cadastro Cliente";
            this.buttonCadastroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadastroClientes.UseVisualStyleBackColor = true;
            this.buttonCadastroClientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonComprar
            // 
            this.buttonComprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonComprar.Image = global::TrabalhoWindowsForm.Properties.Resources.carros;
            this.buttonComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComprar.Location = new System.Drawing.Point(0, 203);
            this.buttonComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(212, 39);
            this.buttonComprar.TabIndex = 0;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::TrabalhoWindowsForm.Properties.Resources.new_car;
            this.pictureBox1.Location = new System.Drawing.Point(58, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(965, 436);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuListar";
            this.panelCabecalho.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCabecalho;
        private Button button1;
        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Button buttonComprar;
        private Button button4;
        private Button button3;
        private Button buttonCadastroClientes;
        private Button buttonCadastrarVeiculos;
    }
}