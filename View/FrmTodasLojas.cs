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
using PassManager.View;
using PassManager.Funcions;
using PassManager.ReceiveData;

namespace PassManager.View
{
   
    public partial class FrmTodasLojas : Form
    {
        private Form _objForm;
        public FrmTodasLojas()
        {
            InitializeComponent();
            
        }
        int id;

        private void AbrirPainelLoja()
        {
        
            _objForm?.Close();
            _objForm = new FrmInfoLoja(id)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlChamaLoja.Controls.Add(_objForm);
            _objForm.Show();
            _objForm.BringToFront();
        }

        private void BtnLoja1_Click(object sender, EventArgs e)
        {
            id = 2;
     

            _objForm?.Close();
            _objForm = new FrmInfoLoja (id)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlChamaLoja.Controls.Add(_objForm);
            _objForm.Show();
            _objForm.BringToFront();
        }

        private void BtnLoja2_Click(object sender, EventArgs e)
        {
            id = 2; // Assecex


            _objForm?.Close();
            _objForm = new FrmInfoLoja(id)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlChamaLoja.Controls.Add(_objForm);
            _objForm.Show();
            _objForm.BringToFront();
        }



        private void pnlChamaLoja_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            id = 1;

            AbrirPainelLoja();
        }

        private void BtnLoja01_Click(object sender, EventArgs e)
        {
            id = 1; //Abc

            AbrirPainelLoja();
        }

        private void BtnLoja03_Click(object sender, EventArgs e)
        {
            id = 3; // Arrais

            AbrirPainelLoja();
        }

        private void BtnLoja04_Click(object sender, EventArgs e)
        {
            id = 4;
            AbrirPainelLoja();
        }

        private void BtnLoja05_Click(object sender, EventArgs e)
        {
            id = 5;
            AbrirPainelLoja();
        }

        private void BtnLoja06_Click(object sender, EventArgs e)
        {
            id = 6; //AE Cidade
            AbrirPainelLoja();
        }

        private void BtnLoja07_Click(object sender, EventArgs e)
        {
            id = 7;  //Marina
            AbrirPainelLoja();
        }

        private void BtnLoja09_Click(object sender, EventArgs e)
        {
            id = 9; //BICHO PAPAO
            AbrirPainelLoja();
        }

        private void BtnLoja10_Click(object sender, EventArgs e)
        {
            id = 10;
            AbrirPainelLoja();
        }
    }
}
