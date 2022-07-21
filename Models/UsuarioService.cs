using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Killar_Guild.Models
{
    public class UsuarioService
    {
        private const string DadosConexao = "Server=localhost;DataBase=DbKillarGuild;Uid=root;";
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

        public List<Usuario> Profile(int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            List<Usuario> ListaDeUsuarios = new List<Usuario>();

            String Query = "";
            if (Id > 0)
            {
                Query = "SELECT * FROM Usuarios WHERE Id=" + Id;
            }
            else
            {
                Query = "SELECT * FROM Usuarios";
            }


            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();


            while (Reader.Read())
            {

                Usuario UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                UsuarioEncontrado.DataNasc = Reader.GetDateTime("DataNasc");

                if (!Reader.IsDBNull(Reader.GetOrdinal("WhatsPub")))
                {
                    UsuarioEncontrado.WhatsPub = Reader.GetString("WhatsPub");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("EmailPub")))
                {
                    UsuarioEncontrado.EmailPub = Reader.GetString("EmailPub");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("NickWr")))
                {
                    UsuarioEncontrado.NickWr = Reader.GetString("NickWr");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("LoginNamePub")))
                {
                    UsuarioEncontrado.LoginNamePub = Reader.GetString("LoginNamePub");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("SenhaPub")))
                {
                    UsuarioEncontrado.SenhaPub = Reader.GetString("SenhaPub");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("CheckSenhaPub")))
                {
                    UsuarioEncontrado.CheckSenhaPub = Reader.GetString("CheckSenhaPub");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Lane")))
                {
                    UsuarioEncontrado.Lane = Reader.GetString("Lane");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Elo")))
                {
                    UsuarioEncontrado.Elo = Reader.GetString("Elo");
                }

                UsuarioEncontrado.Tipo = Reader.GetInt32("Tipo");

                ListaDeUsuarios.Add(UsuarioEncontrado);

            }

            Conexao.Close();

            return ListaDeUsuarios;
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
