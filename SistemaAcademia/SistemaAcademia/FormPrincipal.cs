using SistemaAcademia.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
        }

        private void btnNovoProfessor_Click(object sender, EventArgs e)
        {
            var _professor = new Professor();
            if (sender == btnNovoProfessor)
            {
                pessoaBindingSource.Add(_professor);
                pessoaBindingSource.MoveLast();
            }
            if (pessoaBindingSource.Current == null) return;

            using (var form = new CadastroProfessor(pessoaBindingSource.Current as Professor))
            {
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    var professor = pessoaBindingSource.Current as Professor;

                    using (var db = new AppDBContext())
                    {
                        if (db.Entry(professor).State == EntityState.Detached)
                        {
                            db.Set<Pessoa>().Attach(professor);
                        }
                        if (professor.Id == 0)
                        {
                            db.Entry(professor).State = EntityState.Added;
                            MessageBox.Show("Professor cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            db.Entry(professor).State = EntityState.Modified;
                            MessageBox.Show("Professor editado com suceso!", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        if (db.SaveChanges() > 0)
                        {
                            dataGridView1.Refresh();
                        }
                    }
                }
            }
        }
        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            var _professor = pessoaBindingSource.Current as Professor;
            if (_professor == null) return;
            using (var db = new AppDBContext())
            {
                if (MessageBox.Show("Deseja excluir mesmo esse professor?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (db.Entry(_professor).State == EntityState.Detached)
                    {
                        db.Set<Pessoa>().Attach(_professor);
                    }

                    db.Entry(_professor).State = EntityState.Deleted;
                    if (db.SaveChanges() > 0)
                    {
                        pessoaBindingSource.Remove(_professor);
                        dataGridView1.Refresh();
                    }
                }
            }
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            var _aluno = new Aluno();
            if (sender == btnNovoAluno)
            {
                pessoaBindingSource1.Add(_aluno);
                pessoaBindingSource1.MoveLast();
            }
            if (pessoaBindingSource1.Current == null) return;

            using (var form = new CadastroAluno(pessoaBindingSource1.Current as Aluno))
            {
                if (form.ShowDialog() == DialogResult.Yes)
                {

                    var aluno = pessoaBindingSource1.Current as Aluno;

                    using (var db = new AppDBContext())
                    {
                        if (db.Entry(aluno).State == EntityState.Detached)
                        {
                            db.Set<Pessoa>().Attach(aluno);
                        }
                        if (aluno.Id == 0)
                        {
                            db.Entry(aluno).State = EntityState.Added;
                            MessageBox.Show("aluno cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            db.Entry(aluno).State = EntityState.Modified;
                            MessageBox.Show("Aluno editado com sucesso!", "Edição", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        if (db.SaveChanges() > 0)
                        {
                            dataGridView2.Refresh();
                        }
                    }

                }

            }


        }
        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            var _aluno = pessoaBindingSource1.Current as Aluno;
            if (_aluno == null) return;
            using (var db = new AppDBContext())
            {
                if (MessageBox.Show("Deseja excluir mesmo esse aluno?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                { 

                    if (db.Entry(_aluno).State == EntityState.Detached)
                    {
                        db.Set<Pessoa>().Attach(_aluno);
                    }

                    db.Entry(_aluno).State = EntityState.Deleted;
                    if (db.SaveChanges() > 0)
                    {
                        pessoaBindingSource.Remove(_aluno);
                        dataGridView1.Refresh();
                    }
                }
            }
        }

        private void btnNovoModalidade_Click(object sender, EventArgs e)
        {
            var _modalidade = new Modalidade();
            if (sender == btnNovoModalidade)
            {
                modalidadeBindingSource.Add(_modalidade);
                modalidadeBindingSource.MoveLast();
            }
            if (modalidadeBindingSource.Current == null) return;

            using (var form = new CadastroModalidade(modalidadeBindingSource.Current as Modalidade))
            {
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    var modalidade = modalidadeBindingSource.Current as Modalidade;

                    using (var db = new AppDBContext())
                    {
                        if (db.Entry(modalidade).State == EntityState.Detached)
                        {
                            db.Set<Modalidade>().Attach(modalidade);
                        }
                        if (modalidade.IdModalidade == 0)
                        { 
                            db.Entry(modalidade).State = EntityState.Added;
                            MessageBox.Show("Modalidade salva com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                        {
                            db.Entry(modalidade).State = EntityState.Modified;
                            MessageBox.Show("Modalidade editada com sucesso!", "Edição", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        if (db.SaveChanges() > 0)
                        {
                            dataGridView3.Refresh();
                        }
                    }
                }
            }
        }
        private void btnExcluirModalidade_Click(object sender, EventArgs e)
        {
            var _modalidade = modalidadeBindingSource.Current as Modalidade;
            if (_modalidade == null) return;
            using (var db = new AppDBContext())
            {
                if (MessageBox.Show("Deseja excluir mesmo essa modalidade?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (db.Entry(_modalidade).State == EntityState.Detached)
                    {
                        db.Set<Modalidade>().Attach(_modalidade);
                    }

                    db.Entry(_modalidade).State = EntityState.Deleted;
                    if (db.SaveChanges() > 0)
                    {
                        modalidadeBindingSource.Remove(_modalidade);
                        dataGridView1.Refresh();
                    }
                }
            }
        }

       

       
    }
}
