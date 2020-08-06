using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.API.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}
