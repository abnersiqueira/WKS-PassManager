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
    public partial class FrmTodasLojasList : Form
    {
        public FrmTodasLojasList()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_DadosLojaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_DadosLojaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresas);

        }

        private void FrmTodasLojasList_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'empresas.tb_DadosLoja'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_DadosLojaTableAdapter.Fill(this.empresas.tb_DadosLoja);

        }
    }
}
