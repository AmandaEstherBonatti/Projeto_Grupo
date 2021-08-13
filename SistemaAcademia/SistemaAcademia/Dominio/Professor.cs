using System;

namespace SistemaAcademia.Dominio
{
    public class Professor : Pessoa
    {
        public String Turno { get; set; }

        public double SalarioHora { get; set; }

        public Professor Clone()
        {
            var professor = new Professor()
            { 
                Id = this.Id,
                Nome = this.Nome,
                Cpf = this.Cpf,
                Telefone = this.Telefone,
                Turno = this.Turno,
                SalarioHora = this.SalarioHora
            };

            return professor;


        }

        public void PegarDadosDe(Professor professor)
        {
            this.Id = professor.Id;
            this.Nome = professor.Nome;
            this.Cpf = professor.Cpf;
            this.Telefone = professor.Telefone;
            this.Turno = professor.Turno;
            this.SalarioHora = professor.SalarioHora;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
