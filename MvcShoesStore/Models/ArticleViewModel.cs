using MvcShoesStore.ShoesStoreServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcShoesStore.Models
{
    public class ArticleViewModel : Article
    {

        public IEnumerable<SelectListItem> StoreIds { get; set; }
    }
}