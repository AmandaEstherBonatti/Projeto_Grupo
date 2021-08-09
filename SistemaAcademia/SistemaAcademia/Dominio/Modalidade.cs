using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademia.Dominio
{
    public class Modalidade : IMensalidade
    {
        [Key]
        public int IdModalidade { get; set; }
        public Professor Professor { get; set; }

        public int VezesSemana { get; set; }

        public double PrecoHora { get; set; }

        public String Nome { get; set; }

        public double CalcularValor()
        {
            return PrecoHora * VezesSemana * 4;
        }
    }
}
