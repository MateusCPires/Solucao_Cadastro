
namespace Cadastro
{
    partial class frmForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label dESCRICAOLabel;
            System.Windows.Forms.Label nOTASLabel;
            System.Windows.Forms.Label dATALANCAMENTOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm));
            System.Windows.Forms.Label cLASSIFICACAOLabel1;
            this.dataSetSeries = new Cadastro.DataSetSeries();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTableAdapter = new Cadastro.DataSetSeriesTableAdapters.SeriesTableAdapter();
            this.tableAdapterManager = new Cadastro.DataSetSeriesTableAdapters.TableAdapterManager();
            this.seriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.seriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.dESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.nOTASTextBox = new System.Windows.Forms.TextBox();
            this.dATALANCAMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cLASSIFICACAOComboBox = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            dESCRICAOLabel = new System.Windows.Forms.Label();
            nOTASLabel = new System.Windows.Forms.Label();
            dATALANCAMENTOLabel = new System.Windows.Forms.Label();
            cLASSIFICACAOLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingNavigator)).BeginInit();
            this.seriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 25);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(12, 51);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 4;
            nOMELabel.Text = "NOME:";
            // 
            // dESCRICAOLabel
            // 
            dESCRICAOLabel.AutoSize = true;
            dESCRICAOLabel.Location = new System.Drawing.Point(12, 77);
            dESCRICAOLabel.Name = "dESCRICAOLabel";
            dESCRICAOLabel.Size = new System.Drawing.Size(72, 13);
            dESCRICAOLabel.TabIndex = 6;
            dESCRICAOLabel.Text = "DESCRICAO:";
            // 
            // nOTASLabel
            // 
            nOTASLabel.AutoSize = true;
            nOTASLabel.Location = new System.Drawing.Point(12, 129);
            nOTASLabel.Name = "nOTASLabel";
            nOTASLabel.Size = new System.Drawing.Size(47, 13);
            nOTASLabel.TabIndex = 10;
            nOTASLabel.Text = "NOTAS:";
            // 
            // dATALANCAMENTOLabel
            // 
            dATALANCAMENTOLabel.AutoSize = true;
            dATALANCAMENTOLabel.Location = new System.Drawing.Point(12, 156);
            dATALANCAMENTOLabel.Name = "dATALANCAMENTOLabel";
            dATALANCAMENTOLabel.Size = new System.Drawing.Size(113, 13);
            dATALANCAMENTOLabel.TabIndex = 12;
            dATALANCAMENTOLabel.Text = "DATALANCAMENTO:";
            // 
            // dataSetSeries
            // 
            this.dataSetSeries.DataSetName = "DataSetSeries";
            this.dataSetSeries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.dataSetSeries;
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SeriesTableAdapter = this.seriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cadastro.DataSetSeriesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // seriesBindingNavigator
            // 
            this.seriesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.seriesBindingNavigator.BindingSource = this.seriesBindingSource;
            this.seriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.seriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.seriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.seriesBindingNavigatorSaveItem});
            this.seriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.seriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.seriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.seriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.seriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.seriesBindingNavigator.Name = "seriesBindingNavigator";
            this.seriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.seriesBindingNavigator.Size = new System.Drawing.Size(880, 25);
            this.seriesBindingNavigator.TabIndex = 0;
            this.seriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // seriesBindingNavigatorSaveItem
            // 
            this.seriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.seriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("seriesBindingNavigatorSaveItem.Image")));
            this.seriesBindingNavigatorSaveItem.Name = "seriesBindingNavigatorSaveItem";
            this.seriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.seriesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.seriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.seriesBindingNavigatorSaveItem_Click);
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
            this.seriesDataGridView.Location = new System.Drawing.Point(12, 229);
            this.seriesDataGridView.Name = "seriesDataGridView";
            this.seriesDataGridView.Size = new System.Drawing.Size(848, 220);
            this.seriesDataGridView.TabIndex = 1;
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
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(131, 22);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(131, 48);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(200, 20);
            this.nOMETextBox.TabIndex = 5;
            // 
            // dESCRICAOTextBox
            // 
            this.dESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "DESCRICAO", true));
            this.dESCRICAOTextBox.Location = new System.Drawing.Point(131, 74);
            this.dESCRICAOTextBox.Name = "dESCRICAOTextBox";
            this.dESCRICAOTextBox.Size = new System.Drawing.Size(200, 20);
            this.dESCRICAOTextBox.TabIndex = 7;
            // 
            // nOTASTextBox
            // 
            this.nOTASTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "NOTAS", true));
            this.nOTASTextBox.Location = new System.Drawing.Point(131, 126);
            this.nOTASTextBox.Name = "nOTASTextBox";
            this.nOTASTextBox.Size = new System.Drawing.Size(200, 20);
            this.nOTASTextBox.TabIndex = 11;
            // 
            // dATALANCAMENTODateTimePicker
            // 
            this.dATALANCAMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.seriesBindingSource, "DATALANCAMENTO", true));
            this.dATALANCAMENTODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATALANCAMENTODateTimePicker.Location = new System.Drawing.Point(131, 152);
            this.dATALANCAMENTODateTimePicker.Name = "dATALANCAMENTODateTimePicker";
            this.dATALANCAMENTODateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATALANCAMENTODateTimePicker.TabIndex = 13;
            // 
            // cLASSIFICACAOLabel1
            // 
            cLASSIFICACAOLabel1.AutoSize = true;
            cLASSIFICACAOLabel1.Location = new System.Drawing.Point(12, 101);
            cLASSIFICACAOLabel1.Name = "cLASSIFICACAOLabel1";
            cLASSIFICACAOLabel1.Size = new System.Drawing.Size(92, 13);
            cLASSIFICACAOLabel1.TabIndex = 14;
            cLASSIFICACAOLabel1.Text = "CLASSIFICACAO:";
            // 
            // cLASSIFICACAOComboBox
            // 
            this.cLASSIFICACAOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "CLASSIFICACAO", true));
            this.cLASSIFICACAOComboBox.FormattingEnabled = true;
            this.cLASSIFICACAOComboBox.Items.AddRange(new object[] {
            "L",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.cLASSIFICACAOComboBox.Location = new System.Drawing.Point(131, 98);
            this.cLASSIFICACAOComboBox.Name = "cLASSIFICACAOComboBox";
            this.cLASSIFICACAOComboBox.Size = new System.Drawing.Size(200, 21);
            this.cLASSIFICACAOComboBox.TabIndex = 15;
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 469);
            this.Controls.Add(cLASSIFICACAOLabel1);
            this.Controls.Add(this.cLASSIFICACAOComboBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(dESCRICAOLabel);
            this.Controls.Add(this.dESCRICAOTextBox);
            this.Controls.Add(nOTASLabel);
            this.Controls.Add(this.nOTASTextBox);
            this.Controls.Add(dATALANCAMENTOLabel);
            this.Controls.Add(this.dATALANCAMENTODateTimePicker);
            this.Controls.Add(this.seriesDataGridView);
            this.Controls.Add(this.seriesBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmForm";
            this.Text = "Casdastro de Roupas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingNavigator)).EndInit();
            this.seriesBindingNavigator.ResumeLayout(false);
            this.seriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetSeries dataSetSeries;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private DataSetSeriesTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private DataSetSeriesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator seriesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton seriesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView seriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox dESCRICAOTextBox;
        private System.Windows.Forms.TextBox nOTASTextBox;
        private System.Windows.Forms.DateTimePicker dATALANCAMENTODateTimePicker;
        private System.Windows.Forms.ComboBox cLASSIFICACAOComboBox;
    }
}

