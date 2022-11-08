using Killar_Guild.Models;
using Microsoft.AspNetCore.Mvc;

namespace Killar_Guild.Controllers
{
    public class PostController : Controller
    {
        public IActionResult CadPosts()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult CadPosts(Post novoPost)
        {
            Autenticacao.CheckLogin(this);
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

            return RedirectToAction("Comunidade", "Usuario");
        }

        public IActionResult ListarPosts()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.VerificaSeUsuarioEAdmin(this);
            PostService ps = new PostService();
            return View(ps.GetPosts());
        }

        public IActionResult UpdatePost(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.VerificaSeUsuarioEAdmin(this);
            Post postEncontrado = new PostService().GetPostDetail(id);
            return View(postEncontrado);
        }

        [HttpPost]
        public IActionResult UpdatePost(Post postEdit)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.VerificaSeUsuarioEAdmin(this);
            new PostService().UpdPost(postEdit);
            return RedirectToAction("ListarPosts");
        }

        public IActionResult DelPost(int id)
        {
            Autenticacao.CheckLogin(this);
            PostService ps = new PostService();
            Post post = ps.GetPostDetail(id);

            return View(post);
        }

        [HttpPost]
        public IActionResult DelPost(int id, string decisao)
        {
            if (decisao == "s")
            {
                Autenticacao.CheckLogin(this);
                PostService service = new PostService();
                service.DeletePost (id);
            }
            return RedirectToAction("ListarPosts");
            
        }
    }
}
