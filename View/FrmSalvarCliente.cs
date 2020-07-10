using PassManager.Funcions;
using PassManager.ReceiveData;
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
    public partial class FrmCadLoja : Form
    {
        public FrmCadLoja()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Crud_Empresa Empresa = new Crud_Empresa();
            Empresa.Cad_Empresa(
            Convert.ToInt32(txbDominio.Text),
            txbDominio.Text,
            txbNomeSrv.Text, txbNomeSrv2.Text,
            txbTV.Text, txbTV2.Text,
            Convert.ToString(txbIP.Text),
            txbIP2.Text,
            txbUsuario.Text, txbUsuario2.Text,
            txbSenha.Text, txbSenha2.Text,
            txbIPFirewall.Text,
            Convert.ToInt32(txbPorta.Text),
            txbUsuarioFirewall.Text,
            txbSenhaFirewall.Text,
            txbNomeEmpresa.Text,
            txbRespEmpresa.Text,
            txbEmailEmpresa.Text,
            txbTelefoneEmpresa.Text,
            txbTelefoneEmpresa2.Text,
            txbCelEmpresa.Text,
            txbCelEmpresa2.Text,
            TxbOBS1.Text,
            TxbOBS2.Text,
            txbSelecFirewall.Text);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbTelefoneEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
