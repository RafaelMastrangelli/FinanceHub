using FluentValidation;

namespace FinanceHub.API.DTOs
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Usuário é obrigatório");
        }
    }
    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Usuário é obrigatório");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Senha é obrigatória");
        }
    }
} 