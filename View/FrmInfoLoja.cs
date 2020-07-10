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
using PassManager.ReceiveData;

namespace PassManager.View
{
    public partial class FrmInfoLoja : Form
    {
        public FrmInfoLoja()
        {
            InitializeComponent();
            
            //--Desabilita as TextBox de preenchimento Relacionado ao Firewall\\
                      
        }

        public FrmInfoLoja(int id2)
        {
            InitializeComponent();
            codigo = id2;
            CarregaDados();
        }
        int codigo = 1337;


        public void CarregaDados()  //Carregando config empresa
        {
            Crud_Empresa emp = new Crud_Empresa();
            Dados_Empresa dados = emp.Carregar(codigo);

            txbID.Text                  = Convert.ToString(dados.id);
            txbDominio.Text             = dados.dominio;
            txbNomeSrv.Text             = dados.nomesrv;
            txbNomeSrv2.Text            = dados.nomesrv2;
            txbTV.Text                  = dados.teamviewer;
            txbTV2.Text                 = dados.teamviewer2;
            txbIP.Text                  = Convert.ToString(dados.ipsrv);
            txbIP2.Text                 = Convert.ToString(dados.ipsrv2);
            txbUsuario.Text             = dados.usuariosrv;
            txbUsuario2.Text            = dados.usuariosrv2;
            txbSenha.Text               = dados.senhasrv;
            txbSenha2.Text              = dados.senhasrv2;
            txbIPFirewall.Text          = Convert.ToString(dados.ipfirewall);
            txbPorta.Text               = Convert.ToString(dados.portafirewall);
            txbUsuarioFirewall.Text     = dados.usuariofirewall;
            txbSenhaFirewall.Text       = dados.senhafirewall;
            txbNomeEmpresa.Text         = dados.nome_empresa;
            txbRespEmpresa.Text         = dados.nome_resp;
            txbEmailEmpresa.Text        = dados.emp_email;
            txbTelefoneEmpresa.Text     = dados.emp_tel;
            txbTelefoneEmpresa2.Text    = dados.emp_tel2;
            txbCelEmpresa.Text          = dados.emp_cel;
            txbCelEmpresa2.Text         = dados.emp_cel2;
            TxbOBS1.Text                = dados.obs1;
            TxbOBS2.Text                = dados.obs2;
            txbSelecFirewall.Text       = dados.selectfirewall;

            txbID.Text = Convert.ToString(dados.id);   //Tratamento do ID para "somente leitura"
            txbID.ReadOnly = true;

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Alter_Empresa Empresa = new Alter_Empresa();
            Empresa.Crud_Empresa(
            Convert.ToInt32(txbID.Text),
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
    }

}
