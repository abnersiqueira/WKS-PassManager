﻿namespace PassManager
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txPassManager = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.LinLogin = new System.Windows.Forms.Panel();
            this.LinPass = new System.Windows.Forms.Panel();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlMover = new System.Windows.Forms.Panel();
            this.PnlMover2 = new System.Windows.Forms.Panel();
            this.PnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlLeft.Controls.Add(this.PnlMover2);
            this.PnlLeft.Controls.Add(this.picLogo);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(200, 336);
            this.PnlLeft.TabIndex = 1;
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
            this.txPassManager.Location = new System.Drawing.Point(269, 64);
            this.txPassManager.Name = "txPassManager";
            this.txPassManager.Size = new System.Drawing.Size(246, 45);
            this.txPassManager.TabIndex = 2;
            this.txPassManager.Text = "PassManager";
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.txbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.Location = new System.Drawing.Point(294, 131);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(195, 26);
            this.txbLogin.TabIndex = 3;
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.Color.Gainsboro;
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.Location = new System.Drawing.Point(294, 170);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(195, 26);
            this.txbPass.TabIndex = 4;
            // 
            // LinLogin
            // 
            this.LinLogin.BackColor = System.Drawing.Color.Black;
            this.LinLogin.Enabled = false;
            this.LinLogin.Location = new System.Drawing.Point(294, 159);
            this.LinLogin.Name = "LinLogin";
            this.LinLogin.Size = new System.Drawing.Size(195, 2);
            this.LinLogin.TabIndex = 5;
            // 
            // LinPass
            // 
            this.LinPass.BackColor = System.Drawing.Color.Black;
            this.LinPass.Enabled = false;
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
            this.BtnEntrar.TabIndex = 7;
            this.BtnEntrar.Text = "Login";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(550, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(22, 22);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 8;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PnlMover
            // 
            this.PnlMover.BackColor = System.Drawing.Color.Transparent;
            this.PnlMover.ForeColor = System.Drawing.Color.Transparent;
            this.PnlMover.Location = new System.Drawing.Point(206, 0);
            this.PnlMover.Name = "PnlMover";
            this.PnlMover.Size = new System.Drawing.Size(328, 32);
            this.PnlMover.TabIndex = 10;
            this.PnlMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlMover_MouseDown);
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
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.PnlMover);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.LinPass);
            this.Controls.Add(this.LinLogin);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txPassManager);
            this.Controls.Add(this.PnlLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
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
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Panel LinLogin;
        private System.Windows.Forms.Panel LinPass;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlMover2;
        private System.Windows.Forms.Panel PnlMover;
    }
}
