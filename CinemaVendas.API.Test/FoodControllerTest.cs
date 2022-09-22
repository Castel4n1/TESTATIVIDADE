using CinemaVendas.API.Controllers;
using CinemaVendas.Core.Models;
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
    public class FoodControllerTest
    {
        Mock<IFoodService> mockService;

        FoodController foodController;

        public FoodControllerTest()
        {
            mockService = new Mock<IFoodService>();
            foodController = new FoodController(mockService.Object);
        }
        
        [Fact]
        public void GetFoodSold_WithData_ReturnOkResult()
        {
            //arrange
            mockService.Setup(service => service.GetAllSold())
                .Returns(new List<FoodItem>()
                { 
                    new FoodItem(){ID = 999, Name = "Food A"},
                    new FoodItem(){ID = 587, Name = "Food B"}
                });
            //act
            var result = foodController.GetTickets();
            //assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var foodItems = Assert.IsType<List<FoodItem>>(okResult.Value);
            Assert.Equal(2, foodItems.Count);
        }

        [Fact]
        public void GetFoodSold_WithoutData_ReturnOkResult()
        {
            //arrange
            mockService.Setup(service => service.GetAllSold())
                .Returns(new List<FoodItem>());
              
            //act
            var result = foodController.GetTickets();
            //assert
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
            var foodItems = Assert.IsType<List<FoodItem>>(notFoundResult.Value);
            Assert.Empty(foodItems);
        }       

        
    }
}
