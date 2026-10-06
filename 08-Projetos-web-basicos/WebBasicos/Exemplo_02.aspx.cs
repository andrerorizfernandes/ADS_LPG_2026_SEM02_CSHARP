using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBasicos
{
    public partial class Exemplo_02 : System.Web.UI.Page
    {
        protected void showMessageBox(string message)
        {
            string sJavaScript = "<script language=javascript>\n";
            sJavaScript += "alert('" + message + "');";
            sJavaScript += "\n";
            sJavaScript += "</script>";
            ClientScript.RegisterStartupScript(typeof(string), "MessageBox", sJavaScript);
        }

        private void PovoarCores()
        {
            ddlDados.Items.Add(new ListItem("Amarelo", "100"));
            ddlDados.Items.Add(new ListItem("Azul", "200"));
            ddlDados.Items.Add(new ListItem("Verde", "300"));
            ddlDados.Items.Add(new ListItem("Vermelho", "400"));
            ddlDados.Items.Add(new ListItem("Rosa", "500"));
        }

        private void PovoarCarros()
        {
            lbiCarros.Items.Add(new ListItem("Corolla", "1"));
            lbiCarros.Items.Add(new ListItem("Civic", "2"));
            lbiCarros.Items.Add(new ListItem("Polo", "3"));
            lbiCarros.Items.Add(new ListItem("Siena", "4"));
            lbiCarros.Items.Add(new ListItem("Palio", "5"));
            lbiCarros.Items.Add(new ListItem("Celta", "6"));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PovoarCores();
                PovoarCarros();
            }
        }

        protected void RetornarCodigoDaCorCorrespondente()
        {
            lblInformacao.Text = "O código correspondente é: " + ddlDados.SelectedValue.ToString();
        }

        protected void RetornarAceiteDoContrato()
        {
            lblInfo02.Text = string.Empty;

            if (chkAceito.Checked)
            {
                lblInfo02.Text = chkAceito.Text;
            }
        }

        protected void RetornarCarrosSelecionados()
        {
            lblInformacao3.Text = string.Empty;

            foreach (ListItem li in lbiCarros.Items)
            {
                if (li.Selected)
                {
                    lblInformacao3.Text += li.Text + "; ";
                }
            }

            if (lblInformacao3.Text != string.Empty)
            {
                showMessageBox(lblInformacao3.Text);
            }
        }

        protected void ddlDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetornarCodigoDaCorCorrespondente();
        }

        protected void chkAceito_CheckedChanged(object sender, EventArgs e)
        {
            RetornarAceiteDoContrato();
        }

        protected void btnSelecionados_Click(object sender, EventArgs e)
        {
            RetornarCarrosSelecionados();
        }
    }
}