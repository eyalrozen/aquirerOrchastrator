using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Orchestrator.Infrastructure.Events
{
    public class AzureServiceBusPublisher : IEventPublisher
    {
        private readonly ServiceBusClient _client;

        public AzureServiceBusPublisher(ServiceBusClient client)
        {
            _client = client;
        }

        public async Task PublishAsync<TEvent>(TEvent @event, string topicOrQueueName) where TEvent : class
        {
            var sender = _client.CreateSender(typeof(TEvent).Name);
            var message = new ServiceBusMessage(JsonSerializer.Serialize(@event));
            await sender.SendMessageAsync(message);
        }
    }

}
