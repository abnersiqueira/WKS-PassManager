namespace PassManager.View
{
    partial class FrmTodasLojasList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTodasLojasList));
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.empresas = new PassManager.Empresas();
            this.tb_DadosLojaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_DadosLojaTableAdapter = new PassManager.EmpresasTableAdapters.tb_DadosLojaTableAdapter();
            this.tableAdapterManager = new PassManager.EmpresasTableAdapters.TableAdapterManager();
            this.tb_DadosLojaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DadosLojaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DadosLojaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1101, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 681);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_DadosLojaDataGridView);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 681);
            this.panel1.TabIndex = 1;
            // 
            // empresas
            // 
            this.empresas.DataSetName = "Empresas";
            this.empresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_DadosLojaBindingSource
            // 
            this.tb_DadosLojaBindingSource.DataMember = "tb_DadosLoja";
            this.tb_DadosLojaBindingSource.DataSource = this.empresas;
            // 
            // tb_DadosLojaTableAdapter
            // 
            this.tb_DadosLojaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_DadosLojaTableAdapter = this.tb_DadosLojaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PassManager.EmpresasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_DadosLojaDataGridView
            // 
            this.tb_DadosLojaDataGridView.AutoGenerateColumns = false;
            this.tb_DadosLojaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_DadosLojaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tb_DadosLojaDataGridView.DataSource = this.tb_DadosLojaBindingSource;
            this.tb_DadosLojaDataGridView.Location = new System.Drawing.Point(202, 135);
            this.tb_DadosLojaDataGridView.Name = "tb_DadosLojaDataGridView";
            this.tb_DadosLojaDataGridView.Size = new System.Drawing.Size(694, 264);
            this.tb_DadosLojaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_DadosLoja";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_empresa";
            this.dataGridViewTextBoxColumn2.HeaderText = "EMPRESA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nome_resp";
            this.dataGridViewTextBoxColumn3.HeaderText = "RESPONSÁVEL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // FrmTodasLojasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 681);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTodasLojasList";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FrmTodasLojasList";
            this.Load += new System.EventHandler(this.FrmTodasLojasList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DadosLojaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DadosLojaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private Empresas empresas;
        private System.Windows.Forms.BindingSource tb_DadosLojaBindingSource;
        private EmpresasTableAdapters.tb_DadosLojaTableAdapter tb_DadosLojaTableAdapter;
        private EmpresasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_DadosLojaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}