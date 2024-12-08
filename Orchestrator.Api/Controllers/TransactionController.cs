using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orchestrator.Core.Services;
using Orchestrator.Shared.HttpModels;

namespace Orchestrator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        public async Task<IActionResult> ProcessTransaction([FromBody] TransactionRequest request)
        {
            await _transactionService.ProcessTransactionAsync(request);
            return Accepted();
        }
    }
}
