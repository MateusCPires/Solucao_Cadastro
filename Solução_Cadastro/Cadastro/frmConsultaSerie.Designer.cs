
namespace Cadastro
{
    partial class frmConsultaSerie
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
            this.cmbProcurar = new System.Windows.Forms.ComboBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.txtPesquisa1 = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.calData1 = new System.Windows.Forms.MonthCalendar();
            this.calData2 = new System.Windows.Forms.MonthCalendar();
            this.txtPesquisa2 = new System.Windows.Forms.TextBox();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.tableAdapterManager2 = new Cadastro.DataSetSeriesTableAdapters.TableAdapterManager();
            this.seriesTableAdapter = new Cadastro.DataSetSeriesTableAdapters.SeriesTableAdapter();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSeries = new Cadastro.DataSetSeries();
            this.roupasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.cmbProcurar.Margin = new System.Windows.Forms.Padding(2);
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
            "NOME",
            "DESCRICAO",
            "CLASSIFICACAO",
            "NOTAS",
            "DATALANCAMENTO"});
            this.cmbColuna.Location = new System.Drawing.Point(11, 42);
            this.cmbColuna.Margin = new System.Windows.Forms.Padding(2);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(82, 21);
            this.cmbColuna.TabIndex = 7;
            this.cmbColuna.SelectedIndexChanged += new System.EventHandler(this.cmbColuna_SelectedIndexChanged);
            // 
            // txtPesquisa1
            // 
            this.txtPesquisa1.Location = new System.Drawing.Point(191, 42);
            this.txtPesquisa1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa1.Name = "txtPesquisa1";
            this.txtPesquisa1.Size = new System.Drawing.Size(306, 20);
            this.txtPesquisa1.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(860, 36);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(176, 26);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // calData1
            // 
            this.calData1.Location = new System.Drawing.Point(191, 42);
            this.calData1.Name = "calData1";
            this.calData1.TabIndex = 9;
            // 
            // calData2
            // 
            this.calData2.Location = new System.Drawing.Point(504, 42);
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
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.SeriesTableAdapter = this.seriesTableAdapter;
            this.tableAdapterManager2.UpdateOrder = Cadastro.DataSetSeriesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.dataSetSeries;
            // 
            // dataSetSeries
            // 
            this.dataSetSeries.DataSetName = "DataSetSeries";
            this.dataSetSeries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seriesDataGridView
            // 
            this.seriesDataGridView.AutoGenerateColumns = false;
            this.seriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.seriesDataGridView.DataSource = this.seriesBindingSource;
            this.seriesDataGridView.Location = new System.Drawing.Point(14, 247);
            this.seriesDataGridView.Name = "seriesDataGridView";
            this.seriesDataGridView.Size = new System.Drawing.Size(1025, 237);
            this.seriesDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DESCRICAO";
            this.dataGridViewTextBoxColumn3.HeaderText = "DESCRICAO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CLASSIFICACAO";
            this.dataGridViewTextBoxColumn4.HeaderText = "CLASSIFICACAO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NOTAS";
            this.dataGridViewTextBoxColumn5.HeaderText = "NOTAS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DATALANCAMENTO";
            this.dataGridViewTextBoxColumn6.HeaderText = "DATALANCAMENTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmConsultaSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 496);
            this.Controls.Add(this.seriesDataGridView);
            this.Controls.Add(this.txtPesquisa2);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.txtPesquisa1);
            this.Controls.Add(this.cmbColuna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.cmbProcurar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.calData1);
            this.Controls.Add(this.calData2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultaSerie";
            this.Text = "Consulta de Roupas";
            this.Load += new System.EventHandler(this.ConsultaPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbProcurar;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.TextBox txtPesquisa1;
        private System.Windows.Forms.MonthCalendar calData1;
        private System.Windows.Forms.MonthCalendar calData2;
        private System.Windows.Forms.TextBox txtPesquisa2;
        private System.Windows.Forms.Label lblTexto2;
        private DataSetSeriesTableAdapters.TableAdapterManager tableAdapterManager2;
        private DataSetSeriesTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private DataSetSeries dataSetSeries;
        private System.Windows.Forms.BindingSource roupasBindingSource;
        private System.Windows.Forms.DataGridView seriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}