using CinemaVendas.Core.Models;
using CinemaVendas.Core.Repositories.Interfaces;
using CinemaVendas.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVendas.Core.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepo;

        public TicketService(ITicketRepository ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }

        public List<Ticket> GetAllSold() => _ticketRepo.GetAllSold();
    }
}
