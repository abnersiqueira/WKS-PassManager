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
            //CadastroUsuario cad = new CadastroUsuario(txbUser.Text, txbSenha.Text);
            //MessageBox.Show(cad.mensagem);
            //this.dataGridView1.Refresh();
            //this.dataGridView1.RefreshEdit();        //Atualização do DataGrid não funciona
            //this.dataGridView1.Update();

            //--Puxa do Banco tabela atualizada conform DataDrid--\\
            this.tb_logonTableAdapter.Fill(this.tb_logon_DataGrid.tb_logon);  


        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tb_logon_DataGrid.tb_logon'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_logonTableAdapter.Fill(this.tb_logon_DataGrid.tb_logon);

        }

        private void consultarLoginToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_logonTableAdapter.ConsultarLogin(this.tb_logon_DataGrid.tb_logon);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
