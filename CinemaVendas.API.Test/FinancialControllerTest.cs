using CinemaVendas.API.Controllers;
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
    public class FinancialControllerTest
    {
        private Mock<IFinancialsService> _mockService;
        private FinancialController _controller;



        public FinancialControllerTest()
        {
            _mockService = new Mock<IFinancialsService>();
            _controller = new FinancialController(_mockService.Object);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(31.6)]
        [InlineData(-31.6)]
        [InlineData(-1)]
        public void GetTotalSold_HasAmout_ReturnOkResult(decimal total)
        {
            //Arrange
            _mockService.Setup(service => service.GetTotalSold()).Returns(total);
            //ACT
            var result = _controller.GetTotalSold();
            //ASSERT
            var okResult = Assert.IsType<OkObjectResult>(result);
            var numbers = Assert.IsType<Decimal>(okResult.Value);
    
        }
    }
}
