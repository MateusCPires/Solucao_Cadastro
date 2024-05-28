
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
            this.pessoa_dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Cadastro.DataSet1();
            this.pessoa_dsTableAdapter = new Cadastro.DataSet1TableAdapters.Pessoa_dsTableAdapter();
            this.tableAdapterManager = new Cadastro.DataSet1TableAdapters.TableAdapterManager();
            this.cmbProcurar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dataSetRoupa = new Cadastro.DataSetRoupa();
            this.roupasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roupasTableAdapter = new Cadastro.DataSetRoupaTableAdapters.RoupasTableAdapter();
            this.tableAdapterManager1 = new Cadastro.DataSetRoupaTableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLançamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table_pessoa_ds2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRoupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingSource)).BeginInit();
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
            this.table_pessoa_ds2.Location = new System.Drawing.Point(8, 103);
            this.table_pessoa_ds2.Margin = new System.Windows.Forms.Padding(2);
            this.table_pessoa_ds2.Name = "table_pessoa_ds2";
            this.table_pessoa_ds2.RowHeadersWidth = 62;
            this.table_pessoa_ds2.RowTemplate.Height = 28;
            this.table_pessoa_ds2.Size = new System.Drawing.Size(964, 158);
            this.table_pessoa_ds2.TabIndex = 2;
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
            "Contém",
            "Igual a",
            "Começa com",
            "Termina com"});
            this.cmbProcurar.Location = new System.Drawing.Point(96, 42);
            this.cmbProcurar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProcurar.Name = "cmbProcurar";
            this.cmbProcurar.Size = new System.Drawing.Size(82, 21);
            this.cmbProcurar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(188, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Por:";
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
            "Cidade",
            "Email",
            "Data Nascimento"});
            this.cmbColuna.Location = new System.Drawing.Point(11, 42);
            this.cmbColuna.Margin = new System.Windows.Forms.Padding(2);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(82, 21);
            this.cmbColuna.TabIndex = 7;
            this.cmbColuna.SelectedIndexChanged += new System.EventHandler(this.cmbColuna_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(191, 42);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(306, 20);
            this.txtPesquisa.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(542, 43);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(800, 37);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(176, 26);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dataSetRoupa
            // 
            this.dataSetRoupa.DataSetName = "DataSetRoupa";
            this.dataSetRoupa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roupasBindingSource
            // 
            this.roupasBindingSource.DataMember = "Roupas";
            this.roupasBindingSource.DataSource = this.dataSetRoupa;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            // 
            // preçoDataGridViewTextBoxColumn
            // 
            this.preçoDataGridViewTextBoxColumn.DataPropertyName = "Preço";
            this.preçoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.preçoDataGridViewTextBoxColumn.Name = "preçoDataGridViewTextBoxColumn";
            // 
            // dataLançamentoDataGridViewTextBoxColumn
            // 
            this.dataLançamentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Lançamento";
            this.dataLançamentoDataGridViewTextBoxColumn.HeaderText = "Data_Lançamento";
            this.dataLançamentoDataGridViewTextBoxColumn.Name = "dataLançamentoDataGridViewTextBoxColumn";
            // 
            // frmConsultaRoupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 292);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cmbColuna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProcurar);
            this.Controls.Add(this.table_pessoa_ds2);
            this.Controls.Add(this.btnFiltrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultaRoupa";
            this.Text = "Consulta de Roupas";
            this.Load += new System.EventHandler(this.ConsultaPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_pessoa_ds2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRoupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}