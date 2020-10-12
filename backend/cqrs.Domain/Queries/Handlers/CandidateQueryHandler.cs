using cqrs.Domain.Entities;
using cqrs.Domain.Extensions;
using cqrs.Domain.Interfaces;
using cqrs.Domain.Models;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace cqrs.Domain.Queries.Handlers
{
    public class CandidateQueryHandler : IRequestHandler<GetAllCandidateQuery, IEnumerable<MCandidate>>
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateQueryHandler(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<IEnumerable<MCandidate>> Handle(GetAllCandidateQuery query, CancellationToken cancellationToken)
        {
            IEnumerable<Candidate> candidates = await _candidateRepository.GetAll();

            return candidates
                .Select(c => c.ToModel())
                .OrderBy(c => c.Nome);
        }
    }
}
