using System.Collections.Generic;
using Killar_Guild.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Killar_Guild.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult CadUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadUser(Usuario u)
        {
            UsuarioService us = new UsuarioService();
            us.AddUser (u);
            ViewData["mensagem"] = "Cadastrado com sucesso";
            return RedirectToAction("Login", "Home");
        }

        public IActionResult ListarUser()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.VerificaSeUsuarioEAdmin(this);
            return View(new UsuarioService().ListUser());
        }

        public IActionResult Perfil()
        {
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            //Autenticacao.CheckLogin(this);
            UsuarioService ur = new UsuarioService();
            int IdUserSession = (int) HttpContext.Session.GetInt32("IdUsuario");
            List<Usuario> ListaUsers = ur.Profile(IdUserSession);
            return View(ListaUsers);
        }

        public IActionResult EditarUser(int id)
        {
            Autenticacao.CheckLogin(this);
            Usuario usuarioEncontrado = new UsuarioService().ListUser(id);
            return View(usuarioEncontrado);
        }

        [HttpPost]
        public IActionResult EditarUser(Usuario userEdit)
        {
            Autenticacao.CheckLogin(this);
            new UsuarioService().EditUser(userEdit);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ExcluirUser(int id)
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                Autenticacao.CheckLogin(this);
                UsuarioService us = new UsuarioService();
                Usuario userEncontrado = us.SearchForId(id);
                return View(userEncontrado);
            }
        }

        [HttpPost]
        public IActionResult ExcluirUser(string decisao, Usuario u)
        {
            UsuarioService us = new UsuarioService();
            Autenticacao.CheckLogin(this);
            if (decisao == "Excluir")
            {
                us.DelUser(u.Id);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Comunidade()
        {
            Autenticacao.CheckLogin(this);
            PostService ps = new PostService();
            ICollection<Post> lista = ps.GetPostsFull();
            return View(lista);
        }

        public IActionResult QuemSomos()
        {
            return View();
        }

        public IActionResult NeedAdmin()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
