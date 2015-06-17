define('SearchDataModel', [], function () {

    return function SearchDataModel(scenarioId) {

        var self = this;
        const getAllStoresUrl = '/Home/GetAllStoresList';
        const getAllArticlesUrl = '/Home/GetAllArticlesList';
        const getAllArticlesByIdUrl = '/Home/GetAllArticlesListByStoreId?store='

        // GET AJAX Call
        var ajaxGet = function (url, params) {
            if (params) {
                return $.ajax(url, {
                    data: ko.toJSON(params),
                    contentType: 'application/json',
                    type: 'GET'
                });
            }
            else {
                return $.get(url);
            }
        };

        // POST AJAX Call
        var ajaxPost = function (url, params) {
            return $.ajax(url, {
                data: ko.toJSON(params),
                contentType: 'application/json',
                type: 'POST'
            });
        };

        // Get all Articles
        self.getAllArticles= function () {
            return ajaxGet(getAllArticlesUrl);
        };


        // Get all Articles
        self.getAllArticlesByStoreId = function (storeId) {
            return ajaxGet(getAllArticlesByIdUrl + storeId);
        };

        // Get all stores
        self.getAllStores = function () {
            return ajaxGet(getAllStoresUrl);
        };
    };
});
