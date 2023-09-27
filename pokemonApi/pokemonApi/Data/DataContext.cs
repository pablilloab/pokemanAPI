using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace pokemonApi.Data
{
    public class DataContext : DbContext
    {
        //paso las opciones al constructor base de DbContext
        //Esta opcion se necesita para crear el db context con 'Add-Migration InitialCreate' y 'Update-Database'
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }

        //declaración de tablas, se usa Dbset<Model de tabla creado en Models>
        public DbSet<Category> Cotegories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<PokemonOwner> PokemonOwners { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        //declaracion de tablas n*n (relacion muchos a muchos) - HasKey sobre la tabla nn haciendo new con sus claves primarias
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //creo el builder para la tabla nn y le digo como es la relacion identificando sus FK y el sentido 

            //POKEMON-CATEGORIES
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonCategories)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(c => c.Category)
                .WithMany(pc => pc.PokemonCategories)
                .HasForeignKey(c => c.CategoryId);

            //POKEMON-OWNERS
            modelBuilder.Entity<PokemonOwner>()
                .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Pokemon)
                .WithMany(po => po.PokemonOwners)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(o => o.Owner)
                .WithMany(po => po.PokemonOwners)
                .HasForeignKey(o => o.OwnerId);
        }



    }
}
