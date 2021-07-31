using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        // Arrange
        WeatherForecastController weatherForecastController= new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            //Act
            var result= weatherForecastController.FetchData(1);
            //Assert
            Assert.Equal("Chandrashekhar",result);
        }
    }
}
