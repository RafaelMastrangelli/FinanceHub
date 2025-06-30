namespace FinanceHub.API.DTOs
{
    public class UserDto
    {
        public string Username { get; set; } = string.Empty;
    }
    public class LoginDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
} 