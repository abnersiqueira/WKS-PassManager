using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PassManager.Model;
using PassManager.View;
using System.Data.SqlClient;

namespace PassManager
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static bool SetStyle(Control c, ControlStyles Style, bool value)
        {
            bool retval = false;
            Type typeTB = typeof(Control);
            System.Reflection.MethodInfo misSetStyle = typeTB.GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (misSetStyle != null && c != null) { misSetStyle.Invoke(c, new object[] { Style, value }); retval = true; }
            return retval;
        }


        private void BtnEntrar_Click_1(object sender, EventArgs e)
        {

            Controle controle = new Controle();
            controle.acessar(txbLogin1.Text, txbPass.Text);

            if (controle.tem)
            {
                MessageBox.Show("Logon com sucesso", "LOGON", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmMainMenu menu = new FrmMainMenu();
                menu.Show();
               

                FrmLogin login = new FrmLogin();
                login.Focus();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Login não cadastrado", "Erro ao se conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void txbLogin1_MouseEnter_1(object sender, EventArgs e)
        {
            if (txbLogin1.Text == "Login")
            {
                txbLogin1.Text = "";
                txbLogin1.ForeColor = Color.Black;
            }
        }

        private void txbLogin1_MouseLeave_1(object sender, EventArgs e)
        {
            if (txbLogin1.Text == "")
            {
                txbLogin1.Text = "Login";
                txbLogin1.ForeColor = Color.Black;
            }
        }

   
        private void txbPass_MouseLeave(object sender, EventArgs e)
        {
            if (txbPass.Text == "")
            {
                txbPass.Text = "Senha";
                txbPass.ForeColor = Color.Black;
                txbPass.UseSystemPasswordChar = true;
            }
        }

        private void txbPass_MouseEnter_1(object sender, EventArgs e)
        {
            if (txbPass.Text == "Senha")
            {
                txbPass.Text = "";
                txbPass.ForeColor = Color.Black;
                txbPass.UseSystemPasswordChar = true;

            }
        }

        private void PnlMover_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnLLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txbLogin1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
