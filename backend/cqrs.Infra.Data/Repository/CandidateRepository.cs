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

        public Task<Candidate> GetByName(string nome)
        {
            return (Task<Candidate>)GetAll().Result.Where(c => c.Nome == nome);
        }
    }
}
