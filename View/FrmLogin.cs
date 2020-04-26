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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void PnlMover_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnlMover2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
        }

        private void txbLogin1_MouseEnter(object sender, EventArgs e)
        {

            if (txbLogin1.Text == "Login")
            {
                txbLogin1.Text = "";
                txbLogin1.ForeColor = Color.DarkSlateGray;
            }
        }

        private void txbPass_MouseLeave(object sender, EventArgs e)
        {
            if (txbPass.Text == "")
            {
                txbPass.Text = "Senha";
                txbPass.ForeColor = Color.DarkSlateGray;
                txbPass.UseSystemPasswordChar = true;
            }
        }

        private void txbLogin1_MouseLeave(object sender, EventArgs e)
        {
            if (txbLogin1.Text == "")
            {
                txbLogin1.Text = "Login";
                txbLogin1.ForeColor = Color.DarkSlateGray;
            }
        }

        private void txbPass_MouseEnter(object sender, EventArgs e)
        {
            if (txbPass.Text == "Senha")
            {
                txbPass.Text = "";
                txbPass.ForeColor = Color.DarkSlateGray;
                txbPass.UseSystemPasswordChar = true;

            }
        }
        private void txbLogin1_TextChanged(object sender, EventArgs e)
        {
            if (txbLogin1.Text != "Login")
            {
                if (txbPass.Text != "Senha")
                {
                    txbPass.UseSystemPasswordChar = true;
                }
            }
        }

    }
}
