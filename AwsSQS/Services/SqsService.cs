using Amazon.SQS;
using Amazon.SQS.Model;
using AwsSQS.Models;
using System.Threading.Tasks;

namespace AwsSQS.Services
{
    public class SqsService : ISqsService
    {
        public SqsService(IAmazonSQS sqsClient)
        {
            SqsClient = sqsClient;
        }

        public IAmazonSQS SqsClient { get; }

        public async Task<SendMessageResponse> SendMessageToSqsQueue(TicketRequest request)
        {
            var sendMessageRequest = new SendMessageRequest
            {
                //demo
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/.../sqs_name",
                MessageBody = request.Serialize()
            };

            return await SqsClient.SendMessageAsync(sendMessageRequest);
        }

    }
}
