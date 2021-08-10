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
    }
}
