using FluentValidation;

namespace FinanceHub.API.DTOs
{
    public class InvestmentDtoValidator : AbstractValidator<InvestmentDto>
    {
        public InvestmentDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Nome é obrigatório");
            RuleFor(x => x.Amount).GreaterThan(0).WithMessage("Valor deve ser maior que zero");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Data é obrigatória");
        }
    }
} 