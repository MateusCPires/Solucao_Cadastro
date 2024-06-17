using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmForm : Form
    {
        public frmForm()
        {
            InitializeComponent();
        }

        private void pessoa_dsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roupasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetRoupa);

        }

        private void pessoa_dsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.roupasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetRoupa);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetRoupa.Roupas'. Você pode movê-la ou removê-la conforme necessário.
            this.roupasTableAdapter.Fill(this.dataSetRoupa.Roupas);
            // TODO: esta linha de código carrega dados na tabela 'dataSetRoupa.Pessoa_ds'. Você pode movê-la ou removê-la conforme necessário.
            this.roupasTableAdapter.Fill(this.dataSetRoupa.Roupas);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar este item?", "Excluindo item...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                roupasBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSetRoupa);
            }
        }

        private void roupasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roupasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetRoupa);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.roupasTableAdapter.Fill(this.dataSetRoupa.Roupas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}