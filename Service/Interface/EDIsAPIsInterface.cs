using Mfund.Model;

namespace Mfund.Service.Interface
{
    public interface EDIsAPIsInterface
    {
        Task<CDSL> CDSLAsync();
        Task<GenerateTPIN> GenerateTPINAsync();

        Task<GetTransactionStatusAPI> GetTransactionStatusAsync();
    }
}
