
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PassManager.View;
using System.Data.SqlClient;
using PassManager.DAL;

namespace PassManager.View
{
    public partial class FrmMainMenu : Form
    {
        private Form _objForm;
        public FrmMainMenu()
        {
            InitializeComponent();
            
        }


        //Inicializa componente para mover barras da janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //::::::::::::::::::::::::::::::::::::::::::::::::
        //:::::::::::::: FUNÇÕES DO SISTEMA ::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::
        private void MenuLojas()
        {
            _objForm?.Close();
            _objForm = new FrmTodasLojas//FrmConteudoMenu
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnLMenu.Controls.Add(_objForm);
            _objForm.Show();


            _objForm.BringToFront();
            // this.Close();


            // AbrirFormulario<FrmConteudoMenu>();
        }


        private void BtnLojas_Click(object sender, EventArgs e)
        {
            MenuLojas();

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

     

        private void BtnSairMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnConfigSistema_Click(object sender, EventArgs e)
        {
            FrmCadUsuario cad = new FrmCadUsuario();
            cad.Show();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            //Pega a posição e tamanho antes de restaurar
            //lx = 1260;
            //ly = 720;
            ////sw = this.Size.Width;
            ////sh = this.Size.Height;
            WindowState = FormWindowState.Normal;
            

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = new Size(1260, 720);
            BtnRestaura.Visible = true;
            BtnMaximize.Visible = false;

            
            //this.Location = new Point(lx, ly);
        }

        private void BtnRestaura_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
            //this.Size = new Size(sw, sh);
            //this.Location = new Point(lx, ly);
            BtnRestaura.Visible = false;
            BtnMaximize.Visible = true;

        }

    }
}
