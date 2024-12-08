using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator.Shared.HttpModels
{
    public class TransactionRequest
    {
        public string? PSPId { get; set; }
        public object? Summary { get; set; }
    }
}
