using cqrs.Domain.Entities;
using cqrs.Domain.Models;

namespace cqrs.Domain.Extensions
{
    public static class CandidateExtension
    {
        public static MCandidate ToModel(this Candidate candidate)
        {
            return new MCandidate
            {
                Nome = candidate.Nome,
                Telefone = candidate.Telefone,
                UrlLinkedin = candidate.UrlLinkedin,
                UsuarioGithub = candidate.UsuarioGithub
            };
        }
    }
}
