using SistemaAcademia.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class CadastroAluno : Form
    {
        Aluno _aluno;
        public CadastroAluno(Aluno aluno)
        {
            InitializeComponent();
            _aluno = aluno;
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            txtNomeAluno.DataBindings.Add("Text", _aluno, "Nome");
            mbxCpfAluno.DataBindings.Add("Text", _aluno, "Cpf");
            mbxTelefoneAluno.DataBindings.Add("Text", _aluno, "Telefone");
            using (var db = new AppDBContext())
            {
                modalidadeBindingSource.DataSource = db.Modalidades.ToList();
            }
            cbxPagamento.DataBindings.Add("Text", _aluno, "Pagou");
            cbxModalidade.DataBindings.Add("SelectedItem", _aluno, "Modalidade");
            cbxTurno.DataBindings.Add("SelectedItem", _aluno, "Turno");
            //SelecionarModalidadeAtual();
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cbxPagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPagamento.Checked)
            {
                _aluno.Pagou = "SIM";
            }

            else
            {
                _aluno.Pagou = "NÃO";
            }
        }



        private void SelecionarModalidadeAtual()
        {
            foreach (var item in cbxModalidade.Items)
            {
                var modalidade = item as Modalidade;

                if (modalidade is null) return;
                if (modalidade.IdModalidade == _aluno.Modalidade.IdModalidade)
                {
                    cbxModalidade.SelectedItem = item;
                }
            }
        }

    }
}
