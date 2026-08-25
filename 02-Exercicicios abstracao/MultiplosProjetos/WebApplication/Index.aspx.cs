using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Index : System.Web.UI.Page
    {
        private void CadastrarProfessor(string nome, string disciplina, int cargaHoraria)
        {
            Professor prof = new Professor();
            prof.Nome = nome;
            prof.Disciplina = disciplina;
            prof.CargaHoraria = cargaHoraria;
            lblResultado.Text =
                $"Professor {prof.Nome} cadastrado com sucesso!<br />" +
                $"Disciplina: {prof.Disciplina}<br />" +
                $"Carga Horária: {prof.CargaHoraria} horas.";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarProfessor(
                txtNome.Text, 
                txtDisciplina.Text, 
                int.Parse(txtCargaHoraria.Text));
        }
    }
}