using System;
using System.Collections.Generic;

namespace Killar_Guild.Models
{
    public class Usuario
    {
        public static int ADMIN = 0;

        public static int PADRAO = 1;

        public int Id { get; set; } // primary key por convenção

        public string Nome { get; set; }

        public DateTime DataNasc { get; set; }

        private string Whats { get; set; }

        private string Email { get; set; }

        public string NickWr { get; set; }

        private string LoginName { get; set; }

        private string Senha { get; set; }

        private string CheckSenha { get; set; }

        public string Lane { get; set; }

        public string Elo { get; set; }

        public int Tipo { get; set; }

        public ICollection<Post> ListPost { get; set; } // lista de post

        public ICollection<Comentario> ListComent { get; set; } // Lista de comentários

        public Usuario()
        {
        }

        public string WhatsPub
        {
            set
            {
                Whats = value;
            }
            get
            {
                return Whats;
            }
        }

        public string EmailPub
        {
            set
            {
                Email = value;
            }
            get
            {
                return Email;
            }
        }

        public string LoginNamePub
        {
            set
            {
                LoginName = value;
            }
            get
            {
                return LoginName;
            }
        }

        public string SenhaPub
        {
            set
            {
                Senha = value;
            }
            get
            {
                return Senha;
            }
        }

        public string CheckSenhaPub
        {
            set
            {
                CheckSenha = value;
            }
            get
            {
                return CheckSenha;
            }
        }
    }
}
