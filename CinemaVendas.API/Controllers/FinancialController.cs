using CinemaVendas.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaVendas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialController : ControllerBase
    {
        private readonly IFinancialsService _financialService;

        public FinancialController(IFinancialsService financialsService)
        {
            _financialService = financialsService;
        }

        [HttpGet("Total")]
        public IActionResult GetTotalSold()
        {
            return Ok(_financialService.GetTotalSold());
        }

        [HttpGet("Stats")]
        public IActionResult GetStats()
        {
            return Ok(_financialService.GetStats());
        }
    }
}
