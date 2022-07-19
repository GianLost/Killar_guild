using System.Collections.Generic;
using System.Linq;
using Killar_Guild.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Killar_Guild.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {
            if (string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        public static bool
        VerificaLoginSenha(string login, string senha, Controller controller)
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                VerificaSeUsuarioAdminExiste (db);
                senha = Criptografia.TextoCriptografado(senha);

                IQueryable<Usuario> UsuarioEncontrado = db.Usuarios.Where(u =>u.LoginNamePub == login && u.SenhaPub == senha);

                List<Usuario> ListaUsuarioEncontrado = UsuarioEncontrado.ToList();

                if (ListaUsuarioEncontrado.Count == 0)
                {
                    return false;
                }
                else
                {
                    controller.HttpContext.Session.SetInt32("IdUsuario",ListaUsuarioEncontrado[0].Id);
                    controller.HttpContext.Session.SetString("login",ListaUsuarioEncontrado[0].LoginNamePub);
                    controller.HttpContext.Session.SetString("nome", ListaUsuarioEncontrado[0].Nome);
                    controller.HttpContext.Session.SetInt32("tipo", ListaUsuarioEncontrado[0].Tipo);

                    return true;
                }
            }
        }

        public static void VerificaSeUsuarioAdminExiste(Killar_GuildContext db)
        {
            IQueryable<Usuario> UsuarioEncontrado =
                db.Usuarios.Where(u => u.LoginNamePub == "admin");

            if (UsuarioEncontrado.ToList().Count == 0)
            {
                //crio usuario admin automático casa não exista um
                Usuario admin = new Usuario();
                admin.Nome = "Administrador";
                admin.LoginNamePub = "admin";
                admin.SenhaPub = Criptografia.TextoCriptografado("123");
                admin.Tipo = Usuario.ADMIN;

                db.Usuarios.Add (admin);
                db.SaveChanges();
            }
        }

        public static void VerificaSeUsuarioEAdmin(Controller controller)
        {
            if (!(controller.HttpContext.Session.GetInt32("tipo") == Usuario.ADMIN))
            {
                controller.Request.HttpContext.Response.Redirect("/Usuario/NeedAdmin");
            }
        }
    }
}