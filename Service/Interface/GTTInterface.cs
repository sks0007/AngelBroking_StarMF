using Mfund.Model;

namespace Mfund.Service.Interface
{
    public interface GTTInterface
    {
        Task<GTTCreateRule> GTTCreateRuleAsync();

        Task<GTTModifyRule> GTTModifyRuleAsync();

        Task<GTTCancelRule> GTTCancelRuleAsync();

        Task<GTTRuleDetails> GTTRuleDetailsAsync();

        Task<GTTRuleList> GTTRuleListAsync();
    }
}
