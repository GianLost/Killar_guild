using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Killar_Guild.Models
{
    public class PostService
    {
        public int CreatePost(Post novoPost)
        {
            using (var context = new Killar_GuildContext())
            {
                context.Add (novoPost);
                context.SaveChanges();
                return novoPost.Id;
            }
        }

        public ICollection<Post> GetPosts()
        {
            using (var context = new Killar_GuildContext())
            {
                ICollection<Post> result = context.Posts.ToList();

                return result;
            }
        }

        public void UpdPost(Post post)
        {
            using (var context = new Killar_GuildContext())
            {
                Post registro = context.Posts.Find(post.Id);

                registro.Texto = post.Texto;
                registro.Titulo = post.Titulo;
                registro.DataPost = post.DataPost;

                context.SaveChanges();
            }
        }

        public void DeletePost(int id)
        {
            using (var context = new Killar_GuildContext())
            {
                Post registro = context.Posts.Find(id);
                context.Posts.Remove (registro);
                context.SaveChanges();
            }
        }

        public ICollection<Post> GetPostsFull()
        {
            using (var context = new Killar_GuildContext())
            {
                IQueryable<Post> consulta = context.Posts.Include(p => p.Comentarios).OrderByDescending(p => p.DataPost);

                return consulta.ToList();
            }
        }

        public Post GetPostDetail(int id)
        {
            using (var context = new Killar_GuildContext())
            {
                Post registro = context.Posts.Where(p => p.Id == id).SingleOrDefault();
                return registro;
            }
        }
    }
}
