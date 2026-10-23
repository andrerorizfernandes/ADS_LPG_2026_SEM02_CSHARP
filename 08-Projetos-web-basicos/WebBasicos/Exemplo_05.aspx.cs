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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDados();
            }
        }

        public void CarregarDados()
        {
            MySqlCommand comando = new MySqlCommand("select id, nome, matricula, curso from aluno", Conexao());
            MySqlDataReader dr = comando.ExecuteReader();

            gvDados.DataSource = dr;
            gvDados.DataBind();
        }

        public MySqlConnection Conexao()
        {
            const string STRING_CONEXAO = @"server=127.0.0.1;user=root;password=;database=ads";

            MySqlConnection con = new MySqlConnection(STRING_CONEXAO);
            con.Open();
            return con;
        }

        public bool InserirAluno(Aluno aluno)
        {
            MySqlCommand comando = new MySqlCommand("Insert Into aluno(nome, matricula, curso) Values (@Nome, @Matricula, @Curso)", Conexao());
            comando.Parameters.AddWithValue("@Nome", aluno.Nome);
            comando.Parameters.AddWithValue("@Matricula", aluno.Matricula);
            comando.Parameters.AddWithValue("@Curso", aluno.Curso);
            MySqlDataReader dr = comando.ExecuteReader();

            return (dr.RecordsAffected > 0);
        }

        public bool EditarAluno(Aluno aluno)
        {
            MySqlCommand comando = new MySqlCommand("Update aluno Set nome = @Nome, matricula = @Matricula, curso = @Curso Where id=@ID", Conexao());
            comando.Parameters.AddWithValue("@Nome", aluno.Nome);
            comando.Parameters.AddWithValue("@Matricula", aluno.Matricula);
            comando.Parameters.AddWithValue("@Curso", aluno.Curso);
            comando.Parameters.AddWithValue("@ID", aluno.Id);
            MySqlDataReader dr = comando.ExecuteReader();

            return (dr.RecordsAffected > 0);
        }

        public bool ExcluirAluno(Aluno aluno)
        {
            MySqlCommand comando = new MySqlCommand("Delete From aluno Where id=@ID", Conexao());
            comando.Parameters.AddWithValue("@ID", aluno.Id);
            MySqlDataReader dr = comando.ExecuteReader();

            return (dr.RecordsAffected > 0);
        }

        private void LimparCampos()
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtMatricula.Text = string.Empty;
            txtCurso.Text = string.Empty;
        }

        public void Inserir()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text;
            aluno.Matricula = txtMatricula.Text;
            aluno.Curso = txtCurso.Text;

            lblRetornoOperacao.Text = "Falha ao adicionar aluno";
            if (InserirAluno(aluno))
            {
                LimparCampos();
                lblRetornoOperacao.Text = "Aluno adicionado com sucesso";
            }

            CarregarDados();
        }

        public void Editar()
        {
            Aluno aluno = new Aluno();
            aluno.Id = Convert.ToInt32(txtID.Text);
            aluno.Nome = txtNome.Text;
            aluno.Matricula = txtMatricula.Text;
            aluno.Curso = txtCurso.Text;

            lblRetornoOperacao.Text = "Falha ao editar aluno";
            if (EditarAluno(aluno))
            {
                LimparCampos();
                lblRetornoOperacao.Text = "Aluno editado com sucesso";
            }

            CarregarDados();
        }

        public void Excluir()
        {
            Aluno aluno = new Aluno();
            aluno.Id = Convert.ToInt32(txtID.Text);

            lblRetornoOperacao.Text = "Falha ao excluir aluno";
            if (ExcluirAluno(aluno))
            {
                LimparCampos();
                lblRetornoOperacao.Text = "Aluno excluído com sucesso";
            }

            CarregarDados();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}