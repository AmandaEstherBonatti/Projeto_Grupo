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
            //cbxModalidade.DataBindings.Add("Text", _aluno, "Modalidade");
            cbxPagamento.DataBindings.Add("Text", _aluno, "Pagou");
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
