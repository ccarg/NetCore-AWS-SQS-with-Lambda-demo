using Amazon.SQS.Model;
using AwsSQS.Models;
using System.Threading.Tasks;

namespace AwsSQS.Services
{
    public interface ISqsService
    {
        Task<SendMessageResponse> SendMessageToSqsQueue(TicketRequest request);
    }
}
