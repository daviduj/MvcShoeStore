using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfShoesStore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Store> GetAllListStores();

        [OperationContract]
        List<Article> GetAllListArticles();

        [OperationContract]
        List<Article> GetAllListArticlesByStoreId(int storeId);

        [OperationContract]
        bool CreateStore(int Id, string Name, string Description, string Address);

        [OperationContract]
        bool CreateArticle(int Id, string Name, string Description, decimal Price, int TotalVault, int TotalShelf, string StoreName, int storeId);

        [OperationContract]
        bool UpdateStore(StoresNames storeId);

        [OperationContract]
        bool UpdateArticle(int articleId);

        [OperationContract]
        bool DeleteStore(StoresNames storeId);

        [OperationContract]
        bool DeleteArticle(int articleId);
    }
}
