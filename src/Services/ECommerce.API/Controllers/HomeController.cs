using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Home() => Redirect("/swagger");
    }
}
