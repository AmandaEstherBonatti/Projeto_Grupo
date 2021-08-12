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
    public partial class CadastroProfessor : Form
    {
        Professor _professor;
        public CadastroProfessor(Professor professor)
        {
            InitializeComponent();
            _professor = professor;
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            txtNomeProfessor.DataBindings.Add("Text", _professor, "Nome");
            mbxCpfprofessor.DataBindings.Add("Text", _professor, "Cpf");
            mbxTelefoneProfessor.DataBindings.Add("Text", _professor, "Telefone");
            //cbxTurnoProfessor.DataBindings.Add("Text", _professor, "Turno");
            txtSalarioHora.DataBindings.Add("Text", _professor, "SalarioHora");
        }

        private void btnSalvarProfessor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }

     
    }
}
