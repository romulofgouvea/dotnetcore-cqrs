using cqrs.Domain.Commands.Requests;
using cqrs.Domain.Commands.Response;
using cqrs.Domain.Entities;
using cqrs.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace cqrs.Domain.Handlers
{
    public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommandRequest, CreateCandidateCommandResponse>
    {
        private readonly ICandidateRepository _candidateRepository;

        public CreateCandidateCommandHandler(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<CreateCandidateCommandResponse> Handle(CreateCandidateCommandRequest request, CancellationToken cancellationToken)
        {
            CreateCandidateCommandResponse result = null;

            try
            {
                Candidate candidate = await _candidateRepository.GetByName(request.Nome);

                if (candidate == null)
                {
                    candidate = new Candidate
                    {
                        Id = Guid.NewGuid(),
                        Nome = request.Nome,
                        Telefone = request.Telefone,
                        UrlLinkedin = request.UrlLinkedin,
                        UsuarioGithub = request.UsuarioGithub,
                        Created = DateTime.Now,
                        Updated = DateTime.Now
                    };

                    await _candidateRepository.Add(candidate);
                }
                else
                {
                    candidate.Updated = DateTime.Now;

                    await _candidateRepository.Update(candidate);
                }

                result = new CreateCandidateCommandResponse
                {
                    Id = candidate.Id,
                    Nome = candidate.Nome,
                    Telefone = candidate.Telefone,
                    UrlLinkedin = candidate.UrlLinkedin,
                    UsuarioGithub = candidate.UsuarioGithub
                };

                return await Task.FromResult(result);
            }
            catch (Exception)
            {
                return await Task.FromResult(result);
            }

        }
    }
}