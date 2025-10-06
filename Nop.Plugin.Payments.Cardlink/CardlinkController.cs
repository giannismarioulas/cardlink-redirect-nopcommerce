using Microsoft.AspNetCore.Mvc;

namespace Payments.Cardlink.Controllers
{
    public class CardlinkController : Controller
    {
        public IActionResult Configure()
        {
            return View("~/Plugins/Payments.Cardlink/Views/Configure.cshtml");
        }
    }
}
