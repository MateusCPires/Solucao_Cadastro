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
    public partial class frmConsultaPessoa : Form
    {
        public frmConsultaPessoa()
        {
            InitializeComponent();
        }

        private void ConsultaPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Pessoa_ds'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoa_dsTableAdapter.Fill(this.dataSet1.Pessoa_ds);

        }
    }
}
