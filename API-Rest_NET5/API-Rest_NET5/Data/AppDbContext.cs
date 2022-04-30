using API_Rest_NET5.Models;
using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //  optionsBuilder.UseLazyLoadingProxies();
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder
                .Entity<Endereco>() //define que a entidade
                .HasOne(endereco => endereco.Cinema) //tenha um cinema
                .WithOne(cinema => cinema.Endereco) //e o cinema acima tem um endereco
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId);// e agora define a referencia a chave estrangeira
        }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}