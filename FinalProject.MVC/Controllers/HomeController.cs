using FinalProject.BL.Services.Concretes;

namespace FinalProject.MVC.Controllers;
public class HomeController : Controller
{
    /*private readonly ProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService;
    }*/
    public IActionResult Index()
    {
        return View();
    }
}
