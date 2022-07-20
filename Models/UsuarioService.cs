using System.Collections.Generic;
using System.Linq;

namespace Killar_Guild.Models
{
    public class UsuarioService
    {
        public void AddUser(Usuario newUser)
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                newUser.SenhaPub = Criptografia.TextoCriptografado(newUser.SenhaPub);
                newUser.CheckSenhaPub = Criptografia.TextoCriptografado(newUser.CheckSenhaPub);
                db.Usuarios.Add (newUser);
                db.SaveChanges();
            }
        }

        public List<Usuario> ListUser()
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                return db.Usuarios.ToList();
            }
        }

        public Usuario ListUser(int id)
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                return db.Usuarios.Find(id);
            }
        }

        public void EditUser(Usuario userEditado)
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                Usuario u = db.Usuarios.Find(userEditado.Id);
                u.Nome = userEditado.Nome;
                u.DataNasc = userEditado.DataNasc;
                u.WhatsPub = userEditado.WhatsPub;
                u.EmailPub = userEditado.EmailPub;
                u.NickWr = userEditado.NickWr;
                u.LoginNamePub = userEditado.LoginNamePub;
                u.SenhaPub = Criptografia.TextoCriptografado(userEditado.SenhaPub);
                u.CheckSenhaPub = userEditado.CheckSenhaPub;
                u.Lane = userEditado.Lane;
                u.Elo = userEditado.Elo;
                u.Tipo = userEditado.Tipo;

                db.SaveChanges();
            }
        }

        public void DelUser(int id)
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                Usuario foundUser = db.Usuarios.Find(id);
                db.Usuarios.Remove(foundUser);
                db.SaveChanges();
            }
        }

        public Usuario SearchForId(int id)
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                return db.Usuarios.Find(id);
            }
        }

        public Usuario GetPostDetail(int id)
        {
            using (var context = new Killar_GuildContext())
            {
                Usuario registro =
                    context.Usuarios.Where(p => p.Id == id).SingleOrDefault();
                return registro;
            }
        }
    }
}
