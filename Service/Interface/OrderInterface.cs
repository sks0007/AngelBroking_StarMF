using Mfund.Model;

namespace Mfund.Service.Interface
{
    public interface OrderInterface
    {
        Task<OrderPlaceOrder> PlaceOrderAsync();

        Task<OrderModifyOrder> ModifyOrderAsync();

        Task<OrderCancelOrder> CancelOrderAsync();

        Task<OrderGetOrderBook> GetOrderBookAsync();  
        
        Task<OrderGetTradeBook> GetTradeBookAsync();

        Task<OrderGetLtpData> GetLTPDataAsync();

        Task<OrderIndividualOrderStatus> IndividualOrderStatusAsync();

    }
}
