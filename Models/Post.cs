using System;
using System.Collections.Generic;

namespace Killar_Guild.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Texto { get; set; }

        public DateTime DataPost { get; set; }

        public ICollection<Comentario> Comentarios { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
