using Microsoft.AspNetCore.Mvc;

namespace NLU_Aggregator.Controllers
{
    public class JSONNLPController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}