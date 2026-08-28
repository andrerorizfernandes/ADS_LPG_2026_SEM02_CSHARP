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
            Professor prof01 = new Professor();
            prof01.Nome = nome;
            prof01.Disciplina = disciplina;
            prof01.CargaHoraria = cargaHoraria;

            Professor prof02 = new Professor(int.Parse(txtCargaHoraria.Text));
            prof02.Nome = txtNome.Text;
            prof02.Disciplina = txtDisciplina.Text;

            Professor prof03 = new Professor(
                txtNome.Text, 
                txtDisciplina.Text, 
                int.Parse(txtCargaHoraria.Text));     

            lblResultado.Text =
                $"Exemplo sem construtor<br />" +
                $"Professor {prof01.Nome}<br />" +
                $"Disciplina: {prof01.Disciplina}<br />" +
                $"Carga Horária: {prof01.CargaHoraria} horas." +

                $"<br /><br />" +

                $"Exemplo com construtor de carga horária multiplicando por 2<br />" +
                $"Professor {prof02.Nome}<br />" +
                $"Disciplina: {prof02.Disciplina}<br />" +
                $"Carga Horária: {prof02.CargaHoraria} horas." +

                $"<br /><br />" +

                $"Exemplo com construtor preenchendo todos os atributos<br />" +
                $"Professor {prof03.Nome}<br />" +
                $"Disciplina: {prof03.Disciplina}<br />" +
                $"Carga Horária: {prof03.CargaHoraria} horas.";
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