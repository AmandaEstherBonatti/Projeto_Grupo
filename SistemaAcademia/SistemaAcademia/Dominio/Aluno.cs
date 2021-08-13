using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademia.Dominio
{
    public class Aluno : Pessoa
    {
        public String Turno { get; set; }

        public virtual Modalidade Modalidade  { get; set; }

        public String Pagou { get; set; }

        public Aluno Clone()
        {
            var aluno = new Aluno()
            {
                Id = this.Id,
                Nome = this.Nome,
                Cpf = this.Cpf,
                Telefone = this.Telefone,
                Turno = this.Turno,
                Modalidade = this.Modalidade
            };

            return aluno;
        }

        public void PegarDadosDe(Aluno aluno)
        {
            this.Id = aluno.Id;
            this.Nome = aluno.Nome;
            this.Cpf = aluno.Cpf;
            this.Telefone = aluno.Telefone;
            this.Turno = aluno.Turno;
            this.Modalidade = aluno.Modalidade;
        }
    }
}
