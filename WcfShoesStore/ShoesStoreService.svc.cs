using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfShoesStore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShoesStoreBasicService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShoesStoreBasicService.svc or ShoesStoreBasicService.svc.cs at the Solution Explorer and start debugging.
    public class ShoesStoreBasicService : IService
    {
        public List<Store> GetAllListStores() 
        {
            var allStoresList = new List<Store>();
            using (StoresInventory context = new StoresInventory())
            {
                context.Configuration.ProxyCreationEnabled = false;
                foreach (Store_tbl s in context.Store_tbl.Include("Article_tbl").ToList())
                    allStoresList.Add(new Store { Id = s.Id, Address = s.Address, Name = s.Name });
            }
            return allStoresList;
        }

        public List<Article> GetAllListArticles()
        {
            var allArticles = new List<Article>();
            using (StoresInventory context = new StoresInventory())
            {
                context.Configuration.ProxyCreationEnabled = false;
                foreach (Article_tbl a in context.Article_tbl.Include("Store_tbl").ToList())
                    allArticles.Add(new Article { Id = a.Id
                                                , Name = a.Name
                                                , Description = a.Description
                                                , Price = a.Price
                                                , TotalShelf = a.TotalShelf
                                                , TotalVault = a.TotalVault
                                                , StoreName = a.Store_tbl.Name
                    });
            }
            return allArticles;
        }

        public List<Article> GetAllListArticlesByStoreId(int storeId)
        {
            var allArticles = new List<Article>();

            using (StoresInventory context = new StoresInventory())
            {
                context.Configuration.ProxyCreationEnabled = false;
                foreach (Article_tbl a in context.Article_tbl.Include("Store_tbl")
                                                 .Where(article => article.StoreId == storeId)
                                                 .ToList())
                    allArticles.Add(new Article
                    {
                        Id = a.Id
                    ,
                        Name = a.Name
                    ,
                        Description = a.Description
                    ,
                        Price = a.Price
                    ,
                        TotalShelf = a.TotalShelf
                    ,
                        TotalVault = a.TotalVault
                    ,
                        StoreName = a.Store_tbl.Name
                    });
            }
            return allArticles;
        }

        public bool CreateStore(int Id, string Name, string Description, string Address) 
        {
            using (StoresInventory context = new StoresInventory())
            {
                try
                {
                    var newId = context.Store_tbl.OrderByDescending(x => x.Id).FirstOrDefault();
                    context.Store_tbl.Add(new Store_tbl() { Id = (newId.Id + 1), Name = Name, Address = Address });
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool CreateArticle(int Id, string Name, string Description, decimal Price, int TotalVault, int TotalShelf, string StoreName, int storeId) 
        {
            using (StoresInventory context = new StoresInventory())
            {
                try
                {
                    context.Article_tbl.Add(new Article_tbl() { Id = Id
                                                              , Name = Name
                                                              , Description = Description
                                                              , Price = Price
                                                              , StoreId = storeId
                                                              , TotalShelf = TotalShelf
                                                              , TotalVault = TotalVault
                    });
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }


        public bool UpdateStore(StoresNames storeId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateArticle(int articleId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStore(StoresNames storeId)
        {
            using (StoresInventory context = new StoresInventory())
            {
                // See if we have it.
                var storeToDelete = (from s in context.Store_tbl where s.Id == (int)storeId select s).FirstOrDefault();

                if (storeToDelete != null)
                {
                    context.Store_tbl.Remove(storeToDelete);
                    context.SaveChanges();
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }

        public bool DeleteArticle(int articleId)
        {
            using (StoresInventory context = new StoresInventory())
            {
                // See if we have it.
                var articleToDelete = (from a in context.Article_tbl where a.Id == articleId select a).FirstOrDefault();

                if (articleToDelete != null)
                {
                    context.Article_tbl.Remove(articleToDelete);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
