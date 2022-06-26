namespace TrabalhoWindowsForm
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
            this.panelAreaPrincipal = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.BlueViolet;
            this.panelCabecalho.Controls.Add(this.button1);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1100, 40);
            this.panelCabecalho.TabIndex = 0;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(242, 540);
            this.panelMenu.TabIndex = 1;
            // 
            // panelAreaPrincipal
            // 
            this.panelAreaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAreaPrincipal.Location = new System.Drawing.Point(242, 40);
            this.panelAreaPrincipal.Name = "panelAreaPrincipal";
            this.panelAreaPrincipal.Size = new System.Drawing.Size(858, 540);
            this.panelAreaPrincipal.TabIndex = 2;
            // 
            // MenuListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.panelAreaPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuListar";
            this.panelCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCabecalho;
        private Button button1;
        private Panel panelMenu;
        private Panel panelAreaPrincipal;
    }
}