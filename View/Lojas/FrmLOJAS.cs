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
    public partial class FrmLOJAS : Form
    {
        public FrmLOJAS()
        {
            InitializeComponent();
            DisableFirewall();          //--Desabilita as TextBox de preenchimento Relacionado ao Firewall\\
        
        }

        private void FrmLOJAS_Load(object sender, EventArgs e)
        {
            this.tb_DadosLojaTableAdapter.Fill(this.masterDataSet.tb_DadosLoja);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.tb_loja'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_lojaTableAdapter.Fill(this.masterDataSet.tb_loja);

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

        public void CheckFirewallEnable_CheckedChanged(object sender, EventArgs e)
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

        private void tb_lojaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_lojaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }


    }
}
