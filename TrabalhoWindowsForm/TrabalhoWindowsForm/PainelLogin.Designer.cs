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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxImageSuport = new System.Windows.Forms.PictureBox();
            this.linkLabelSuporte = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSuport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.Location = new System.Drawing.Point(154, 165);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(94, 30);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senha:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Location = new System.Drawing.Point(100, 199);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(201, 20);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Location = new System.Drawing.Point(100, 272);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(201, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(135, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "ENTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.pictureBox1.Image = global::TrabalhoWindowsForm.Properties.Resources.alugar_um_carro;
            this.pictureBox1.Location = new System.Drawing.Point(138, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PainelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(395, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelSuporte);
            this.Controls.Add(this.pictureBoxImageSuport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsuario);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonFecharLogin;
        private Panel panel1;
        private Label labelUsuario;
        private Label label1;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Button button1;
        private PictureBox pictureBoxImageSuport;
        private LinkLabel linkLabelSuporte;
        private PictureBox pictureBox1;
    }
}