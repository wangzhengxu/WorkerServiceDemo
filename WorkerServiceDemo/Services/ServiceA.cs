using Microsoft.Extensions.Logging;

namespace WorkerServiceDemo.Services
{
    public class ServiceA:IService
    {
        private readonly ILogger<ServiceA> _logger;

        public ServiceA(ILogger<ServiceA>logger)
        {
            _logger = logger;
        }
        public void Run()
        {
            _logger.LogInformation("Service A is running");
        }
    }
}