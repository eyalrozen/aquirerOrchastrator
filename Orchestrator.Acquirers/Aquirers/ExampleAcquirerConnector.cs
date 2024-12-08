using Orchestrator.Shared.HttpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator.Acquirers.Aquirers
{
    public class ExampleAcquirerConnector : IAcquirerConnector
    {
        public async Task<AcquirerResponse> ProcessTransactionAsync(AcquirerRequest request)
        {
            // Logic for calling the acquirer API
            return new AcquirerResponse { Success = true };
        }
    }
}
