namespace TrabalhoWindowsForm
{
    partial class ListarVendas
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
            this.dataGridViewListarClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListarClientes
            // 
            this.dataGridViewListarClientes.AllowUserToAddRows = false;
            this.dataGridViewListarClientes.AllowUserToDeleteRows = false;
            this.dataGridViewListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarClientes.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewListarClientes.Name = "dataGridViewListarClientes";
            this.dataGridViewListarClientes.ReadOnly = true;
            this.dataGridViewListarClientes.RowHeadersWidth = 51;
            this.dataGridViewListarClientes.RowTemplate.Height = 29;
            this.dataGridViewListarClientes.Size = new System.Drawing.Size(915, 535);
            this.dataGridViewListarClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDAS REALIZADAS";
            // 
            // ListarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewListarClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarVendas";
            this.Text = "ListarClientesCadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewListarClientes;
        private Label label1;
    }
}