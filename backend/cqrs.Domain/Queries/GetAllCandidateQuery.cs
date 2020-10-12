using cqrs.Domain.Models;
using MediatR;
using System.Collections.Generic;

namespace cqrs.Domain.Queries
{
    public class GetAllCandidateQuery : IRequest<IEnumerable<MCandidate>>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string UrlLinkedin { get; set; }
        public string UsuarioGithub { get; set; }
    }
}
