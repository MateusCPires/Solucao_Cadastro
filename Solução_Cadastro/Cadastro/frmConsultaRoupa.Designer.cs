
namespace Cadastro
{
    partial class frmConsultaRoupa
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
            this.table_pessoa_ds2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLançamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roupasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRoupa = new Cadastro.DataSetRoupa();
            this.pessoa_dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Cadastro.DataSet1();
            this.pessoa_dsTableAdapter = new Cadastro.DataSet1TableAdapters.Pessoa_dsTableAdapter();
            this.tableAdapterManager = new Cadastro.DataSet1TableAdapters.TableAdapterManager();
            this.cmbProcurar = new System.Windows.Forms.ComboBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.txtPesquisa1 = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.roupasTableAdapter = new Cadastro.DataSetRoupaTableAdapters.RoupasTableAdapter();
            this.tableAdapterManager1 = new Cadastro.DataSetRoupaTableAdapters.TableAdapterManager();
            this.calData1 = new System.Windows.Forms.MonthCalendar();
            this.calData2 = new System.Windows.Forms.MonthCalendar();
            this.txtPesquisa2 = new System.Windows.Forms.TextBox();
            this.lblTexto2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_pessoa_ds2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRoupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // table_pessoa_ds2
            // 
            this.table_pessoa_ds2.AutoGenerateColumns = false;
            this.table_pessoa_ds2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_pessoa_ds2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn,
            this.dataLançamentoDataGridViewTextBoxColumn});
            this.table_pessoa_ds2.DataSource = this.roupasBindingSource;
            this.table_pessoa_ds2.Location = new System.Drawing.Point(11, 191);
            this.table_pessoa_ds2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.table_pessoa_ds2.Name = "table_pessoa_ds2";
            this.table_pessoa_ds2.RowHeadersWidth = 62;
            this.table_pessoa_ds2.RowTemplate.Height = 28;
            this.table_pessoa_ds2.Size = new System.Drawing.Size(1025, 225);
            this.table_pessoa_ds2.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            this.tamanhoDataGridViewTextBoxColumn.Width = 150;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.Width = 150;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.Width = 150;
            // 
            // preçoDataGridViewTextBoxColumn
            // 
            this.preçoDataGridViewTextBoxColumn.DataPropertyName = "Preço";
            this.preçoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.preçoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.preçoDataGridViewTextBoxColumn.Name = "preçoDataGridViewTextBoxColumn";
            this.preçoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataLançamentoDataGridViewTextBoxColumn
            // 
            this.dataLançamentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Lançamento";
            this.dataLançamentoDataGridViewTextBoxColumn.HeaderText = "Data_Lançamento";
            this.dataLançamentoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataLançamentoDataGridViewTextBoxColumn.Name = "dataLançamentoDataGridViewTextBoxColumn";
            this.dataLançamentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // roupasBindingSource
            // 
            this.roupasBindingSource.DataMember = "Roupas";
            this.roupasBindingSource.DataSource = this.dataSetRoupa;
            // 
            // dataSetRoupa
            // 
            this.dataSetRoupa.DataSetName = "DataSetRoupa";
            this.dataSetRoupa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoa_dsBindingSource
            // 
            this.pessoa_dsBindingSource.DataMember = "Pessoa_ds";
            this.pessoa_dsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoa_dsTableAdapter
            // 
            this.pessoa_dsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Pessoa_dsTableAdapter = this.pessoa_dsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cadastro.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbProcurar
            // 
            this.cmbProcurar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcurar.FormattingEnabled = true;
            this.cmbProcurar.Items.AddRange(new object[] {
            "Todos",
            "Contém",
            "Igual a",
            "Começa com",
            "Termina com"});
            this.cmbProcurar.Location = new System.Drawing.Point(96, 42);
            this.cmbProcurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProcurar.Name = "cmbProcurar";
            this.cmbProcurar.Size = new System.Drawing.Size(82, 21);
            this.cmbProcurar.TabIndex = 3;
            this.cmbProcurar.SelectedIndexChanged += new System.EventHandler(this.cmbProcurar_SelectedIndexChanged);
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTexto1.Location = new System.Drawing.Point(188, 22);
            this.lblTexto1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(37, 18);
            this.lblTexto1.TabIndex = 4;
            this.lblTexto1.Text = "Por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coluna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(93, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Procurar";
            // 
            // cmbColuna
            // 
            this.cmbColuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Marca",
            "Tamanho",
            "Cor",
            "Material",
            "Preço",
            "Data de Lançamento"});
            this.cmbColuna.Location = new System.Drawing.Point(11, 42);
            this.cmbColuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(82, 21);
            this.cmbColuna.TabIndex = 7;
            this.cmbColuna.SelectedIndexChanged += new System.EventHandler(this.cmbColuna_SelectedIndexChanged);
            // 
            // txtPesquisa1
            // 
            this.txtPesquisa1.Location = new System.Drawing.Point(191, 42);
            this.txtPesquisa1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesquisa1.Name = "txtPesquisa1";
            this.txtPesquisa1.Size = new System.Drawing.Size(306, 20);
            this.txtPesquisa1.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(860, 36);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(176, 26);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // roupasTableAdapter
            // 
            this.roupasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.RoupasTableAdapter = this.roupasTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Cadastro.DataSetRoupaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // calData1
            // 
            this.calData1.Location = new System.Drawing.Point(191, 18);
            this.calData1.Name = "calData1";
            this.calData1.TabIndex = 9;
            // 
            // calData2
            // 
            this.calData2.Location = new System.Drawing.Point(436, 18);
            this.calData2.Name = "calData2";
            this.calData2.TabIndex = 10;
            // 
            // txtPesquisa2
            // 
            this.txtPesquisa2.Location = new System.Drawing.Point(504, 42);
            this.txtPesquisa2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa2.Name = "txtPesquisa2";
            this.txtPesquisa2.Size = new System.Drawing.Size(306, 20);
            this.txtPesquisa2.TabIndex = 12;
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTexto2.Location = new System.Drawing.Point(501, 22);
            this.lblTexto2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(37, 18);
            this.lblTexto2.TabIndex = 11;
            this.lblTexto2.Text = "Por:";
            // 
            // frmConsultaRoupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 427);
            this.Controls.Add(this.txtPesquisa2);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.txtPesquisa1);
            this.Controls.Add(this.cmbColuna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.cmbProcurar);
            this.Controls.Add(this.table_pessoa_ds2);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.calData1);
            this.Controls.Add(this.calData2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConsultaRoupa";
            this.Text = "Consulta de Roupas";
            this.Load += new System.EventHandler(this.ConsultaPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_pessoa_ds2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRoupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView table_pessoa_ds2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pessoa_dsBindingSource;
        private DataSet1TableAdapters.Pessoa_dsTableAdapter pessoa_dsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbProcurar;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.TextBox txtPesquisa1;
        private DataSetRoupa dataSetRoupa;
        private System.Windows.Forms.BindingSource roupasBindingSource;
        private DataSetRoupaTableAdapters.RoupasTableAdapter roupasTableAdapter;
        private DataSetRoupaTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLançamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MonthCalendar calData1;
        private System.Windows.Forms.MonthCalendar calData2;
        private System.Windows.Forms.TextBox txtPesquisa2;
        private System.Windows.Forms.Label lblTexto2;
    }
}