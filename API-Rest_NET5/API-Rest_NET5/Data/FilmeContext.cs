using API_Rest_NET5.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Rest_NET5.Data
{
    public class FilmeContext:DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options) { }
        public DbSet<Filme> Filmes { get; set; }
    }
}
