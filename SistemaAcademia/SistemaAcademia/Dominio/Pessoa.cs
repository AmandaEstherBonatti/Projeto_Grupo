using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademia.Dominio
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        
        public String Nome { get; set; }

        public String Cpf { get; set; }

        public String Telefone { get; set; }
    }
}
