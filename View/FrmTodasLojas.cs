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
            id = 6; //Radio CristalFM
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
            id = 13; //CFC ALIANCA
            AbrirPainelLoja();
        }

        private void BtnLoja14_Click(object sender, EventArgs e)
        {
            id = 14; //OTICAS CAROL
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

        private void BtnLoja19_Click(object sender, EventArgs e)
        {
            id = 19; // OMNI
            AbrirPainelLoja();
        }

        private void BtnLoja20_Click(object sender, EventArgs e)
        {
            id = 20; // MS CONSTRUTORA
            AbrirPainelLoja();
        }

        private void BtnLoja21_Click(object sender, EventArgs e)
        {
            id = 21; // MR MARCIO REZE
            AbrirPainelLoja();
        }

        private void BtnLoja22_Click(object sender, EventArgs e)
        {
            id = 22; // AE MARINA
            AbrirPainelLoja();
        }

        private void BtnLoja23_Click(object sender, EventArgs e)
        {
            id = 23; // MDL
            AbrirPainelLoja();
        }

        private void BtnLoja24_Click(object sender, EventArgs e)
        {
            id = 24; // ORTOCLIN
            AbrirPainelLoja();
        }

        private void BtnLoja25_Click(object sender, EventArgs e)
        {
            id = 25; // VANGUARDA
            AbrirPainelLoja();
        }

        private void BtnLoja26_Click(object sender, EventArgs e)
        {
            id = 26; // ESC SOLUCAO
            AbrirPainelLoja();
        }

        private void BtnLoja27_Click(object sender, EventArgs e)
        {
            id = 27; // RBA
            AbrirPainelLoja();
        }

        private void BtnLoja28_Click(object sender, EventArgs e)
        {
            id = 28; // MONT BLANC
            AbrirPainelLoja();
        }

        private void BtnLoja29_Click(object sender, EventArgs e)
        {
            id = 29; // RONALDO BORGES
            AbrirPainelLoja();
        }

        private void BtnLoja30_Click(object sender, EventArgs e)
        {
            id = 30; // SCL
            AbrirPainelLoja();
        }

        private void BtnLoja31_Click(object sender, EventArgs e)
        {
            id = 31; // SERITEC
            AbrirPainelLoja();
        }

        private void BtnLoja32_Click(object sender, EventArgs e)
        {
            id = 32; // WEIZUR
            AbrirPainelLoja();
        }

        private void BtnLoja33_Click(object sender, EventArgs e)
        {
            id = 33; // TV SOROCABA
            AbrirPainelLoja();
        }

        private void BtnLoja34_Click(object sender, EventArgs e)
        {
            id = 34; // UNIGRA
            AbrirPainelLoja();
        }

        private void BtnLoja35_Click(object sender, EventArgs e)
        {
            id = 35; // BUFFALO
            AbrirPainelLoja();
        }

        private void BtnLoja36_Click(object sender, EventArgs e)
        {
            id = 36; // VAZIO
            AbrirPainelLoja();
        }

        private void BtnLoja37_Click(object sender, EventArgs e)
        {
            id = 37; // VAZIO
            AbrirPainelLoja();
        }

        private void BtnLoja38_Click(object sender, EventArgs e)
        {
            id = 38; // VAZIO
            AbrirPainelLoja();
        }

        private void BtnLoja39_Click(object sender, EventArgs e)
        {
            id = 39; // VAZIO
            AbrirPainelLoja();
        }

        private void BtnLoja40_Click(object sender, EventArgs e)
        {
            id = 40; // VAZIO
            AbrirPainelLoja();
        }
    }
}
