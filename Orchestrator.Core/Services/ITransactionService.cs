using Orchestrator.Shared.HttpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator.Core.Services
{
    public interface ITransactionService
    {
        Task ProcessTransactionAsync(TransactionRequest request);
    }
}
