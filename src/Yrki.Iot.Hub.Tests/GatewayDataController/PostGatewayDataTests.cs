using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Yrki.IoT.Contracts;

namespace Yrki.Iot.Hub.Tests.GatewayController
{
    public class PostGatewayDataTests
    {
        [Fact]
        public async Task SuccessfulResponse()
        {
            // Arrange
            var sut = GatewayControllerFactory.Create();

            var request = new WMBusMessage()
            {
                GatewayId = Guid.NewGuid().ToString(),
                HexMessage = "0F0F0F",
                ReceivedAtGatewayDateTime = DateTimeOffset.Now
            };

            // Act
            var result = await sut.PostGatewayData(request);

            // Assert
            result.Should().BeOfType<OkResult>();
        }


       
    }
}
