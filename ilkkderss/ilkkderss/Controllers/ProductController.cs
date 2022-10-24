using ilkkderss.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ilkkderss.Controllers
{
    public class ProductController : Controller
    {
        //ACTION TURLERI DONUS TIPLERI

        /*
       
         Bildiğiniz üzere clientten gelen requestleri controlerımız karsılayıp
        uygun actiona yonlendırmekteydı...
         Actionda ihtiyacımıza göre operasyonu yönetiyordu
         İşte bu durumlarda metodumuzun farklı türleri olabilmekte....
         
         
         */

        //JSON TİPİ DONÜŞ
        #region JsonResult
        public JsonResult GetProducts()
        {


            JsonResult result = Json(new Product

            {
                Id= 1,
                ProductName ="IPHONE",
                ProductPrice = 150


            });
            
            
            
            
            return result;

        }
        #endregion

        //ACTİOIN RESULT TİPİ DÖNÜŞ VE VERİ LİSTELEME(VİEWBAG,DATA ETC)
        public IActionResult Index()
        {

            var products = new List<Product>
            {


                new Product { Id= 1, ProductName ="SAMSUNG",ProductPrice =160},
                new Product { Id= 2, ProductName ="VESTEL",ProductPrice=120},
                new Product { Id= 3, ProductName ="NOKİA",ProductPrice=150}


            };


        

            #region VİEWBAG

            //Taşınacak olan veriyi dinamik bir şekilde almamızı sağlayan yapıdır(değişkenle)

            ViewBag.products = products;

            #endregion

            #region ViEWDATA
            //Bu yapıda viewbag gibi veri taşımamıza yarar.Ancak farklı olarak boxing ve unboxing işlemleri vardır


            ViewData["products"]=products;  



            #endregion




            return View();
        }


        /*EKRANA SAYFAYI TAŞIYAN DEFAULTUNDA GET OLAN ALTTAKI ACTİONIM*/
        public IActionResult CreateProduct()
        { 
            return View();
        
        }
        /*BU YAPI İSE KULLANICIDAN PARAMETRELERLE VERİLERİ KARŞILADI*/
        [HttpPost]
        public IActionResult CreateProduct(string txtName,string txtProductPrice)
        {
            return View();

        }

    }
}
