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

        }

        private void btnSalvarModalidade_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
