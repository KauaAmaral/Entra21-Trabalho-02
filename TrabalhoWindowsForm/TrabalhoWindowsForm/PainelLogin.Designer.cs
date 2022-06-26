namespace TrabalhoWindowsForm
{
    partial class PainelLogin
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
            this.buttonFecharLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogar = new System.Windows.Forms.Button();
            this.pictureBoxImageSuport = new System.Windows.Forms.PictureBox();
            this.linkLabelSuporte = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSuport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFecharLogin
            // 
            this.buttonFecharLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonFecharLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFecharLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonFecharLogin.FlatAppearance.BorderSize = 0;
            this.buttonFecharLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonFecharLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonFecharLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFecharLogin.Location = new System.Drawing.Point(361, 3);
            this.buttonFecharLogin.Name = "buttonFecharLogin";
            this.buttonFecharLogin.Size = new System.Drawing.Size(29, 27);
            this.buttonFecharLogin.TabIndex = 0;
            this.buttonFecharLogin.Text = "X";
            this.buttonFecharLogin.UseVisualStyleBackColor = false;
            this.buttonFecharLogin.Click += new System.EventHandler(this.buttonFecharLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Controls.Add(this.buttonFecharLogin);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 31);
            this.panel1.TabIndex = 1;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Location = new System.Drawing.Point(86, 186);
            this.textBoxUser.Multiline = true;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(235, 30);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(86, 257);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(235, 30);
            this.textBoxPassword.TabIndex = 5;
            // 
            // buttonLogar
            // 
            this.buttonLogar.BackColor = System.Drawing.Color.White;
            this.buttonLogar.FlatAppearance.BorderSize = 0;
            this.buttonLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogar.Location = new System.Drawing.Point(123, 328);
            this.buttonLogar.Name = "buttonLogar";
            this.buttonLogar.Size = new System.Drawing.Size(133, 41);
            this.buttonLogar.TabIndex = 6;
            this.buttonLogar.Text = "ENTRAR";
            this.buttonLogar.UseVisualStyleBackColor = false;
            this.buttonLogar.Click += new System.EventHandler(this.buttonLogar_Click);
            // 
            // pictureBoxImageSuport
            // 
            this.pictureBoxImageSuport.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxImageSuport.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxImageSuport.Image = global::TrabalhoWindowsForm.Properties.Resources.atendimento_ao_cliente;
            this.pictureBoxImageSuport.Location = new System.Drawing.Point(4, 465);
            this.pictureBoxImageSuport.Name = "pictureBoxImageSuport";
            this.pictureBoxImageSuport.Size = new System.Drawing.Size(29, 26);
            this.pictureBoxImageSuport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageSuport.TabIndex = 7;
            this.pictureBoxImageSuport.TabStop = false;
            // 
            // linkLabelSuporte
            // 
            this.linkLabelSuporte.AutoSize = true;
            this.linkLabelSuporte.Location = new System.Drawing.Point(34, 470);
            this.linkLabelSuporte.Name = "linkLabelSuporte";
            this.linkLabelSuporte.Size = new System.Drawing.Size(115, 20);
            this.linkLabelSuporte.TabIndex = 8;
            this.linkLabelSuporte.TabStop = true;
            this.linkLabelSuporte.Text = "Suporte Tecnico";
            this.linkLabelSuporte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSuporte_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::TrabalhoWindowsForm.Properties.Resources.midia_social;
            this.pictureBox1.Location = new System.Drawing.Point(138, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(88, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::TrabalhoWindowsForm.Properties.Resources.usuario_masculino;
            this.pictureBox2.Location = new System.Drawing.Point(42, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Location = new System.Drawing.Point(88, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::TrabalhoWindowsForm.Properties.Resources.do_utilizador;
            this.pictureBox3.Location = new System.Drawing.Point(43, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // PainelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 495);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelSuporte);
            this.Controls.Add(this.pictureBoxImageSuport);
            this.Controls.Add(this.buttonLogar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PainelLogin";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainelLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSuport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonFecharLogin;
        private Panel panel1;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Button buttonLogar;
        private PictureBox pictureBoxImageSuport;
        private LinkLabel linkLabelSuporte;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
    }
}