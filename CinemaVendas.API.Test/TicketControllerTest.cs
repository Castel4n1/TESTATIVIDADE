using CinemaVendas.API.Controllers;
using CinemaVendas.Core.Models;
using CinemaVendas.Core.Repositories.Interfaces;
using CinemaVendas.Core.Services;
using CinemaVendas.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CinemaVendas.API.Test
{
    public class TicketControllerTest
    {
        Mock<ITicketService> mockService;
        TicketController ticketController;

        public TicketControllerTest()
        {
            mockService = new Mock<ITicketService>();
            ticketController = new TicketController(mockService.Object);
        }

        [Fact]
        public void GetFoodSold_WithOutData_ReturnOkResult()
        {
            //arrange
            mockService.Setup(service => service.GetAllSold())
                .Returns(new List<Ticket>()
                {
                    new Ticket(){ID = 999, MovieName = "Capitao Caverna"},
                    new Ticket(){ID = 587, MovieName = "Homem das Neves"}
                });
            //act
            var result = ticketController.GetTickets();
            //assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var foodItems = Assert.IsType<List<FoodItem>>(okResult.Value);
            Assert.Equal(2, foodItems.Count);
        }
    }
    

      
}
