using System;

namespace cqrs.Domain.Entities
{
    public class Candidate : BaseEntity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string UrlLinkedin { get; set; }
        public string UsuarioGithub { get; set; }
    }
}