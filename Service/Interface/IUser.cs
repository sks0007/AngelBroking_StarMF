using Mfund.Model;

namespace MutualFund.Service.Interface
{
    public interface IUser
    {
        Task<LoginServices> LoginAsync();
        Task<Token> TokenAsync();

        Task<GetProfile> GetProfileAsync();

        Task<GetRMS> GetRMSAsync();

        Task<logOut> logOutAsync();

    }
}
