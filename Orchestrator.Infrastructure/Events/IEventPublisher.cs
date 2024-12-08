using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator.Infrastructure.Events
{
    public interface IEventPublisher
    {
        /// <summary>
        /// Publishes an event to the message broker.
        /// </summary>
        /// <typeparam name="TEvent">The type of the event to be published.</typeparam>
        /// <param name="event">The event to publish.</param>
        /// <param name="topicOrQueueName">The name of the topic or queue where the event should be published.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task PublishAsync<TEvent>(TEvent @event, string topicOrQueueName) where TEvent : class;
    }
}
