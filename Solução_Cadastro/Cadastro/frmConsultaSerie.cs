using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Cadastro
{
    public partial class frmConsultaSerie : Form
    {
        public frmConsultaSerie()
        {
            InitializeComponent();
        }

        private void ConsultaPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetSeries.Series'. Você pode movê-la ou removê-la conforme necessário.
            this.seriesTableAdapter.Fill(this.dataSetSeries.Series);
            lblTexto2.Text = "";
            txtPesquisa2.Visible = false;
            calData1.Visible = false;
            calData2.Visible = false;
        }


    private void btnFiltrar_Click(object sender, EventArgs e)
        {
        string coluna, procurar, texto, texto2, filtro = "";

        coluna = cmbColuna.Text;
        procurar = cmbProcurar.Text;
        texto = txtPesquisa1.Text;
        texto2 = txtPesquisa2.Text;

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
            float valor;
            if (float.TryParse(texto, NumberStyles.Float, CultureInfo.GetCultureInfo("pt-BR"), out valor)) // pt-BR para Português do Brasil, ajuste conforme a cultura dos dados recebidos
            {
                filtro += " = " + valor.ToString(CultureInfo.InvariantCulture); // Usando InvariantCulture para garantir ponto como separador decimal no filtro
            }
            else
            {
                MessageBox.Show("O valor para 'Igual a' deve ser um número válido.");
                return; // Sai do método sem aplicar o filtro
            }
        }
        else if (procurar == "Entre")
        {
            float valor1, valor2;
            if (float.TryParse(texto, NumberStyles.Float, CultureInfo.GetCultureInfo("pt-BR"), out valor1) &&
                float.TryParse(texto2, NumberStyles.Float, CultureInfo.GetCultureInfo("pt-BR"), out valor2))
            {
                filtro += " >= " + valor1.ToString(CultureInfo.InvariantCulture) + " AND " + coluna + " <= " + valor2.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Os valores para 'Entre' devem ser números válidos.");
                return; // Sai do método sem aplicar o filtro
            }
        }

        seriesBindingSource.Filter = filtro;
    }




    private void cmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColuna.Text == "NOME" || cmbColuna.Text == "DESCRICAO" || cmbColuna.Text == "CLASSIFICACAO")
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
            }
            else if (cmbColuna.Text == "ID" || cmbColuna.Text == "NOTAS")
            {
                txtPesquisa1.Visible = true;
                txtPesquisa2.Visible = false;
                calData1.Visible = false;
                calData2.Visible = false;
                lblTexto1.Text = "Por:";
                lblTexto2.Text = "";
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("Contém");
                cmbProcurar.Items.Add("Entre");
                cmbProcurar.Items.Add("Igual a");
            }
            else if (cmbColuna.Text == "DATALANCAMENTO")
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
            else if (cmbProcurar.Text == "Entre" && cmbColuna.Text == "DATALANCAMENTO")
            {
                lblTexto1.Text = "De:";
                lblTexto2.Text = "Até:";
                txtPesquisa1.Visible = false;
                txtPesquisa2.Visible = false;
                calData1.Visible = true;
                calData2.Visible = true;
            }
            else if (cmbColuna.Text == "DATALANCAMENTO")
            {
                lblTexto1.Text = "Por:";
                lblTexto2.Text = "";
                txtPesquisa1.Visible = false;
                txtPesquisa2.Visible = false;
                calData1.Visible = true;
                calData2.Visible = false;
            }
            else if (cmbProcurar.Text == "Entre" && cmbColuna.Text == "ID")
            {
                lblTexto1.Text = "De:";
                lblTexto2.Text = "Até:";
                txtPesquisa1.Visible = true;
                txtPesquisa2.Visible = true;
                calData1.Visible = false;
                calData2.Visible = false;
            }
            else if (cmbColuna.Text == "ID")
            {
                lblTexto1.Text = "Por:";
                lblTexto2.Text = "";
                txtPesquisa1.Visible = true;
                txtPesquisa2.Visible = false;
                calData1.Visible = false;
                calData2.Visible = false;
            }
            else if (cmbProcurar.Text == "Entre" && cmbColuna.Text == "NOTAS")
            {
                lblTexto1.Text = "De:";
                lblTexto2.Text = "Até:";
                txtPesquisa1.Visible = true;
                txtPesquisa2.Visible = true;
                calData1.Visible = false;
                calData2.Visible = false;
            }
            else if (cmbColuna.Text == "NOTAS")
            {
                lblTexto1.Text = "Por:";
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
