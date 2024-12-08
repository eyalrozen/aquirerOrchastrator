using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator.Shared.EventModels
{
    public class RequestReceived
    {
        public string? TransactionId { get; set; }
        public string? PSPId { get; set; }
        public object? PayloadSummary { get; set; }
    }
}
