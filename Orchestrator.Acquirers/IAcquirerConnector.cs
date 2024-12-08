using Orchestrator.Shared.HttpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator.Acquirers
{
    public interface IAcquirerConnector
    {
        Task<AcquirerResponse> ProcessTransactionAsync(AcquirerRequest request);
    }
}
