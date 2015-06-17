using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcShoesStore.ShoesStoreServiceReference;
using Newtonsoft.Json;
using MvcShoesStore.Helpers;
using MvcShoesStore.Constants;
using MvcShoesStore.Models;

namespace MvcShoesStore.Controllers
{
    public class HomeController : Controller
    {
        private ShoesStoreServiceReference.ServiceClient repostory = new ShoesStoreServiceReference.ServiceClient();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllStoresList()
        {
            var response = repostory.GetAllListStores();
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllArticlesList()
        {
            var response = repostory.GetAllListArticles();
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllArticlesListByStoreId(int store)
        {

            try
            {
                var response = repostory.GetAllListArticlesByStoreId(store);

                if (response.Any())
                {
                    return Json(new { response = response, success = true, total_element = response.Count() }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = true, total_element = 0 }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, total_element = 0 , error = ex.Message}, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpGet]
        public ActionResult CreateStore()
        {
            ViewBag.Message = "Create Store";
            var store = new Store();
            return View(store);
        }

        [HttpPost]
        public ActionResult CreateStore(Store store)
        {
            ViewBag.Message = "Create Store";
            var response = repostory.CreateStore(store.Id, store.Name, string.Empty, store.Address);
            return Redirect("/");
        }

        [HttpGet]
        public ActionResult CreateArticle()
        {
            ViewBag.Message = "Create Article";
            var stores = GetAllStores();
            var article = new ArticleViewModel();
            article.StoreIds = GetSelectListItems(stores);
            return View(article);
        }

        [HttpPost]
        public ActionResult DeleteArticle(ArticleViewModel store)
        {
            var response = repostory.DeleteArticle(store.Id);
            return Redirect("/");
        }

        [HttpGet]
        public ActionResult DeleteArticle(int id)
        {
            ViewBag.Message = "Create Article";
            var article = new ArticleViewModel();
            return View(article);
        }

        [HttpPost]
        public ActionResult CreateArticle(ArticleViewModel article)
        {
            var stores = GetAllStores();
            article.StoreIds = GetSelectListItems(stores);
            var idStore = 0;
            for (int i = 0; i < article.StoreIds.Count(); i++)
            {
                if (article.StoreIds.Where(x => x.Value == article.Name).Any())
                {
                    idStore = i ;
                }
            }
            var response = repostory.CreateArticle(article.Id, article.Name, article.Description, article.Price, article.TotalVault, article.TotalShelf, article.StoreName, idStore);
            return Redirect("/");
        }

        private IEnumerable<string> GetAllStores()
        {
            var stores = repostory.GetAllListStores().ToList();
            List<string> names = new List<string>();
            foreach (var item in stores)
            {
                names.Add(item.Name);
            }
            return names;
        }

        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {

            var selectList = new List<SelectListItem>();

            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }

            return selectList;
        }
    }
}