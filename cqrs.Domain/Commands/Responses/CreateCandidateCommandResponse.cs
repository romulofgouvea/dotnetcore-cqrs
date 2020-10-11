
using System;

namespace cqrs.Domain.Commands.Response
{
    public class CreateCandidateCommandResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string UrlLinkedin { get; set; }
        public string UsuarioGithub { get; set; }
    }
}