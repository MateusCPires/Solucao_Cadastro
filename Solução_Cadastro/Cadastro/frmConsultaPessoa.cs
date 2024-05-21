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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string coluna, procurar, texto, filtro = "";

            coluna = cmbColuna.Text;
            procurar = cmbProcurar.Text;
            texto = txtPesquisa.Text;

            filtro = coluna;

            if (procurar == "Começa com")
            {
                filtro += " like '" + texto + "%'";
            }
            else if (procurar == "Termina com")
            {
                filtro += " like '%" + texto + "'";
            }
            else if (procurar == "Contém")
            {
                filtro += " like '%" + texto + "%'";
            }
            else if (procurar == "Igual a")
            {
                filtro += " like '" + texto + "'";
            }
            // Datas
            else if (procurar == "Dia")
            {
                filtro += " like '" + texto + "/%'";
            }
            else if (procurar == "Mês")
            {
                filtro += " like '%/" + texto + "/%'";
            }
            else if (procurar == "Ano")
            {
                filtro += " like '%/" + texto + "'";
            }
            //Email
            else if (procurar == "Após @")
            {
                filtro += " like '%@" + texto + "'";
            }
        }

        private void cmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColuna.Text == "Nome" || cmbColuna.Text == "Cidade" || cmbColuna.Text == "ID")
            {
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("Começa com");
                cmbProcurar.Items.Add("Termina com");
                cmbProcurar.Items.Add("Contém");
                cmbProcurar.Items.Add("Igual a");
            }
            else if (cmbColuna.Text == "Email")
            {
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("Domínio");
                cmbProcurar.Items.Add("Contém");
                cmbProcurar.Items.Add("Igual a");
            }
            else if (cmbColuna.Text == "Data Nascimento")
            {
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("Dia");       // Específico
                cmbProcurar.Items.Add("Mês");       // Específico
                cmbProcurar.Items.Add("Ano");       // Específico 
                cmbProcurar.Items.Add("Igual a");   // Todos têm
            }
        }
    }
}
