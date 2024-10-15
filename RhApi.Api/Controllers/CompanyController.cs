using Microsoft.AspNetCore.Mvc;

namespace RhApi.Api.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
