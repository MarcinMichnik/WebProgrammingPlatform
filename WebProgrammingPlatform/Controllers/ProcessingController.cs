using Microsoft.AspNetCore.Mvc;
using WebProgrammingPlatform.Models;

namespace WebProgrammingPlatform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessingController : ControllerBase
    {
        private readonly ILogger<ProcessingController> _logger;

        public ProcessingController(ILogger<ProcessingController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ProcessingResponse Post([FromBody] ProcessingRequest processingRequest)
        {
            return new ProcessingResponse()
            {
                ResponseContent = processingRequest.ContentToBeProcessed
            };
        }
    }
}