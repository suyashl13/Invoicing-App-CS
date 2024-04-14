using Microsoft.AspNetCore.Mvc;

namespace InvoicingApp.UI.Controllers;

[Route("[controller]")]
public class ErrorController : Controller
{
    [Route("")]
    public IActionResult Index()
    {
        return View("Index");
    }
}