using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SmartSafeControll.Controllers
{
    public class SmartSafe : Controller
    {
        
          public IActionResult Home()
        {
            return View();
        }

         public IActionResult Digicode()
        {
            return View();
        }

         public IActionResult About()
        {
            return View();
        }
      
    }
}