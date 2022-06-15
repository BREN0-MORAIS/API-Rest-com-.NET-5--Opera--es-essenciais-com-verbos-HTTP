using API_Rest_NET5.Models;
using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
            //Relação de 1:1
            builder
                .Entity<Endereco>() //define qual a entidade que não tem o id de referência,quantos endereços tem um cinema?
                .HasOne(endereco => endereco.Cinema) //nesse caso só tem 1, mas e o cinema tem quantos endereços?
                .WithOne(cinema => cinema.Endereco) //nesse caso só tem apenas 1, mas quem tem a chave para identificar?
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId);// o  cinema tem a chave.


            //Relação de 1:n
            builder.Entity<Cinema>() //o nosso cinema ele possui o que?
                .HasOne(cinema => cinema.Gerente) // apenas 1 Gerente, e o Gerente possui mais de 1 cinema?
                .WithMany(gerente => gerente.Cinemas) // sim possui varios cinemas, qual é a chave que vai referencia quem?
                .HasForeignKey(cinema => cinema.GerenteId);
            // é o cinema que possui a chave de referencia //continuar apartir da aula (4)
               
                
               
        }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }

    }
}