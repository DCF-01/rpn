using Microsoft.AspNetCore.Mvc;

namespace RPNCalculator.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Calc([FromQuery] string op)
    {
        return Ok(new {result = op});
    }
}