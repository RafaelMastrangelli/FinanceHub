namespace FinanceHub.API.Models
{
    public class InvestmentDto
    {
        public string Name { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
} 