using FinanceHub.API.Models;

namespace FinanceHub.API.Repositories
{
    public interface IInvestmentRepository
    {
        IEnumerable<Investment> GetAll();
        Investment? GetById(int id);
        void Add(Investment investment);
        void Update(Investment investment);
        void Delete(int id);
    }
} 