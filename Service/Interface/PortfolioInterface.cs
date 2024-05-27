using Mfund.Model;

namespace Mfund.Service.Interface
{
    public interface PortfolioInterface
    {

        Task<PortfolioGetHolding> GetHoldingAsync();

        Task<PortfolioGetAllHoldings> GetAllHoldingsAsync();

        Task<PortfolioGetPosition> GetPositionAsync();

        Task<PortfolioConvertPosition> ConvertPositionAsync();

    }
}
