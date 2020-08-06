using System;
using System.ComponentModel.DataAnnotations;

namespace Todo.API.Models
{
    public class Tarefa
    {
        [Key]
        public int IdTarefa { get; set; }
        public string Titulo { get; set; }
        public DateTime DataInclusao { get; set; } 
        public bool Concluido { get; set; }
        public string Descricao { get; set; }
        public int TipoTarefa { get; set; }
    }
}
