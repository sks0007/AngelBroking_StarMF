using Mfund.Service;
using Microsoft.AspNetCore.Mvc;

namespace Mfund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _ordererService;  

        public OrderController(OrderService ordererService)
        {
            _ordererService = ordererService;
        }

        [HttpPost("Order/placeOrder")]

        public async Task<IActionResult> PlaceOrderAsync()
        {
            try
            {
                var result = await _ordererService.PlaceOrderAsync();
                return Ok(result);  
            }
            catch (Exception ex) {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }

        [HttpPost("Order/modifyOrder")]
        public async Task<IActionResult> ModifyOrderAsync()
        {
            try
            {
                var result = await _ordererService.ModifyOrderAsync();
                return Ok(result);
            }
            catch (Exception ex) {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }

        }

        [HttpPost("Order/cancelOrder")]

        public async Task<IActionResult> CancelOrderAsync()
        {
            try
            {
                var result = await _ordererService.CancelOrderAsync();
                return Ok(result);  
            }
            catch (Exception ex) 
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("Order/GetorderBook")]

        public async Task<IActionResult> GetOrderBookAsync()
        {
            try
            {
                var result = await _ordererService.GetOrderBookAsync();
                return Ok(result);  

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("Order/getTradeBook")]

        public async Task<IActionResult> GetTradeBookAsync()
        {
            try
            {
                var result = await _ordererService.GetTradeBookAsync();
                return Ok(result);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost("Order/getLtpData")]

        public async Task<IActionResult> GetLTPDataAsync()
        {
            try
            {
                var result = await _ordererService.GetLTPDataAsync();
                return Ok(result);
            }
            catch(Exception ex) {
                return StatusCode(500, $"Internal Server Error:{ex.Message}" ); 
            }
        }

        [HttpGet("order/IndividualOrderStatusAsyn")]

        public async Task<IActionResult> IndividualOrderStatusAsync()
        {
            try
            {
                var result = await _ordererService.IndividualOrderStatusAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
