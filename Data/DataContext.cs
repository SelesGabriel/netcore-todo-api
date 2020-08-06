using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.API.Models;

namespace Todo.API.Data
{
    public class DataContext : DbContext
    {
        readonly DbContextOptions options;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            this.options = options;
        }

        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<Tarefa> Tarefas{ get; set; }
    }
}
