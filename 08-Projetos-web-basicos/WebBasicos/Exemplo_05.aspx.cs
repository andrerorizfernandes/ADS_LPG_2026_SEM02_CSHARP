using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBasicos
{
    public partial class Exemplo_05 : System.Web.UI.Page
    {
        const string STRING_CONEXAO = @"server=127.0.0.1;user=root;password=;database=ads";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDados();
            }
        }

        public void CarregarDados()
        {
            MySqlConnection con = new MySqlConnection(STRING_CONEXAO);
            con.Open();
            MySqlCommand comando = new MySqlCommand("select id, nome, matricula, curso from aluno", con);
            MySqlDataReader dr = comando.ExecuteReader();

            gvDados.DataSource = dr;
            gvDados.DataBind();
        }

        public bool Inserir(Aluno aluno)
        {
            MySqlConnection con = new MySqlConnection(STRING_CONEXAO);
            con.Open();
            MySqlCommand comando = new MySqlCommand("Insert Into aluno(nome, matricula, curso) Values (@Nome, @Matricula, @Curso)", con);
            comando.Parameters.AddWithValue("@Nome", aluno.Nome);
            comando.Parameters.AddWithValue("@Matricula", aluno.Matricula);
            comando.Parameters.AddWithValue("@Curso", aluno.Curso);
            MySqlDataReader dr = comando.ExecuteReader();

            return (dr.RecordsAffected > 0);
        }

        public bool Editar(Aluno aluno)
        {
            MySqlConnection con = new MySqlConnection(STRING_CONEXAO);
            con.Open();
            MySqlCommand comando = new MySqlCommand("Update aluno Set nome = @Nome, matricula = @Matricula, curso = @Curso Where id=@ID", con);
            comando.Parameters.AddWithValue("@Nome", aluno.Nome);
            comando.Parameters.AddWithValue("@Matricula", aluno.Matricula);
            comando.Parameters.AddWithValue("@Curso", aluno.Curso);
            comando.Parameters.AddWithValue("@ID", aluno.Id);
            MySqlDataReader dr = comando.ExecuteReader();

            return (dr.RecordsAffected > 0);
        }

        public bool Excluir(Aluno aluno)
        {
            MySqlConnection con = new MySqlConnection(STRING_CONEXAO);
            con.Open();
            MySqlCommand comando = new MySqlCommand("Delete From aluno Where id=@ID", con);
            comando.Parameters.AddWithValue("@ID", aluno.Id);
            MySqlDataReader dr = comando.ExecuteReader();

            return (dr.RecordsAffected > 0);
        }

        public void InserirAluno()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text;
            aluno.Matricula = txtMatricula.Text;
            aluno.Curso = txtCurso.Text;

            if (Inserir(aluno))
            {
                lblRetornoOperacao.Text = "Aluno adicionado com sucesso";
                txtNome.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                txtCurso.Text = string.Empty;
            }
            else
            {
                lblRetornoOperacao.Text = "Falha ao adicionar aluno";   
            }

            CarregarDados();
        }

        public void EditarAluno()
        {
            Aluno aluno = new Aluno();
            aluno.Id = Convert.ToInt32(txtID.Text);
            aluno.Nome = txtNome.Text;
            aluno.Matricula = txtMatricula.Text;
            aluno.Curso = txtCurso.Text;

            if (Editar(aluno))
            {
                lblRetornoOperacao.Text = "Aluno editado com sucesso";
                txtID.Text = txtID.Text;
                txtNome.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                txtCurso.Text = string.Empty;
            }
            else
            {
                lblRetornoOperacao.Text = "Falha ao editar aluno";
            }

            CarregarDados();
        }

        public void ExcluirAluno()
        {
            Aluno aluno = new Aluno();
            aluno.Id = Convert.ToInt32(txtID.Text);

            if (Excluir(aluno))
            {
                lblRetornoOperacao.Text = "Aluno excluído com sucesso";
                txtID.Text = txtID.Text;
                txtNome.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                txtCurso.Text = string.Empty;
            }
            else
            {
                lblRetornoOperacao.Text = "Falha ao excluir aluno";
            }

            CarregarDados();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            InserirAluno();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            EditarAluno();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirAluno();
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}