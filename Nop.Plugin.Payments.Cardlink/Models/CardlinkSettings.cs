using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.CardlinkRedirectRedirect.Models;

public class CardlinkSettings : ISettings
{
    public string MerchantId { get; set; }
    public string SharedSecretKey { get; set; }
    public string PaymentUrl { get; set; }
    public bool UseSandbox { get; set; }
}
