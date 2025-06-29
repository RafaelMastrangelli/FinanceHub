using FinanceHub.API.Models;

namespace FinanceHub.API.Repositories
{
    public class InvestmentRepository : IInvestmentRepository
    {
        private readonly List<Investment> _investments = new();
        public IEnumerable<Investment> GetAll() => _investments;
        public Investment? GetById(int id) => _investments.FirstOrDefault(i => i.Id == id);
        public void Add(Investment investment) => _investments.Add(investment);
        public void Update(Investment investment)
        {
            var existing = GetById(investment.Id);
            if (existing != null)
            {
                existing.Name = investment.Name;
                existing.Amount = investment.Amount;
                existing.Date = investment.Date;
            }
        }
        public void Delete(int id)
        {
            var investment = GetById(id);
            if (investment != null)
                _investments.Remove(investment);
        }
    }
} 