using FinanceHub.API.Models;
using FinanceHub.API.Repositories;

namespace FinanceHub.API.UseCases
{
    public class GetInvestmentSummaryUseCase
    {
        private readonly IInvestmentRepository _repository;
        public GetInvestmentSummaryUseCase(IInvestmentRepository repository)
        {
            _repository = repository;
        }
        public decimal Execute()
        {
            return _repository.GetAll().Sum(i => i.Amount);
        }
    }
} 