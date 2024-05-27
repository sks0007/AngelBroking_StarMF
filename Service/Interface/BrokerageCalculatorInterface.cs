using Mfund.Model;

namespace Mfund.Service.Interface
{
    public interface BrokerageCalculatorInterface
    {
        Task<BrokerageCalculator> BrokageCalculatorAsync();

    }
}
