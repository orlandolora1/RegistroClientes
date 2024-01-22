using RegistroDeClientes.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RegistroDeClientes.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> Opcions) : base(Opcions) { }
        public DbSet<Clientes> Clientes { get; set; }
    }
}
