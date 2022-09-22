using CinemaVendas.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaVendas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public IActionResult GetTickets()
        {
            return Ok(_ticketService.GetAllSold());
        }
    }
}
