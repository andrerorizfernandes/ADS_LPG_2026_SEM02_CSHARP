using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBasicos
{
    public partial class Exemplo_04 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                PreencherQuantidadeDePacientes();
            }
        }

        public void PreencherQuantidadeDePacientes()
        {
            ddlQuantidade.Items.Clear();
            for (int I = 1; I <= 50; I++)
            {
                ddlQuantidade.Items.Add(I.ToString());
            }
        }

        public List<Paciente> ObterPacientes(int Quantidade)
        {
            if (Quantidade <= 0)
            {
                return null;
            }

            List<Paciente> listaPacientes = new List<Paciente>();

            for (int I = 1; I <= Quantidade; I++)
            {
                Paciente paciente = new Paciente();
                paciente.Codigo = I;
                paciente.Nome = "Paciente " + I.ToString();
                paciente.Telefone = "Telefone " + I.ToString();
                paciente.Email = "Email " + I.ToString();

                listaPacientes.Add(paciente);
            }

            return listaPacientes;
        }

        public DataSet ObterPacientes()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(Request.PhysicalApplicationPath + "Pacientes.xml");

            return dataSet;
        }

        public void Listar()
        {
            int Quantidade = 0;
            if (ddlQuantidade.SelectedValue.Trim() != string.Empty)
            {
                Quantidade = Convert.ToInt32(ddlQuantidade.SelectedValue);
            }

            gvDados.DataSource = ObterPacientes(Quantidade);
            gvDados.DataBind();
        }

        private void SelecionarFormato()
        {
            gvDados.DataSource = null;
            gvDados.DataBind();

            switch (rblFormato.SelectedIndex)
            {
                case 0: {
                    ddlQuantidade.Visible = true;
                    break;    
                }

                case 1: {
                    ddlQuantidade.Visible = false;
                    gvDados.DataSource = ObterPacientes();
                    gvDados.DataBind();
                    break;
                }
            }
        }

        protected void ddlAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }

        protected void rblFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarFormato();
        }
    }
}