using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBasicos
{
    public partial class Exemplo_01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void MensagemBoasVindas(string Mensagem)
        {
            lblInformacao.Text = Mensagem;
        }

        protected void btnProcessar_Click(object sender, EventArgs e)
        {
            MensagemBoasVindas(txtEntradaDados.Text);
        }
    }
}