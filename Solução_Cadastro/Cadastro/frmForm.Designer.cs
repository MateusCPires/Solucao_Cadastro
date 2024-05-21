
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
            System.Windows.Forms.Label lbl_id_PESSOA;
            System.Windows.Forms.Label lbl_nome;
            System.Windows.Forms.Label lbl_endereço;
            System.Windows.Forms.Label lbl_cidade;
            System.Windows.Forms.Label lbl_email;
            System.Windows.Forms.Label lbl_data_nascimento;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm));
            this.pessoa_dsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pessoa_dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Cadastro.DataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pessoa_dsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txt_id_PESSOA = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_endereço = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_data_nascimento = new System.Windows.Forms.DateTimePicker();
            this.table_pessoa_ds = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoa_dsTableAdapter = new Cadastro.DataSet1TableAdapters.Pessoa_dsTableAdapter();
            this.tableAdapterManager = new Cadastro.DataSet1TableAdapters.TableAdapterManager();
            lbl_id_PESSOA = new System.Windows.Forms.Label();
            lbl_nome = new System.Windows.Forms.Label();
            lbl_endereço = new System.Windows.Forms.Label();
            lbl_cidade = new System.Windows.Forms.Label();
            lbl_email = new System.Windows.Forms.Label();
            lbl_data_nascimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingNavigator)).BeginInit();
            this.pessoa_dsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_pessoa_ds)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_PESSOA
            // 
            lbl_id_PESSOA.AutoSize = true;
            lbl_id_PESSOA.Font = new System.Drawing.Font("Arial", 9F);
            lbl_id_PESSOA.Location = new System.Drawing.Point(14, 53);
            lbl_id_PESSOA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_id_PESSOA.Name = "lbl_id_PESSOA";
            lbl_id_PESSOA.Size = new System.Drawing.Size(68, 15);
            lbl_id_PESSOA.TabIndex = 1;
            lbl_id_PESSOA.Text = "ID Pessoa:";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new System.Drawing.Font("Arial", 9F);
            lbl_nome.Location = new System.Drawing.Point(14, 74);
            lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new System.Drawing.Size(44, 15);
            lbl_nome.TabIndex = 3;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_endereço
            // 
            lbl_endereço.AutoSize = true;
            lbl_endereço.Font = new System.Drawing.Font("Arial", 9F);
            lbl_endereço.Location = new System.Drawing.Point(14, 95);
            lbl_endereço.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_endereço.Name = "lbl_endereço";
            lbl_endereço.Size = new System.Drawing.Size(63, 15);
            lbl_endereço.TabIndex = 5;
            lbl_endereço.Text = "Endereço:";
            // 
            // lbl_cidade
            // 
            lbl_cidade.AutoSize = true;
            lbl_cidade.Font = new System.Drawing.Font("Arial", 9F);
            lbl_cidade.Location = new System.Drawing.Point(14, 116);
            lbl_cidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_cidade.Name = "lbl_cidade";
            lbl_cidade.Size = new System.Drawing.Size(50, 15);
            lbl_cidade.TabIndex = 7;
            lbl_cidade.Text = "Cidade:";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new System.Drawing.Font("Arial", 9F);
            lbl_email.Location = new System.Drawing.Point(14, 136);
            lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new System.Drawing.Size(42, 15);
            lbl_email.TabIndex = 9;
            lbl_email.Text = "Email:";
            // 
            // lbl_data_nascimento
            // 
            lbl_data_nascimento.AutoSize = true;
            lbl_data_nascimento.Font = new System.Drawing.Font("Arial", 9F);
            lbl_data_nascimento.Location = new System.Drawing.Point(14, 158);
            lbl_data_nascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_data_nascimento.Name = "lbl_data_nascimento";
            lbl_data_nascimento.Size = new System.Drawing.Size(123, 15);
            lbl_data_nascimento.TabIndex = 11;
            lbl_data_nascimento.Text = "Data de Nascimento:";
            // 
            // pessoa_dsBindingNavigator
            // 
            this.pessoa_dsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoa_dsBindingNavigator.BindingSource = this.pessoa_dsBindingSource;
            this.pessoa_dsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoa_dsBindingNavigator.DeleteItem = null;
            this.pessoa_dsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.pessoa_dsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pessoa_dsBindingNavigatorSaveItem});
            this.pessoa_dsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoa_dsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoa_dsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoa_dsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoa_dsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoa_dsBindingNavigator.Name = "pessoa_dsBindingNavigator";
            this.pessoa_dsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoa_dsBindingNavigator.Size = new System.Drawing.Size(991, 31);
            this.pessoa_dsBindingNavigator.TabIndex = 0;
            this.pessoa_dsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // pessoa_dsBindingNavigatorSaveItem
            // 
            this.pessoa_dsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoa_dsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoa_dsBindingNavigatorSaveItem.Image")));
            this.pessoa_dsBindingNavigatorSaveItem.Name = "pessoa_dsBindingNavigatorSaveItem";
            this.pessoa_dsBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.pessoa_dsBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pessoa_dsBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoa_dsBindingNavigatorSaveItem_Click_1);
            // 
            // txt_id_PESSOA
            // 
            this.txt_id_PESSOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_dsBindingSource, "id_PESSOA", true));
            this.txt_id_PESSOA.Location = new System.Drawing.Point(149, 51);
            this.txt_id_PESSOA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_id_PESSOA.Name = "txt_id_PESSOA";
            this.txt_id_PESSOA.Size = new System.Drawing.Size(135, 20);
            this.txt_id_PESSOA.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_dsBindingSource, "nome", true));
            this.txt_nome.Location = new System.Drawing.Point(149, 72);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(135, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_endereço
            // 
            this.txt_endereço.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_dsBindingSource, "endereço", true));
            this.txt_endereço.Location = new System.Drawing.Point(149, 93);
            this.txt_endereço.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_endereço.Name = "txt_endereço";
            this.txt_endereço.Size = new System.Drawing.Size(135, 20);
            this.txt_endereço.TabIndex = 6;
            // 
            // txt_cidade
            // 
            this.txt_cidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_dsBindingSource, "cidade", true));
            this.txt_cidade.Location = new System.Drawing.Point(149, 114);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(135, 20);
            this.txt_cidade.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_dsBindingSource, "email", true));
            this.txt_email.Location = new System.Drawing.Point(149, 134);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(135, 20);
            this.txt_email.TabIndex = 10;
            // 
            // txt_data_nascimento
            // 
            this.txt_data_nascimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoa_dsBindingSource, "data_nascimento", true));
            this.txt_data_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_data_nascimento.Location = new System.Drawing.Point(149, 155);
            this.txt_data_nascimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_data_nascimento.Name = "txt_data_nascimento";
            this.txt_data_nascimento.Size = new System.Drawing.Size(135, 20);
            this.txt_data_nascimento.TabIndex = 12;
            // 
            // table_pessoa_ds
            // 
            this.table_pessoa_ds.AutoGenerateColumns = false;
            this.table_pessoa_ds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_pessoa_ds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.table_pessoa_ds.DataSource = this.pessoa_dsBindingSource;
            this.table_pessoa_ds.Location = new System.Drawing.Point(11, 201);
            this.table_pessoa_ds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.table_pessoa_ds.Name = "table_pessoa_ds";
            this.table_pessoa_ds.RowHeadersWidth = 62;
            this.table_pessoa_ds.RowTemplate.Height = 28;
            this.table_pessoa_ds.Size = new System.Drawing.Size(964, 166);
            this.table_pessoa_ds.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_PESSOA";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_PESSOA";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereço";
            this.dataGridViewTextBoxColumn3.HeaderText = "endereço";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "data_nascimento";
            this.dataGridViewTextBoxColumn6.HeaderText = "data_nascimento";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
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
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 399);
            this.Controls.Add(this.table_pessoa_ds);
            this.Controls.Add(lbl_id_PESSOA);
            this.Controls.Add(this.txt_id_PESSOA);
            this.Controls.Add(lbl_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(lbl_endereço);
            this.Controls.Add(this.txt_endereço);
            this.Controls.Add(lbl_cidade);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(lbl_data_nascimento);
            this.Controls.Add(this.txt_data_nascimento);
            this.Controls.Add(this.pessoa_dsBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmForm";
            this.Text = "Casdastro_de_pessoas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingNavigator)).EndInit();
            this.pessoa_dsBindingNavigator.ResumeLayout(false);
            this.pessoa_dsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_pessoa_ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pessoa_dsBindingSource;
        private DataSet1TableAdapters.Pessoa_dsTableAdapter pessoa_dsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoa_dsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pessoa_dsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txt_id_PESSOA;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_endereço;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.DateTimePicker txt_data_nascimento;
        private System.Windows.Forms.DataGridView table_pessoa_ds;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

