using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Payments.CardlinkRedirect.Components;

[ViewComponent(Name = "Cardlink")]
public class CardlinkViewComponent : NopViewComponent
{
    public IViewComponentResult Invoke(string widgetZone, object additionalData)
    {
        ArgumentNullException.ThrowIfNull(widgetZone);
        ArgumentNullException.ThrowIfNull(additionalData);
        // Εδώ εμφανίζεται το PaymentInfo.cshtml
        return View("~/Plugins/Payments.Cardlink/Views/PaymentInfo.cshtml");
    }
}
