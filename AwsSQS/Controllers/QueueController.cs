using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwsSQS.Models;
using AwsSQS.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AwsSQS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueueController : ControllerBase
    {
        private readonly ILogger<QueueController> logger;
        private readonly ISqsService sqsService;

        public QueueController(ILogger<QueueController> logger, ISqsService sqsService) {
            this.logger = logger;
            this.sqsService = sqsService;
        }

        [HttpPost]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(TicketRequest request)
        {
            var response = await sqsService.SendMessageToSqsQueue(request);
            if (response == null) {
                return BadRequest();
            }
            return Ok();
        }
    }
}
