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

        public void EditUser(Usuario userEdit)
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                Usuario u = db.Usuarios.Find(userEdit.Id);
                u.Nome = userEdit.Nome;
                u.DataNasc = userEdit.DataNasc;
                u.WhatsPub = userEdit.WhatsPub;
                u.EmailPub = userEdit.EmailPub;
                u.NickWr = userEdit.NickWr;
                u.LoginNamePub = userEdit.LoginNamePub;
                u.SenhaPub = Criptografia.TextoCriptografado(userEdit.SenhaPub);
                u.CheckSenhaPub = userEdit.CheckSenhaPub;
                u.Lane = userEdit.Lane;
                u.Elo = userEdit.Elo;
                u.Tipo = userEdit.Tipo;

                db.SaveChanges();
            }
        }

        public void DelUser(int id)
        {
            using (Killar_GuildContext db = new Killar_GuildContext())
            {
                Usuario foundUser = db.Usuarios.Find(id);
                db.Usuarios.Remove (foundUser);
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
