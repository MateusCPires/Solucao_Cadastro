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
    public partial class frmConsultaRoupa : Form
    {
        public frmConsultaRoupa()
        {
            InitializeComponent();
        }

        private void ConsultaPessoa_Load(object sender, EventArgs e)
        {
            this.roupasTableAdapter.Fill(this.dataSetRoupa.Roupas);
            lblTexto2.Text = "";
            txtPesquisa2.Visible = false;
            calData1.Visible = false;
            calData2.Visible = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string coluna, procurar, texto, filtro = "";

            coluna = cmbColuna.Text;
            procurar = cmbProcurar.Text;
            texto = txtPesquisa1.Text;

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
            else if (procurar == "Entre")
            {
                filtro += " like '%/ " + texto + "'";
            }
        }

        private void cmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColuna.Text == "Nome" || cmbColuna.Text == "Marca" || cmbColuna.Text == "Tamanho" || cmbColuna.Text == "Cor" || cmbColuna.Text == "Material")
            {
                txtPesquisa1.Visible = true;
                txtPesquisa2.Visible = false;
                calData1.Visible = false;
                calData2.Visible = false;
                lblTexto1.Text = "Por:";
                lblTexto2.Text = "";
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("Começa com");
                cmbProcurar.Items.Add("Termina com");
                cmbProcurar.Items.Add("Contém");
                cmbProcurar.Items.Add("Igual a");
            }
            else if (cmbColuna.Text == "ID")
            {
                txtPesquisa1.Visible = true;
                txtPesquisa2.Visible = false;
                calData1.Visible = false;
                calData2.Visible = false;
                lblTexto1.Text = "Por:";
                lblTexto2.Text = "";
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("Começa com");
                cmbProcurar.Items.Add("Termina com");
                cmbProcurar.Items.Add("Contém");
                cmbProcurar.Items.Add("Igual a");
            }
            else if (cmbColuna.Text == "Data de Lançamento")
            {
                calData1.Visible = true;
                calData2.Visible = false;
                txtPesquisa1.Visible = false;
                txtPesquisa2.Visible = false;
                lblTexto1.Text = "Data 1:";
                lblTexto2.Text = "";
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("A partir de");   // Específico
                cmbProcurar.Items.Add("Antes de");      // Específico 
                cmbProcurar.Items.Add("Entre");         // Específico 
                cmbProcurar.Items.Add("Igual a");       // Todos têm
            }
        }

        private void cmbProcurar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProcurar.Text == "Todos")
            {
                lblTexto1.Text = "";
                lblTexto2.Text = "";
                txtPesquisa1.Visible = false;
                txtPesquisa2.Visible = false;
                calData1.Visible = false;
                calData2.Visible = false;
            }
            else if (cmbProcurar.Text == "Entre" && cmbColuna.Text == "Data de Lançamento")
            {
                lblTexto1.Text = "Primeira Data:";
                lblTexto2.Text = "Segunda Data:";
                txtPesquisa1.Visible = false;
                txtPesquisa2.Visible = false;
                calData1.Visible = true;
                calData2.Visible = true;
            }
            else if (cmbColuna.Text == "Data de Lançamento")
            {
                lblTexto1.Text = "Primeira Data:";
                lblTexto2.Text = "";
                txtPesquisa1.Visible = false;
                txtPesquisa2.Visible = false;
                calData1.Visible = true;
                calData2.Visible = false;
            }
            else if (cmbProcurar.Text == "Entre" && cmbColuna.Text == "ID")
            {
                lblTexto1.Text = "Primeira ID:";
                lblTexto2.Text = "Segunda ID:";
                txtPesquisa1.Visible = true;
                txtPesquisa2.Visible = true;
                calData1.Visible = false;
                calData2.Visible = false;
            }
            else if (cmbColuna.Text == "ID")
            {
                lblTexto1.Text = "Primeira ID:";
                lblTexto2.Text = "";
                txtPesquisa1.Visible = true;
                txtPesquisa2.Visible = false;
                calData1.Visible = false;
                calData2.Visible = false;
            }
            else
            {
                lblTexto1.Text = "Por:";
                lblTexto2.Text = "";
                txtPesquisa1.Visible = true;
                txtPesquisa2.Visible = false;
                calData1.Visible = false;
                calData2.Visible = false;
            }
        }
    }
}
