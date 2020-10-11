using cqrs.Domain.Entities;
using cqrs.Domain.Interfaces;
using cqrs.Infra.Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace cqrs.Infra.Data.Repository
{
    public class CandidateRepository : BaseRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(CqrsContext context) : base(context)
        {
        }

        public async Task<Candidate> GetByName(string nome)
        {
            Candidate data = GetAll().Result.FirstOrDefault(c => c.Nome == nome);

            return await Task.FromResult(data);
        }
    }
}
