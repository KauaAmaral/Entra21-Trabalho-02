namespace TrabalhoWindowsForm
{
    partial class ComprarVeiculoForm
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
            this.panelAreaPrincipal = new System.Windows.Forms.Panel();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelComprar = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelCategoriaCompra = new System.Windows.Forms.Label();
            this.radioButtonHatch = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panelAreaPrincipal.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAreaPrincipal
            // 
            this.panelAreaPrincipal.Controls.Add(this.button2);
            this.panelAreaPrincipal.Controls.Add(this.dataGridView1);
            this.panelAreaPrincipal.Controls.Add(this.radioButton4);
            this.panelAreaPrincipal.Controls.Add(this.radioButton3);
            this.panelAreaPrincipal.Controls.Add(this.radioButton2);
            this.panelAreaPrincipal.Controls.Add(this.radioButton1);
            this.panelAreaPrincipal.Controls.Add(this.radioButtonHatch);
            this.panelAreaPrincipal.Controls.Add(this.labelCategoriaCompra);
            this.panelAreaPrincipal.Controls.Add(this.comboBox2);
            this.panelAreaPrincipal.Controls.Add(this.comboBox1);
            this.panelAreaPrincipal.Controls.Add(this.buttonLimpar);
            this.panelAreaPrincipal.Controls.Add(this.labelComprar);
            this.panelAreaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAreaPrincipal.Location = new System.Drawing.Point(242, 40);
            this.panelAreaPrincipal.Name = "panelAreaPrincipal";
            this.panelAreaPrincipal.Size = new System.Drawing.Size(836, 575);
            this.panelAreaPrincipal.TabIndex = 5;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.BlueViolet;
            this.panelCabecalho.Controls.Add(this.button1);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(242, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(836, 40);
            this.panelCabecalho.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1057, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(242, 615);
            this.panelMenu.TabIndex = 4;
            // 
            // labelComprar
            // 
            this.labelComprar.AutoSize = true;
            this.labelComprar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComprar.Location = new System.Drawing.Point(319, 3);
            this.labelComprar.Name = "labelComprar";
            this.labelComprar.Size = new System.Drawing.Size(209, 54);
            this.labelComprar.TabIndex = 0;
            this.labelComprar.Text = "COMPRAR";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(19, 530);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(192, 33);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(475, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(338, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(475, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(338, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // labelCategoriaCompra
            // 
            this.labelCategoriaCompra.AutoSize = true;
            this.labelCategoriaCompra.Location = new System.Drawing.Point(475, 227);
            this.labelCategoriaCompra.Name = "labelCategoriaCompra";
            this.labelCategoriaCompra.Size = new System.Drawing.Size(74, 20);
            this.labelCategoriaCompra.TabIndex = 5;
            this.labelCategoriaCompra.Text = "Categoria";
            // 
            // radioButtonHatch
            // 
            this.radioButtonHatch.AutoSize = true;
            this.radioButtonHatch.Location = new System.Drawing.Point(475, 263);
            this.radioButtonHatch.Name = "radioButtonHatch";
            this.radioButtonHatch.Size = new System.Drawing.Size(69, 24);
            this.radioButtonHatch.TabIndex = 6;
            this.radioButtonHatch.TabStop = true;
            this.radioButtonHatch.Text = "Hatch";
            this.radioButtonHatch.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(475, 293);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hatch";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(475, 323);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hatch";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(559, 263);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 24);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hatch";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(559, 293);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 24);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Hatch";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(419, 388);
            this.dataGridView1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Avançar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ComprarVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 615);
            this.Controls.Add(this.panelAreaPrincipal);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprarVeiculoForm";
            this.Text = "ComprarVeiculoForm";
            this.panelAreaPrincipal.ResumeLayout(false);
            this.panelAreaPrincipal.PerformLayout();
            this.panelCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAreaPrincipal;
        private Panel panelCabecalho;
        private Button button1;
        private Panel panelMenu;
        private DataGridView dataGridView1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButtonHatch;
        private Label labelCategoriaCompra;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button buttonLimpar;
        private Label labelComprar;
        private Button button2;
    }
}