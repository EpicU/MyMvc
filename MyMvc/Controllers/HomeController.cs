using MyMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvc.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        public IEnumerable<NewsItem> NewsItems
        {
            get
            {
                var items = new List<NewsItem>();
                for (var i = 0; i < 10; i++)
                {
                    items.Add(new NewsItem
                    {
                        Id = i,
                        Title = "My Title " + i,
                        Body = "My Body " + i
                    });
                }
                return items;
            }
        }



        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("news")]
        public ActionResult NewsList()
        {
            return View(NewsItems);
        }

        [Route("news/{id:int}")]
        public ActionResult NewsDetail(int id)
        {
            var item = NewsItems.FirstOrDefault(c => c.Id == id);

            return View(item);
        }
    }
}