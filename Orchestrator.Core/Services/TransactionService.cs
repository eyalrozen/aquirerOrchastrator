using Orchestrator.Infrastructure.Events;
using Orchestrator.Shared.EventModels;
using Orchestrator.Shared.HttpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IEventPublisher _eventPublisher;

        public TransactionService(IEventPublisher eventPublisher)
        {
            _eventPublisher = eventPublisher;
        }

        public async Task ProcessTransactionAsync(TransactionRequest request)
        {
            var transactionId = Guid.NewGuid().ToString();

            await _eventPublisher.PublishAsync(new RequestReceived
            {
                TransactionId = transactionId,
                PSPId = request?.Identification?.PspId,
                PayloadSummary = request?.Summary
            },"topic");

            // Additional logic here for mapping and further processing
        }
    }

}
