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
