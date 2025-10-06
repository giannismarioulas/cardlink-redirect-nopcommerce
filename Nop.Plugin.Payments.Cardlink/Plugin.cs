using System.Threading.Tasks;
using Nop.Services.Configuration;
using Nop.Services.Plugins;
using Nop.Plugin.Payments.CardlinkRedirectRedirect.Settings;

namespace Nop.Plugin.Payments.CardlinkRedirectRedirect;

public class Plugin : BasePlugin
{
    private readonly ISettingService _settingService;

    public Plugin(ISettingService settingService)
    {
        _settingService = settingService;
    }

    public override async Task InstallAsync()
    {
        var settings = new CardlinkPaymentSettings
        {
            MerchantId = "",
            SharedSecret = "",
            UseSandbox = true,
            PaymentUrlSandbox = "https://ecommerce-test.cardlink.gr/vpos/shophandlermpi",
            PaymentUrlProduction = "https://ecommerce.cardlink.gr/vpos/shophandlermpi",
            SuccessUrl = "Checkout/Completed",
            FailureUrl = "Checkout/Completed"
        };

        await _settingService.SaveSettingAsync(settings);
        await base.InstallAsync();
    }

    public override async Task UninstallAsync()
    {
        await _settingService.DeleteSettingAsync<CardlinkPaymentSettings>();
        await base.UninstallAsync();
    }
}
