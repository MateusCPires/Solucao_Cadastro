
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label tamanhoLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label preçoLabel;
            System.Windows.Forms.Label data_LançamentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm));
            System.Windows.Forms.Label label1;
            this.dataSetRoupa = new Cadastro.DataSetRoupa();
            this.roupasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roupasTableAdapter = new Cadastro.DataSetRoupaTableAdapters.RoupasTableAdapter();
            this.tableAdapterManager = new Cadastro.DataSetRoupaTableAdapters.TableAdapterManager();
            this.roupasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.roupasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLançamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.tamanhoTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.preçoTextBox = new System.Windows.Forms.TextBox();
            this.data_LançamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            nomeLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            tamanhoLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            preçoLabel = new System.Windows.Forms.Label();
            data_LançamentoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRoupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingNavigator)).BeginInit();
            this.roupasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Arial", 12F);
            nomeLabel.Location = new System.Drawing.Point(15, 43);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(82, 27);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Arial", 12F);
            marcaLabel.Location = new System.Drawing.Point(15, 75);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(84, 27);
            marcaLabel.TabIndex = 6;
            marcaLabel.Text = "Marca:";
            // 
            // tamanhoLabel
            // 
            tamanhoLabel.AutoSize = true;
            tamanhoLabel.Font = new System.Drawing.Font("Arial", 12F);
            tamanhoLabel.Location = new System.Drawing.Point(15, 108);
            tamanhoLabel.Name = "tamanhoLabel";
            tamanhoLabel.Size = new System.Drawing.Size(117, 27);
            tamanhoLabel.TabIndex = 8;
            tamanhoLabel.Text = "Tamanho:";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Font = new System.Drawing.Font("Arial", 12F);
            corLabel.Location = new System.Drawing.Point(15, 138);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(57, 27);
            corLabel.TabIndex = 10;
            corLabel.Text = "Cor:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new System.Drawing.Font("Arial", 12F);
            materialLabel.Location = new System.Drawing.Point(-152, 217);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(103, 27);
            materialLabel.TabIndex = 12;
            materialLabel.Text = "Material:";
            // 
            // preçoLabel
            // 
            preçoLabel.AutoSize = true;
            preçoLabel.Font = new System.Drawing.Font("Arial", 12F);
            preçoLabel.Location = new System.Drawing.Point(15, 203);
            preçoLabel.Name = "preçoLabel";
            preçoLabel.Size = new System.Drawing.Size(81, 27);
            preçoLabel.TabIndex = 14;
            preçoLabel.Text = "Preço:";
            // 
            // data_LançamentoLabel
            // 
            data_LançamentoLabel.AutoSize = true;
            data_LançamentoLabel.Font = new System.Drawing.Font("Arial", 12F);
            data_LançamentoLabel.Location = new System.Drawing.Point(15, 235);
            data_LançamentoLabel.Name = "data_LançamentoLabel";
            data_LançamentoLabel.Size = new System.Drawing.Size(208, 27);
            data_LançamentoLabel.TabIndex = 16;
            data_LançamentoLabel.Text = "Data Lançamento:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RoupasTableAdapter = this.roupasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cadastro.DataSetRoupaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roupasBindingNavigator
            // 
            this.roupasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roupasBindingNavigator.BindingSource = this.roupasBindingSource;
            this.roupasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roupasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roupasBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.roupasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.roupasBindingNavigatorSaveItem});
            this.roupasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roupasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roupasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roupasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roupasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roupasBindingNavigator.Name = "roupasBindingNavigator";
            this.roupasBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.roupasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roupasBindingNavigator.Size = new System.Drawing.Size(1570, 46);
            this.roupasBindingNavigator.TabIndex = 0;
            this.roupasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 41);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // roupasBindingNavigatorSaveItem
            // 
            this.roupasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roupasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roupasBindingNavigatorSaveItem.Image")));
            this.roupasBindingNavigatorSaveItem.Name = "roupasBindingNavigatorSaveItem";
            this.roupasBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.roupasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.roupasBindingNavigatorSaveItem.Click += new System.EventHandler(this.roupasBindingNavigatorSaveItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn,
            this.dataLançamentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roupasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 292);
            this.dataGridView1.TabIndex = 1;
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
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roupasBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.nomeTextBox.Location = new System.Drawing.Point(230, 35);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 35);
            this.nomeTextBox.TabIndex = 5;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roupasBindingSource, "Marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.marcaTextBox.Location = new System.Drawing.Point(230, 68);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(200, 35);
            this.marcaTextBox.TabIndex = 7;
            // 
            // tamanhoTextBox
            // 
            this.tamanhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roupasBindingSource, "Tamanho", true));
            this.tamanhoTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.tamanhoTextBox.Location = new System.Drawing.Point(689, 213);
            this.tamanhoTextBox.Name = "tamanhoTextBox";
            this.tamanhoTextBox.Size = new System.Drawing.Size(200, 35);
            this.tamanhoTextBox.TabIndex = 9;
            // 
            // corTextBox
            // 
            this.corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roupasBindingSource, "Cor", true));
            this.corTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.corTextBox.Location = new System.Drawing.Point(230, 130);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(200, 35);
            this.corTextBox.TabIndex = 11;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roupasBindingSource, "Material", true));
            this.materialTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.materialTextBox.Location = new System.Drawing.Point(230, 165);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(200, 35);
            this.materialTextBox.TabIndex = 13;
            // 
            // preçoTextBox
            // 
            this.preçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roupasBindingSource, "Preço", true));
            this.preçoTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.preçoTextBox.Location = new System.Drawing.Point(230, 195);
            this.preçoTextBox.Name = "preçoTextBox";
            this.preçoTextBox.Size = new System.Drawing.Size(200, 35);
            this.preçoTextBox.TabIndex = 15;
            // 
            // data_LançamentoDateTimePicker
            // 
            this.data_LançamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roupasBindingSource, "Data_Lançamento", true));
            this.data_LançamentoDateTimePicker.Font = new System.Drawing.Font("Arial", 12F);
            this.data_LançamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_LançamentoDateTimePicker.Location = new System.Drawing.Point(230, 228);
            this.data_LançamentoDateTimePicker.Name = "data_LançamentoDateTimePicker";
            this.data_LançamentoDateTimePicker.Size = new System.Drawing.Size(200, 35);
            this.data_LançamentoDateTimePicker.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roupasBindingSource, "Tamanho", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PP",
            "P",
            "M",
            "G",
            "GG"});
            this.comboBox1.Location = new System.Drawing.Point(230, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F);
            label1.Location = new System.Drawing.Point(15, 168);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 27);
            label1.TabIndex = 19;
            label1.Text = "Material:";
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 629);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(tamanhoLabel);
            this.Controls.Add(this.tamanhoTextBox);
            this.Controls.Add(corLabel);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(materialLabel);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(preçoLabel);
            this.Controls.Add(this.preçoTextBox);
            this.Controls.Add(data_LançamentoLabel);
            this.Controls.Add(this.data_LançamentoDateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.roupasBindingNavigator);
            this.Name = "frmForm";
            this.Text = "Casdastro de Roupas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRoupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roupasBindingNavigator)).EndInit();
            this.roupasBindingNavigator.ResumeLayout(false);
            this.roupasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetRoupa dataSetRoupa;
        private System.Windows.Forms.BindingSource roupasBindingSource;
        private DataSetRoupaTableAdapters.RoupasTableAdapter roupasTableAdapter;
        private DataSetRoupaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator roupasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton roupasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLançamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox tamanhoTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox preçoTextBox;
        private System.Windows.Forms.DateTimePicker data_LançamentoDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

