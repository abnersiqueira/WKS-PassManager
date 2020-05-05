using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager.View
{
    public partial class FrmConteudoMenu : Form
    {
        public FrmConteudoMenu()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnLConteudoMenu.Controls.OfType<MiForm>().FirstOrDefault();//Busca na coleção do formulário
                                                                                  //Se form ou instancia existir
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnLConteudoMenu.Controls.Add(formulario);
                pnLConteudoMenu.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //Se form ou instancia existir
            else
            {
                formulario.BringToFront();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

          

           // FrmLojaWKS loja = new FrmLojaWKS();
           //     loja.Show();
        }

        private void pnLConteudoMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmConteudoMenu_Load(object sender, EventArgs e)
        {

        }

        private void pnLConteudoMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Btn_wks_Click(object sender, EventArgs e)
        {
             FrmLOJAS loja = new FrmLOJAS();
            this.Close();
            loja.Show();

        // AbrirFormulario<FrmLOJAS>();
            // FrmConteudoMenu
        }
    }
}
