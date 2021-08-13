using SistemaAcademia.Dominio;
using SistemaAcademia.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using (var db = new AppDBContext())
            {
                pessoaBindingSource.DataSource = db.Professores.ToList();
                pessoaBindingSource1.DataSource = db.Alunos.ToList();
                modalidadeBindingSource.DataSource = db.Modalidades.ToList();
            }
        }

        private void btnNovoProfessor_Click(object sender, EventArgs e)
        {
            if (sender == btnNovoProfessor)
            {
                pessoaBindingSource.Add(new Professor());
                pessoaBindingSource.MoveLast();
            }
            var professor = pessoaBindingSource.Current as Professor;
            if (pessoaBindingSource.Current == null) return;

            var temporario = new Professor();
            temporario = professor.Clone();

            using (var form = new CadastroProfessor(temporario))
            {
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    professor.PegarDadosDe(temporario);

                    if (new ProfessorRepository().Save(professor) > 1)
                    {
                        dgvProfessor.Refresh();
                    }
                }
                else
                {
                    form.Close();
                }
            }
        }
        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            var professor = pessoaBindingSource.Current as Professor;
            if (professor == null) return;
            using (var db = new AppDBContext())
            {
                if (MessageBox.Show("Deseja excluir mesmo esse professor?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                if (new ProfessorRepository().Delete(professor) > 0)
                {
                    pessoaBindingSource.Remove(professor);
                    dgvProfessor.Refresh();
                }
            }
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            if (sender == btnNovoAluno)
            {
                pessoaBindingSource1.Add(new Aluno());
                pessoaBindingSource1.MoveLast();
            }
            var aluno = pessoaBindingSource1.Current as Aluno;
            if (pessoaBindingSource1.Current == null) return;

            var temporario = new Aluno();
            temporario = aluno.Clone();

            using (var form = new CadastroAluno(temporario))
            {
                if (form.ShowDialog() == DialogResult.Yes)
                {

                    aluno.PegarDadosDe(temporario);
                    if (new AlunoRepository().Save(aluno) > 1)
                    {
                        dgvAluno.Refresh();
                    }
                }
            }
        }
        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            var aluno = pessoaBindingSource1.Current as Aluno;
            if (aluno == null) return;
            using (var db = new AppDBContext())
            {
                if (MessageBox.Show("Deseja excluir mesmo esse aluno?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                if (new AlunoRepository().Delete(aluno) > 0)
                {
                    pessoaBindingSource.Remove(aluno);
                    dgvAluno.Refresh();
                }
            }
        }

        private void btnNovoModalidade_Click(object sender, EventArgs e)
        {
            if (sender == btnNovoModalidade)
            {
                modalidadeBindingSource.Add(new Modalidade());
                modalidadeBindingSource.MoveLast();
            }
            var modalidade = modalidadeBindingSource.Current as Modalidade;
            if (modalidadeBindingSource.Current == null) return;
            var temporario = new Modalidade();
            temporario = modalidade.Clone();


            using (var form = new CadastroModalidade(temporario))
            {
                modalidade.PegarDadosDe(temporario);
                if (form.ShowDialog() == DialogResult.Yes)
                {

                    if (new ModalidadeRepository().Save(modalidade) > 1)
                    {
                        dgvModalidade.Refresh();
                    }
                }
            }
        }
        private void btnExcluirModalidade_Click(object sender, EventArgs e)
        {
            var modalidade = modalidadeBindingSource.Current as Modalidade;
            if (modalidade == null) return;
            using (var db = new AppDBContext())
            {
                if (MessageBox.Show("Deseja excluir mesmo essa modalidade?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                if (new ModalidadeRepository().Delete(modalidade) > 0)
                {
                    pessoaBindingSource.Remove(modalidade);
                    dgvModalidade.Refresh();
                }
            }
        }
    }
}
