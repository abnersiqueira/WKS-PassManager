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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlMover = new System.Windows.Forms.Panel();
            this.BtnMinimize = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.txbLogin1 = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LinPass = new System.Windows.Forms.Panel();
            this.LinLogin = new System.Windows.Forms.Panel();
            this.txPassManager = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PnLLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PnlMover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.PnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.PnlMover);
            this.panel1.Controls.Add(this.txbLogin1);
            this.panel1.Controls.Add(this.BtnEntrar);
            this.panel1.Controls.Add(this.LinPass);
            this.panel1.Controls.Add(this.LinLogin);
            this.panel1.Controls.Add(this.txPassManager);
            this.panel1.Controls.Add(this.txbPass);
            this.panel1.Controls.Add(this.PnlLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 336);
            this.panel1.TabIndex = 0;
            // 
            // PnlMover
            // 
            this.PnlMover.BackColor = System.Drawing.Color.Transparent;
            this.PnlMover.Controls.Add(this.BtnMinimize);
            this.PnlMover.Controls.Add(this.BtnClose);
            this.PnlMover.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMover.ForeColor = System.Drawing.Color.Transparent;
            this.PnlMover.Location = new System.Drawing.Point(200, 0);
            this.PnlMover.Name = "PnlMover";
            this.PnlMover.Size = new System.Drawing.Size(373, 32);
            this.PnlMover.TabIndex = 18;
            this.PnlMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlMover_MouseDown);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.Location = new System.Drawing.Point(329, 3);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(22, 23);
            this.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMinimize.TabIndex = 9;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(348, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(22, 23);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 8;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // txbLogin1
            // 
            this.txbLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(117)))), ((int)(((byte)(227)))));
            this.txbLogin1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogin1.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin1.ForeColor = System.Drawing.Color.Black;
            this.txbLogin1.Location = new System.Drawing.Point(279, 132);
            this.txbLogin1.Name = "txbLogin1";
            this.txbLogin1.Size = new System.Drawing.Size(195, 26);
            this.txbLogin1.TabIndex = 1;
            this.txbLogin1.Text = "Login";
            this.txbLogin1.TextChanged += new System.EventHandler(this.txbLogin1_TextChanged);
            this.txbLogin1.MouseEnter += new System.EventHandler(this.txbLogin1_MouseEnter_1);
            this.txbLogin1.MouseLeave += new System.EventHandler(this.txbLogin1_MouseLeave_1);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEntrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEntrar.Image")));
            this.BtnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEntrar.Location = new System.Drawing.Point(337, 211);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(73, 35);
            this.BtnEntrar.TabIndex = 3;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click_1);
            // 
            // LinPass
            // 
            this.LinPass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LinPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LinPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinPass.Enabled = false;
            this.LinPass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LinPass.Location = new System.Drawing.Point(279, 194);
            this.LinPass.Name = "LinPass";
            this.LinPass.Size = new System.Drawing.Size(195, 2);
            this.LinPass.TabIndex = 17;
            // 
            // LinLogin
            // 
            this.LinLogin.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LinLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LinLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinLogin.Enabled = false;
            this.LinLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LinLogin.Location = new System.Drawing.Point(279, 158);
            this.LinLogin.Name = "LinLogin";
            this.LinLogin.Size = new System.Drawing.Size(195, 2);
            this.LinLogin.TabIndex = 16;
            // 
            // txPassManager
            // 
            this.txPassManager.AutoSize = true;
            this.txPassManager.BackColor = System.Drawing.Color.Transparent;
            this.txPassManager.Font = new System.Drawing.Font("Bahnschrift SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPassManager.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txPassManager.Location = new System.Drawing.Point(259, 62);
            this.txPassManager.Name = "txPassManager";
            this.txPassManager.Size = new System.Drawing.Size(246, 45);
            this.txPassManager.TabIndex = 14;
            this.txPassManager.Text = "PassManager";
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(117)))), ((int)(((byte)(227)))));
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPass.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.ForeColor = System.Drawing.Color.Black;
            this.txbPass.Location = new System.Drawing.Point(279, 170);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(195, 26);
            this.txbPass.TabIndex = 2;
            this.txbPass.Text = "Senha";
            this.txbPass.UseSystemPasswordChar = true;
            this.txbPass.MouseEnter += new System.EventHandler(this.txbPass_MouseEnter_1);
            this.txbPass.MouseLeave += new System.EventHandler(this.txbPass_MouseLeave);
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.GhostWhite;
            this.PnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlLeft.Controls.Add(this.label4);
            this.PnlLeft.Controls.Add(this.PnLLogo);
            this.PnlLeft.Controls.Add(this.picLogo);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(200, 336);
            this.PnlLeft.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(16, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "suporte@wksti.com.br";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnLLogo
            // 
            this.PnLLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLLogo.Location = new System.Drawing.Point(0, 0);
            this.PnLLogo.Name = "PnLLogo";
            this.PnLLogo.Size = new System.Drawing.Size(200, 32);
            this.PnLLogo.TabIndex = 1;
            this.PnLLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnLLogo_MouseDown);
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
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WKS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlMover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.PnlLeft.ResumeLayout(false);
            this.PnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbLogin1;
        private System.Windows.Forms.Panel PnlMover;
        private System.Windows.Forms.PictureBox BtnMinimize;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Panel LinPass;
        private System.Windows.Forms.Panel LinLogin;
        private System.Windows.Forms.Label txPassManager;
        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Panel PnLLogo;
        private System.Windows.Forms.Label label4;
    }
}

