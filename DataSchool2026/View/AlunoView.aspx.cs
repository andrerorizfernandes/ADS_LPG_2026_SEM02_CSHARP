using Bll;
using Pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class AlunoView : System.Web.UI.Page
    {
        private AlunoBll _alunoBLL;

        public AlunoView()
        {
            _alunoBLL = new AlunoBll();
        }

        protected void Alerta(string message)
        {
            string sJavaScript = "<script language=javascript>\n";
            sJavaScript += "alert('" + message + "');";
            sJavaScript += "\n";
            sJavaScript += "</script>";
            ClientScript.RegisterStartupScript(typeof(string), "MessageBox", sJavaScript);
        }

        private bool Inserir()
        {
            Aluno aluno = new Aluno();
            aluno.Cpf = txtNovoCpf.Text;
            aluno.Idade = Convert.ToInt32(txtNovoIdade.Text);
            aluno.Nome = txtNovoNome.Text;
            aluno.Sexo = txtNovoSexo.Text;

            return _alunoBLL.InserirAluno(aluno);
        }

        private bool Excluir(int linhaDoGrid)
        {
            Aluno aluno = new Aluno();
            Label lblCodAluno = gvdAluno.Rows[linhaDoGrid].FindControl("lblCodAluno") as Label;
            if (lblCodAluno != null)
            {
                aluno.CodigoAluno = Convert.ToInt32(lblCodAluno.Text);
            }

            return _alunoBLL.ExcluirAluno(aluno);
        }

        private void PrepararParaEdicao(int linhaDoGrid)
        {
            gvdAluno.EditIndex = linhaDoGrid;
            Lib.ExibirDados(_alunoBLL, gvdAluno);
        }

        private bool Editar(int linhaDoGrid)
        {
            Aluno aluno = new Aluno();
            
            Label lblCodAluno = gvdAluno.Rows[linhaDoGrid].FindControl("lblCodAluno") as Label;
            if (lblCodAluno != null)
            {
                aluno.CodigoAluno = Convert.ToInt32(lblCodAluno.Text);
            }

            TextBox txtNome = gvdAluno.Rows[linhaDoGrid].FindControl("txtNome") as TextBox;
            if (txtNome != null)
            {
                aluno.Nome = txtNome.Text;
            }

            TextBox txtCpf = gvdAluno.Rows[linhaDoGrid].FindControl("txtCpf") as TextBox;
            if (txtCpf != null)
            {
                aluno.Cpf = txtCpf.Text;
            }

            TextBox txtSexo = gvdAluno.Rows[linhaDoGrid].FindControl("txtSexo") as TextBox;
            if (txtSexo != null)
            {
                aluno.Sexo = txtSexo.Text;
            }

            TextBox txtIdade = gvdAluno.Rows[linhaDoGrid].FindControl("txtIdade") as TextBox;
            if (txtIdade != null)
            {
                aluno.Idade = Convert.ToInt32(txtIdade.Text);
            }

            gvdAluno.EditIndex = -1;
            return _alunoBLL.EditarAluno(aluno);
        }

        private void LimparCampos()
        {
            txtNovoCpf.Text = string.Empty;
            txtNovoIdade.Text = string.Empty;
            txtNovoNome.Text = string.Empty;
            txtNovoSexo.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Lib.ExibirDados(_alunoBLL, gvdAluno);
            }
        }

        protected void gvdAluno_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvdAluno.EditIndex = -1;
            Lib.ExibirDados(_alunoBLL, gvdAluno);
        }

        protected void gvdAluno_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var Mensagem = "Falha ao excluir aluno.";

            if (Excluir(e.RowIndex))
            {
                Lib.ExibirDados(_alunoBLL, gvdAluno);
                Mensagem = "Aluno excuir com sucesso";
            }

            Alerta(Mensagem);
        }

        protected void gvdAluno_RowEditing(object sender, GridViewEditEventArgs e)
        {
            PrepararParaEdicao(e.NewEditIndex);
        }

        protected void gvdAluno_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var Mensagem = "Falha ao editar aluno.";

            if (Editar(e.RowIndex))
            {
                LimparCampos();
                Lib.ExibirDados(_alunoBLL, gvdAluno);
                Mensagem = "Aluno editado com sucesso";
            }

            Alerta(Mensagem);
        }

        protected void Insert(object sender, EventArgs e)
        {
            var Mensagem = "Falha ao inserir aluno.";

            if (Inserir())
            {
                LimparCampos();
                Lib.ExibirDados(_alunoBLL, gvdAluno);
                Mensagem = "Aluno inserido com sucesso";
            }

            Alerta(Mensagem);
        }
    }
}