using Microsoft.AspNetCore.Mvc;
using Nop.Services.Configuration;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Plugin.Payments.CardlinkRedirectRedirect.Models;
using System.Threading.Tasks;

namespace Nop.Plugin.Payments.CardlinkRedirectRedirect.Controllers;

[Area("Admin")]
public class CardlinkController : BasePluginController
{
    private readonly ISettingService _settingService;

    public CardlinkController(ISettingService settingService)
    {
        _settingService = settingService;
    }

    [HttpGet]
    public async Task<IActionResult> ConfigureAsync()
    {
        var settings = await _settingService.LoadSettingAsync<CardlinkSettings>();

        return View("~/Plugins/Payments.CardlinkRedirect/Views/Configure.cshtml", settings);
    }

    [HttpPost]
    public async Task<IActionResult> ConfigureAsync(CardlinkSettings model)
    {
        if (!ModelState.IsValid)
            return View("~/Plugins/Payments.CardlinkRedirect/Views/Configure.cshtml", model);

        await _settingService.SaveSettingAsync(model);

        ViewBag.Message = "Settings saved successfully!";
        return View("~/Plugins/Payments.CardlinkRedirect/Views/Configure.cshtml", model);
    }
}
