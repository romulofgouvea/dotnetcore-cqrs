using MediatR;
using cqrs.Domain.Commands.Response;

namespace cqrs.Domain.Commands.Requests
{
    public class CreateCandidateCommandRequest : IRequest<CreateCandidateCommandResponse>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string UrlLinkedin { get; set; }
        public string UsuarioGithub { get; set; }
    }
}