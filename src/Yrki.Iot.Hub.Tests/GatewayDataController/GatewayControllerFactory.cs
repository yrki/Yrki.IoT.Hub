using Microsoft.Extensions.Logging;
using Moq;
using Yrki.IoT.Hub.Controllers;

namespace Yrki.Iot.Hub.Tests.GatewayController
{
    public static class GatewayControllerFactory
    {
        public static GatewayDataController Create()
        {
            var logger = new Mock<ILogger<GatewayDataController>>();
            return new GatewayDataController(logger.Object);
        }
    }
}
