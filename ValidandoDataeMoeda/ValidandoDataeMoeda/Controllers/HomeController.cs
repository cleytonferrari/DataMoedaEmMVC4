using System.Web.Mvc;
using ValidandoDataeMoeda.Models;

namespace ValidandoDataeMoeda.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Produto produto)
        {
            return View(produto);
        }

    }
}
