using System.Collections.Generic;
using System.Linq;

namespace Killar_Guild.Models
{
    public class ComentarioService
    {
        public int CreateComentario(Comentario coment)
        {
            using (var context = new Killar_GuildContext())
            {
                context.Add (coment);
                context.SaveChanges();
                return coment.Id;
            }
        }

        public List<Comentario> GetComentarios(int idPost)
        {
            using (var context = new Killar_GuildContext())
            {
                return context.Comentarios.Where(c => c.PostId == idPost).ToList();
            }
        }
    }
}
