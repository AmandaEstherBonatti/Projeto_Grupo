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
    public partial class CadastroModalidade : Form
    {
        Modalidade _modalidade;
        public CadastroModalidade(Modalidade modalidade)
        {
            InitializeComponent();
            _modalidade = modalidade;
        }

        private void CadastroModalidade_Load(object sender, EventArgs e)
        {
            txtNomeModalidade.DataBindings.Add("Text", _modalidade, "Nome");
            txtPrecoHora.DataBindings.Add("Text", _modalidade, "PrecoHora");
            professorBindingSource.DataSource = new AppDBContext().Professores.ToList();
            
        }

        private void btnSalvarModalidade_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selecionarProfessorAtual()
        {
            foreach (var item in cbxProfessorModalidade.Items)
            {
                var professor = item as Professor;

                if (professor is null) return;
                if (_modalidade.Professor.Id == _modalidade.Professor.Id)
                {
                    cbxProfessorModalidade.SelectedItem = item;
                }
            }
        }

        private void cbxProfessorModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            _modalidade.Professor = cbxProfessorModalidade.SelectedItem as Professor;
            selecionarProfessorAtual();
        }
    }
}
