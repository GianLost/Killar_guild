using System;

namespace Killar_Guild.Models
{
    public class Comentario
    {
        public int Id { get; set; } // primary key

        public string Autor { get; set; }

        public string Conteudo { get; set; }

        public DateTime DataComent { get; set; }

        public int PostId { get; set; } // foreign key

        public int UsuarioId { get; set; } // foreign key

        public Usuario Usuario { get; set; }

        public Post Post { get; set; }
    }
}
