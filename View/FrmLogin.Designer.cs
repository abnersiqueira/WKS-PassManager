namespace PassManager
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.PnlMover2 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txPassManager = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.LinLogin = new System.Windows.Forms.Panel();
            this.LinPass = new System.Windows.Forms.Panel();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.PnlMover = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbLogin1 = new System.Windows.Forms.TextBox();
            this.PnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlLeft.Controls.Add(this.PnlMover2);
            this.PnlLeft.Controls.Add(this.picLogo);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(200, 336);
            this.PnlLeft.TabIndex = 1;
            // 
            // PnlMover2
            // 
            this.PnlMover2.BackColor = System.Drawing.Color.Transparent;
            this.PnlMover2.ForeColor = System.Drawing.Color.Transparent;
            this.PnlMover2.Location = new System.Drawing.Point(1, 1);
            this.PnlMover2.Name = "PnlMover2";
            this.PnlMover2.Size = new System.Drawing.Size(196, 32);
            this.PnlMover2.TabIndex = 11;
            this.PnlMover2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlMover2_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 109);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(172, 105);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txPassManager
            // 
            this.txPassManager.AutoSize = true;
            this.txPassManager.BackColor = System.Drawing.Color.Transparent;
            this.txPassManager.Font = new System.Drawing.Font("Bahnschrift SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPassManager.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txPassManager.Location = new System.Drawing.Point(269, 64);
            this.txPassManager.Name = "txPassManager";
            this.txPassManager.Size = new System.Drawing.Size(246, 45);
            this.txPassManager.TabIndex = 2;
            this.txPassManager.Text = "PassManager";
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(117)))), ((int)(((byte)(227)))));
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPass.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txbPass.Location = new System.Drawing.Point(294, 170);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(195, 26);
            this.txbPass.TabIndex = 2;
            this.txbPass.Text = "Senha";

            this.txbPass.MouseEnter += new System.EventHandler(this.txbPass_MouseEnter);
            this.txbPass.MouseLeave += new System.EventHandler(this.txbPass_MouseLeave);
            // 
            // LinLogin
            // 
            this.LinLogin.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LinLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LinLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinLogin.Enabled = false;
            this.LinLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LinLogin.Location = new System.Drawing.Point(294, 158);
            this.LinLogin.Name = "LinLogin";
            this.LinLogin.Size = new System.Drawing.Size(195, 2);
            this.LinLogin.TabIndex = 5;
            // 
            // LinPass
            // 
            this.LinPass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LinPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LinPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinPass.Enabled = false;
            this.LinPass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LinPass.Location = new System.Drawing.Point(294, 194);
            this.LinPass.Name = "LinPass";
            this.LinPass.Size = new System.Drawing.Size(195, 2);
            this.LinPass.TabIndex = 6;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(354, 213);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtnEntrar.TabIndex = 0;
            this.BtnEntrar.Text = "Login";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // PnlMover
            // 
            this.PnlMover.BackColor = System.Drawing.Color.Transparent;
            this.PnlMover.ForeColor = System.Drawing.Color.Transparent;
            this.PnlMover.Location = new System.Drawing.Point(204, 0);
            this.PnlMover.Name = "PnlMover";
            this.PnlMover.Size = new System.Drawing.Size(328, 32);
            this.PnlMover.TabIndex = 10;
            this.PnlMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlMover_MouseDown);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(550, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(22, 23);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 8;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txbLogin1
            // 
            this.txbLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(117)))), ((int)(((byte)(227)))));
            this.txbLogin1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogin1.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txbLogin1.Location = new System.Drawing.Point(294, 132);
            this.txbLogin1.Name = "txbLogin1";
            this.txbLogin1.Size = new System.Drawing.Size(195, 26);
            this.txbLogin1.TabIndex = 1;
            this.txbLogin1.Text = "Login";
            this.txbLogin1.TextChanged += new System.EventHandler(this.txbLogin1_TextChanged);
            this.txbLogin1.MouseEnter += new System.EventHandler(this.txbLogin1_MouseEnter);
            this.txbLogin1.MouseLeave += new System.EventHandler(this.txbLogin1_MouseLeave);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.txbLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlMover);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.LinPass);
            this.Controls.Add(this.LinLogin);
            this.Controls.Add(this.txPassManager);
            this.Controls.Add(this.PnlLeft);
            this.Controls.Add(this.txbPass);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WKS";
            this.PnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label txPassManager;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Panel LinLogin;
        private System.Windows.Forms.Panel LinPass;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Panel PnlMover2;
        private System.Windows.Forms.Panel PnlMover;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbLogin1;
    }
}

