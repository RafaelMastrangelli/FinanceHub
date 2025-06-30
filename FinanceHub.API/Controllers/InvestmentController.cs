using Microsoft.AspNetCore.Mvc;
using FinanceHub.API.Services;
using FinanceHub.API.Models;

namespace FinanceHub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestmentController : ControllerBase
    {
        private readonly InvestmentService _service;
        public InvestmentController(InvestmentService service)
        {
            _service = service;
        }
        
    }
} 