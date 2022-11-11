using Microsoft.EntityFrameworkCore;

//Classe context que herda DBContext para utilização do EFCore.

namespace Killar_Guild.Models
{
    public class Killar_GuildContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=dbkillarguild;Uid=root;"); // String de conexão
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }
    }
}
