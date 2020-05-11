using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PassManager.DAL.Conexao;

namespace PassManager.View
{
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroUsuario cad = new CadastroUsuario(txbUser.Text, txbSenha.Text);
            MessageBox.Show(cad.mensagem);
            
        }
    }
}
