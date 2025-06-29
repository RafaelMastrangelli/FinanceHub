using FinanceHub.API.Models;

namespace FinanceHub.API.Mappers
{
    public static class InvestmentMapper
    {
        public static InvestmentDto ToDto(Investment investment) => new InvestmentDto
        {
            Name = investment.Name,
            Amount = investment.Amount,
            Date = investment.Date
        };
        public static Investment ToEntity(InvestmentDto dto) => new Investment
        {
            Name = dto.Name,
            Amount = dto.Amount,
            Date = dto.Date
        };
    }
} 