using System;
using Killar_Guild.Models;
using Microsoft.AspNetCore.Mvc;

namespace Killar_Guild.Controllers
{
    public class ComentarioController : Controller
    {
        [HttpPost]
        public IActionResult CadComent(Comentario c)
        {
            Autenticacao.CheckLogin(this);
            ComentarioService service = new ComentarioService();
            c.DataComent = DateTime.Now; //data do comentário é o momento em que ele foi cadastrado
            service.CreateComentario (c);
            return RedirectToAction("Comunidade", "Usuario");
        }
    }
}
