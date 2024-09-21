using Ex7_EFCoreListaDeLivros_AT.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex7_EFCoreListaDeLivros_AT.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
