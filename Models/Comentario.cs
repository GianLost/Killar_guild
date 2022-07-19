using System;

namespace Killar_Guild.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        public string Autor { get; set; }

        public string Conteudo { get; set; }

        public DateTime DataComent { get; set; }

        public int PostId { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        public Post Post { get; set; }
    }
}
