﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PassManager.View;

namespace PassManager.View
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }


        //Inicializa componente para mover barras da janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PainelCentral.Controls.OfType<MiForm>().FirstOrDefault();//Busca na coleção do formulário
                                                                                  //Se form ou instancia existir
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PainelCentral.Controls.Add(formulario);
                PainelCentral.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //Se form ou instancia existir
            else
            {
                formulario.BringToFront();
            }
        }
                        
        public void BtnLojas_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<FrmConteudoMenu>();
        }

        private void PnLSupMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int lx, ly;
        int sw, sh;

        private void BtnSairMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            //Pega a posição e tamanho antes de restaurar
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            BtnRestaura.Visible = false;
            BtnRestaura.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BtnRestaura_Click(object sender, EventArgs e)
        {
            BtnRestaura.Visible = true;
   
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

        }

    }
}
