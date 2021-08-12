using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademia.Dominio
{
    public class Professor : Pessoa
    {
        public String Turno { get; set; }

        public double SalarioHora { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
