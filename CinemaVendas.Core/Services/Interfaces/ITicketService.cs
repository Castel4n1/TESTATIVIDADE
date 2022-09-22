using CinemaVendas.Core.Models;
using System.Collections.Generic;

namespace CinemaVendas.Core.Services.Interfaces
{
    public interface ITicketService
    {
        List<Ticket> GetAllSold();
    }
}
