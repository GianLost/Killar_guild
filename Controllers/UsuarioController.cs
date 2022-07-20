using Killar_Guild.Models;
using Microsoft.AspNetCore.Mvc;

namespace Killar_Guild.Controllers
{
    public class UsuarioController : Controller
    {

        public IActionResult CadUser()
        {
            //Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult CadUser(Usuario u)
        {
            //Autenticacao.CheckLogin(this);
            UsuarioService us = new UsuarioService();
            us.AddUser (u);
            ViewData["mensagem"] = "Cadastrado com sucesso";
            return RedirectToAction("Login", "Home" );
        }

        public IActionResult ListarUser()
        {
            //Autenticacao.CheckLogin(this);
            //Autenticacao.VerificaSeUsuarioEAdmin(this);
            return View(new UsuarioService().ListUser());
        }

        public IActionResult EditarUser(int id)
        {
            //Autenticacao.CheckLogin(this);
            Usuario usuarioEncontrado = new UsuarioService().ListUser(id);
            return View(usuarioEncontrado);
        }

        [HttpPost]
        public IActionResult EditarUser(Usuario userEdit)
        {
            //Autenticacao.CheckLogin(this);
            new UsuarioService().EditUser(userEdit);
            return RedirectToAction("LitstarUser");
        }

    }
}
