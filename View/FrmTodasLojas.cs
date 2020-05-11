﻿using System;
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

namespace PassManager.View
{
   
    public partial class FrmTodasLojas : Form
    {
        private Form _objForm;
        public FrmTodasLojas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FrmInfoLoja      
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlChamaLoja.Controls.Add(_objForm);
            _objForm.Show();
            _objForm.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FrmInfoLoja
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlChamaLoja.Controls.Add(_objForm);
            _objForm.Show();
            _objForm.BringToFront();
        }

        private void BtnLoja3_Click(object sender, EventArgs e)
        {
            FrmCadUsuario abre = new FrmCadUsuario();
            abre.Show();
        }
    }
}
