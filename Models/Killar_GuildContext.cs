using Microsoft.EntityFrameworkCore;

//Classe context que herda DBContext para utilização do EFCore.

namespace Killar_Guild.Models
{
    public class Killar_GuildContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=MYSQL8001.site4now.net;Database=db_a8d790_killufo;Uid=a8d790_killufo;Pwd=Ann@1170615"); // String de conexão
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }
    }
}
