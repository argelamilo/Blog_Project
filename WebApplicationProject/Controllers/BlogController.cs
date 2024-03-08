using System.Web.Mvc;

namespace WebApplicationProject.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult BlogEntries()
        {
            return View();
        }

        public ActionResult PostDetails()
        {
            return View();
        }
    }
}