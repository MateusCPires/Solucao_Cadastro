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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            frmForm objForm = new frmForm();
            objForm.Show();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            frmConsultaPessoa objConsultaPessoa = new frmConsultaPessoa();
            objConsultaPessoa.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja deletar este item?", "Excluindo item...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel;
            }
        }
    }
}
