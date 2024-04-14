using Microsoft.AspNetCore.Mvc;
namespace InvoicingApp.UI.Controllers;

[Route("")]
public class HomeController : Controller
{
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }  
}