using Mfund.Service;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Mfund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EDIsAPIsController : ControllerBase
    {
        private readonly EDIsAPIsService _edisAPIsService;

        public EDIsAPIsController(EDIsAPIsService eDIsAPIsService)
        {
            _edisAPIsService = eDIsAPIsService;
        }

        [HttpPost("CDSL")]

        public async Task<IActionResult> CDSLAsync()
        {
            try
            {
                var result = await _edisAPIsService.CDSLAsync();
                return Ok(result);  
            }
            catch (Exception ex)
            {
                return StatusCode(500,$"Internal Server Error:{ex.Message}");
            }
        }

        [HttpPost("v1/generateTpin")]

        public async Task<IActionResult> GenerateTPINAsync()
        {
            try
            {
                var result = await _edisAPIsService.GenerateTPINAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500,$"Internal Server Error:{ex.Message}");   
            }
        }

        [HttpPost("v1/GetTransactionStatus")]

        public async Task<IActionResult> GetTransactionStatusAPIAsync()
        {
            try
            {
                var result = await _edisAPIsService.GetTransactionStatusAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }

        }


    }
}
