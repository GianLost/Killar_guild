using Killar_Guild.Models;
using Microsoft.AspNetCore.Mvc;

namespace Killar_Guild.Controllers
{
    public class PostController : Controller
    {
        public IActionResult CadPosts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadPosts(Post novoPost)
        {
            PostService ps = new PostService();
            int novoId = ps.CreatePost(novoPost);
            if (novoId != 0)
            {
                ViewData["Mensagem"] = "Postagem realizada com sucesso";
            }
            else
            {
                ViewData["Mensagem"] = "Falha na Postagem";
            }

            return View();
        }

        public IActionResult ListarPosts()
        {
            PostService ps = new PostService();
            return View(ps.GetPosts());
        }

        public IActionResult UpdatePost(int id)
        {
            Post postEncontrado = new PostService().GetPostDetail(id);
            return View(postEncontrado);
        }

        [HttpPost]
        public IActionResult UpdatePost(Post postEdit)
        {
            new PostService().UpdPost(postEdit);
            return RedirectToAction("ListarPosts");
        }

        public IActionResult DelPost(int id)
        {
            PostService ps = new PostService();
            Post post = ps.GetPostDetail(id);

            return View(post);
        }

        [HttpPost]
        public IActionResult DelPost(int id, string decisao)
        {
            if (decisao == "s")
            {
                PostService service = new PostService();
                service.DeletePost (id);
            }
            return RedirectToAction("ListarPosts");
            
        }
    }
}
