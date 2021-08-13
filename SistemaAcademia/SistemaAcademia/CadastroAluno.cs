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
        //Modalidade _modalidade;
        public CadastroAluno(Aluno aluno)
        {          
            InitializeComponent();
            _aluno = aluno;
         //   _modalidade = modalidade;
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            txtNomeAluno.DataBindings.Add("Text", _aluno, "Nome");
            mbxCpfAluno.DataBindings.Add("Text", _aluno, "Cpf");
            mbxTelefoneAluno.DataBindings.Add("Text", _aluno, "Telefone");
            //cbxModalidade.DataBindings.Add("Text", _aluno, "Modalidade");
            cbxPagamento.Checked = _aluno.Pagou == "SIM";
           
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cbxPagamento_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxPagamento.Checked)
            {
                _aluno.Pagou = "SIM";
            }

            else
            {
                _aluno.Pagou = "NÃO";
            }
        }

        private void cbxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            _aluno.Modalidade = cbxModalidade.SelectedItem as Modalidade;
        }
    }
}
