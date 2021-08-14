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
        //comentario
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }
    }
}
