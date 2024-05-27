using Mfund.Service;
using Microsoft.AspNetCore.Mvc;
using MutualFund.Service;

namespace Mfund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GTTController : ControllerBase
    {
        private readonly GTTService _gttService;    

        public GTTController(GTTService gttService)
        {
            _gttService = gttService;
        }

        [HttpPost("GTT/CreateRule")]

        public async Task<IActionResult> GTTCreateRuleAsync()
        {
            try
            {
                var result = await _gttService.GTTCreateRuleAsync();
                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");

            }
        }

        [HttpPost("GTT/ModifyRule")]

        public async Task<IActionResult> GTTModifyRuleAsync()
        {
            try
            {
                var result = await _gttService.GTTModifyRuleAsync();
                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");

            }
        }

        [HttpPost("GTT/CancelRule")]
        public async Task<IActionResult> GTTCancelRuleAsync()
        {
            try
            {
                var result = await _gttService.GTTCancelRuleAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }

        [HttpPost("GTT/RuleDetails")]

        public async Task<IActionResult> GTTRuleDetailsAsync()
        {
            try
            {
                var result = await _gttService.GTTRuleDetailsAsync();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return StatusCode(500,$"Internal Server Error:{ex.Message}" );
            }
        }

        [HttpPost("GTT/RuleList")]

        public async Task<IActionResult> GTTRuleListAsync()
        {
            try
            {
                var result = await _gttService.GTTRuleListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }


    }
}
