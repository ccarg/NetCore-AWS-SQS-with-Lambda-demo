using System;
using System.Text.Json;

namespace AwsSQS.Models
{
    public class TicketRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public string Serialize() {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, options);
        }
    }
}
