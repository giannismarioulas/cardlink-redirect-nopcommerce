using Nop.Core.Configuration;

namespace Payments.Cardlink
{
    public class CardlinkSettings : ISettings
    {
        public string MerchantId { get; set; }
        public string SharedSecret { get; set; }
        public string PaymentUrl { get; set; }
    }
}
