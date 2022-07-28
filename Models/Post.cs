using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Killar_Guild.Models
{
    public class Post
    {
        public int Id { get; set; } // primary key 

        public string Titulo { get; set; }

        public string Texto { get; set; }

        public DateTime DataPost { get; set; }

        public ICollection<Comentario> Comentarios { get; set; } // lista de comentários que um post terá.

        public int UsuarioId { get; set; } // foreign key

        public Usuario Usuario { get; set; }

    }
}
