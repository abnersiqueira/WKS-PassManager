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
using System.Security.Principal;

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

        //::::::::::::::::::::::::::::::::::::::::::::::::
        //:::::::::::::: FUNÇÕES DO SISTEMA ::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::
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


        private void BtnLoja01_Click(object sender, EventArgs e)
        {
            id = 1; //Abc

            AbrirPainelLoja();
        }

        private void BtnLoja2_Click(object sender, EventArgs e)
        {
            id = 2; // Assecex
            Console.WriteLine("TESTEOK");
            AbrirPainelLoja();
            
        }

        private void BtnLoja03_Click(object sender, EventArgs e)
        {
            id = 3; // Arrais

            AbrirPainelLoja();
        }

        private void BtnLoja04_Click(object sender, EventArgs e)
        {
            id = 4; //APAE
            AbrirPainelLoja();
        }

        private void BtnLoja05_Click(object sender, EventArgs e)
        {
            id = 5; //ACAP
            AbrirPainelLoja();
        }

        private void BtnLoja06_Click(object sender, EventArgs e)
        {
            id = 6; //Disponível
            AbrirPainelLoja();
        }

        private void BtnLoja07_Click(object sender, EventArgs e)
        {
            id = 7;  //MARINA
            AbrirPainelLoja();
        }
        private void BtnLoja08_Click(object sender, EventArgs e)
        {
            id = 8; //BP
            AbrirPainelLoja();
        }

        private void BtnLoja09_Click(object sender, EventArgs e)
        {
            id = 9; //BIOLUB
            AbrirPainelLoja();
        }

        private void BtnLoja10_Click(object sender, EventArgs e)
        {
            id = 10; //BM7
            AbrirPainelLoja();
        }

        private void BtnLoja11_Click(object sender, EventArgs e)
        {
            id = 11;//AE CIDADE
            AbrirPainelLoja();
        }

        private void BtnLoja12_Click(object sender, EventArgs e)
        {
            id = 12; //CCS
            AbrirPainelLoja();
           
        }

        private void BtnLoja13_Click(object sender, EventArgs e)
        {
            id = 13; //CNH
            AbrirPainelLoja();
        }

        private void BtnLoja14_Click(object sender, EventArgs e)
        {
            id = 14; //CRIART
            AbrirPainelLoja();
        }

        private void BtnLoja15_Click(object sender, EventArgs e)
        {
            id = 15; //DEXT TRANSPORTES
            AbrirPainelLoja();
        }

        private void BtnLoja16_Click(object sender, EventArgs e)
        {
            id = 16; // GKS
            AbrirPainelLoja();
        }

        private void BtnLoja17_Click(object sender, EventArgs e)
        {
            id = 17; // IMPRESSO BRASIl
            AbrirPainelLoja();
        }

        private void BtnLoja18_Click(object sender, EventArgs e)
        {
            id = 18; // JDJ
            AbrirPainelLoja();
        }
    }
}
