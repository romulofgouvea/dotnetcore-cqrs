using cqrs.Domain.Entities;
using System.Threading.Tasks;

namespace cqrs.Domain.Interfaces
{
    public interface ICandidateRepository : IRepository<Candidate>
    {
        Task<Candidate> GetByName(string name);
    }
}