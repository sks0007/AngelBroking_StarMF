using Mfund.Service;
using Microsoft.AspNetCore.Mvc;

namespace Mfund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly PortfolioService _portfolioService;

        public PortfolioController(PortfolioService portfolioService)
        {
            _portfolioService = portfolioService;   
        }

        [HttpGet("portfolio/getHoldings")]
        public async Task<IActionResult> GetHoldingAsync()
        {
            try
            {
                var result = await _portfolioService.GetHoldingAsync();
                return Ok(result);
            }
            catch (Exception ex) { 
                 return StatusCode(500, $"Internal Server Error: {ex.Message}");            
            }
        }

        [HttpGet("portfolio/getAllHoldings")]

        public async Task<IActionResult> GetAllHoldingsAsync()
        {
            try
            {
                var result = await _portfolioService.GetAllHoldingsAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }

        [HttpGet("portfolio/getPosition")]

        public async Task<IActionResult> GetPositionAsync()
        {
            try
            {
                var result = await _portfolioService.GetPositionAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }

        [HttpPost("convertPosition")]

        public async Task<IActionResult> ConvertPositionAsync()
        {
            try
            {
                var result = await _portfolioService.ConvertPositionAsync();
                return Ok(result);  
            }
            catch(Exception ex) { 
                return StatusCode(500,$"Internal Server Error:{ex.Message}" );  
            }
        }
    }
}
