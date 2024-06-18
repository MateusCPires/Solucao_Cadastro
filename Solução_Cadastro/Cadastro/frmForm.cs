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
            this.seriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetSeries);

        }

        private void pessoa_dsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.seriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetSeries);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetSeries.Series'. Você pode movê-la ou removê-la conforme necessário.
            this.seriesTableAdapter.Fill(this.dataSetSeries.Series);
            // TODO: esta linha de código carrega dados na tabela 'dataSetSeries.Series'. Você pode movê-la ou removê-la conforme necessário.
            this.seriesTableAdapter.Fill(this.dataSetSeries.Series);
            // TODO: esta linha de código carrega dados na tabela 'dataSetSeries.Pessoa_ds'. Você pode movê-la ou removê-la conforme necessário.
            this.seriesTableAdapter.Fill(this.dataSetSeries.Series);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar este item?", "Excluindo item...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                seriesBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSetSeries);
            }
        }

        private void SeriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetSeries);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.seriesTableAdapter.Fill(this.dataSetSeries.Series);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void seriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetSeries);

        }
    }
}