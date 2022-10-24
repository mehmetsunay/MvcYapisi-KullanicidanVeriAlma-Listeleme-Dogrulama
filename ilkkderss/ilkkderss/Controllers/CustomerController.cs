using ilkkderss.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ilkkderss.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MusteriDogrulama()
        {

            return View();

        }


        [HttpPost]
        public IActionResult MusteriDogrulama(Customer model)
        {

            if(!ModelState.IsValid)
            {

                ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;


            }



           return View(model); 

        }
    }
}
