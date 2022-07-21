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
    }
}