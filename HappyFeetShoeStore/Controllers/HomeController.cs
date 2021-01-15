using HappyFeetShoeStore.Data;
using HappyFeetShoeStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Helpers;

namespace HappyFeetShoeStore.Controllers
{
    public class HomeController : Controller
    {
        private HappyFeetShoeStoreContext db = new HappyFeetShoeStoreContext();
        public async Task<ActionResult> Index()
        {
            var topSellers = (from topProducts in db.OrderLines
                              where (topProducts.ProductID != null)
                              group topProducts by topProducts.Product into topGroup
                              select new BestSellersViewModel
                              {
                                  Product = topGroup.Key,
                                  SalesCount = topGroup.Sum(o => o.Quantity),
                                  ProductImage = topGroup.Key.ProductImageMappings.
                              OrderBy(pim
                               =>
                              pim.ImageNumber).FirstOrDefault().ProductImage.FileName
                              }).OrderByDescending(tg => tg.SalesCount).Take(4);
            return View(await topSellers.ToListAsync());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}