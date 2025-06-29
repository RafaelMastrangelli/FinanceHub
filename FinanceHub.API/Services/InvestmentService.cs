using FinanceHub.API.Models;
using FinanceHub.API.Repositories;

namespace FinanceHub.API.Services
{
    public class InvestmentService
    {
        private readonly IInvestmentRepository _repository;
        public InvestmentService(IInvestmentRepository repository)
        {
            _repository = repository;
        }
        // Adicione métodos de negócio aqui
    }
} 