using Mfund.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Mfund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrokerageCalculatorController : ControllerBase
    {
        private readonly BrokerageCalculatorService _brokerageCalculatorService;

        public BrokerageCalculatorController(BrokerageCalculatorService brokerageCalculatorService)
        {
            _brokerageCalculatorService = brokerageCalculatorService;
        }
        [HttpPost("BrokageCalculator")]
        public async Task<IActionResult> BrokageCalculatorAsync()
        {
            try
            {
                var result = await _brokerageCalculatorService.BrokageCalculatorAsync();
                return Ok(result);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
