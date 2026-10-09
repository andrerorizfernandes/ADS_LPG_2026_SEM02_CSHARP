using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBasicos
{
    public partial class Exemplo_03 : System.Web.UI.Page
    {
        const double VALOR_MULHER = 10;
        const double VALOR_HOMEM = 20;
        const double VALOR_CERVEJA = 10;
        const double VALOR_REFRIGERANTE = 6;
        const double VALOR_ESPETO = 8;
 
        private double CalcularVenda()
        {
            var lTotal = 0.0;

            switch (cboSexo.SelectedValue)
            {
                case "M":
                    lTotal += VALOR_HOMEM;
                    break;
                case "F":
                    lTotal += VALOR_MULHER;
                    break;
            }

            lTotal += (Convert.ToInt32(txtQtdCervejas.Text) * VALOR_CERVEJA);
            lTotal += (Convert.ToInt32(txtQtdRefrigerantes.Text) * VALOR_REFRIGERANTE);
            lTotal += (Convert.ToInt32(txtQtdEspetinhos.Text) * VALOR_ESPETO);

            return lTotal;
        }

        private void AcumularTotalGeral(double valor)
        {
            double valorTotal = double.Parse(Session["TotalGeral"].ToString());
            valorTotal += valor;
            Session["TotalGeral"] = valorTotal;
        }

        private void LimparCampos()
        {
            cboSexo.SelectedIndex = 0;
            txtQtdCervejas.Text = "0";
            txtQtdRefrigerantes.Text = "0";
            txtQtdEspetinhos.Text = "0";
        }

        private void ExibirResultados(double valor)
        {
            lblTotalAtual.Text = "Total a pagar: " + valor.ToString();
            lblTotalGeral.Text = "Total geral recebido: " + Session["TotalGeral"];
        }

        private void ZerarResultados()
        {
            lblTotalAtual.Text = "Total a pagar: 0";
            lblTotalGeral.Text = "Total geral recebido: 0";
            Session["TotalGeral"] = 0.0;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["TotalGeral"] = 0.0;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor = CalcularVenda();

            AcumularTotalGeral(valor);
            LimparCampos();
            ExibirResultados(valor);
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            ZerarResultados();
            LimparCampos();
        }
    }
}