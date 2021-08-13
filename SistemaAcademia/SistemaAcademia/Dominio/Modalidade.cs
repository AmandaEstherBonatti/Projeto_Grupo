using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaAcademia.Dominio
{
    public class Modalidade : IMensalidade
    {
        [Key]
        public int IdModalidade { get; set; }
        public virtual Professor Professor { get; set; }

        public int VezesSemana { get; set; }

        public double PrecoHora { get; set; }

        public String Nome { get; set; }

        public Modalidade Clone()
        {
            var modalidade = new Modalidade()
            {
                IdModalidade = this.IdModalidade,
                Professor = this.Professor,
                VezesSemana = this.VezesSemana,
                PrecoHora = this.PrecoHora,
                Nome = this.Nome
            };

            return modalidade;
        }

        public void PegarDadosDe(Modalidade modalidade)
        {
            this.IdModalidade = modalidade.IdModalidade;
            this.Professor = modalidade.Professor;
            this.VezesSemana = modalidade.VezesSemana;
            this.PrecoHora = modalidade.PrecoHora;
            this.Nome = modalidade.Nome;
        }

        public double CalcularValor()
        {
            return PrecoHora * VezesSemana * 4;
        }

        public override string ToString()
        {
            return Nome;
        }

    }
}
