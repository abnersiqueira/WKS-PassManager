using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PassManager.DAL;
using PassManager.Funcions;

namespace PassManager.View
{
    public partial class FrmInfoLoja : Form
    {
        public FrmInfoLoja()
        {
            InitializeComponent();
            DisableFirewall();  
            //--Desabilita as TextBox de preenchimento Relacionado ao Firewall\\
            
        }

        public void DisableFirewall()
        {
            txbSelecFirewall.Visible = false;
            txbIPFirewall.Visible = false;
            txbPorta.Visible = false;
            txbUsuarioFirewall.Visible = false;
            txbSenhaFirewall.Visible = false;
            txbOBS.Visible = false;

            labIP.Visible = false;
            labPorta.Visible = false;
            labUsuario.Visible = false;
            labSenha.Visible = false;
            labFirewall.Visible = false;
        }

        public void EnableFirewall()
        {
            txbSelecFirewall.Visible = true;
            txbIPFirewall.Visible = true;
            txbPorta.Visible = true;
            txbUsuarioFirewall.Visible = true;
            txbSenhaFirewall.Visible = true;
            txbOBS.Visible = true;

            labIP.Visible = true;
            labPorta.Visible = true;
            labUsuario.Visible = true;
            labSenha.Visible = true;
            labFirewall.Visible = true;
        }

        private void CheckFirewallEnable_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckFirewallEnable.Checked == false)
            {
                DisableFirewall();
            }
            else
            {
                EnableFirewall();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Crud_Empresa Empresa = new Crud_Empresa();
            Empresa.Cad_Empresa(txbDominio.Text, txbNomeSrv.Text, txbNomeSrv2.Text, txbTV.Text, txbTV2.Text, Convert.ToInt32(txbIP.Text),
            Convert.ToInt32(txbIP2.Text), txbUsuario.Text, txbUsuario2.Text, txbSenha.Text, txbSenha2.Text, CheckFirewallEnable.Checked,
            Convert.ToInt32(txbPorta.Text)
            , txbUsuarioFirewall.Text, txbSenhaFirewall.Text);

            // Empresa.carregar(1);

        }
    }

}
