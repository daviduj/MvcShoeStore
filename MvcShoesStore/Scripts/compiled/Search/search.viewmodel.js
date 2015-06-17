define('Search', ['Base', 'SearchDataModel', 'LoadStoreViewModel'], function (base, searchDatamodel, LoadStoreViewModel) {

    var $container;
    $container = $(".tabs");
    base.activeTabs($container);

    function StoresViewModel(dataModel, LoadStoreViewModel) {
        var self = this;

        //Properties
        self.allStoresTab = ko.observable(null);
        self.allStoresTab(new LoadStoreViewModel(self, dataModel));

        self.allArticlesTab = ko.observable(null);
        self.allArticlesTab(new LoadStoreViewModel(self, dataModel));

        self.allArticlesByStoreTab = ko.observable(null);
        self.allArticlesByStoreTab(new LoadStoreViewModel(self, dataModel));

        self.inputValueSearch = ko.observable("");

        var StoreModel = function (base) {
            var self = this;
            self.StoreId = base.Id.toString();
            self.StoreName = ko.observable(base.Name);
            self.StoreAddress = ko.observable(base.Address);
            self.StoreDescription = ko.observable("");
        };

        var ArticleModel = function (base) {
            var self = this;
            self.ArticleId = base.Id.toString();
            self.ArticleName = ko.observable(base.Name);
            self.ArticleDescription = ko.observable(base.Description);
            self.ArticlePrice = ko.observable(base.Price);
            self.ArticleStoreName = ko.observable(base.StoreName)
            self.ArticleTotalShelf = ko.observable(base.TotalShelf);
            self.ArticleTotalVault = ko.observable(base.TotalVault);
        };

        dataModel.getAllStores()
                 .done(function (resultJson) {
                     self.allStoresTab().allStoresList(mapModel(resultJson));
                 });

        dataModel.getAllArticles()
                 .done(function (resultJson) {
                     self.allArticlesTab().allArticlesList(mapArticleModel(resultJson));
                 });

        self.searchStore = function () {
            if (self.inputValueSearch().trim().length > 0 && !isNaN(parseInt(self.inputValueSearch()))) {
                dataModel.getAllArticlesByStoreId(parseInt(self.inputValueSearch()))
                 .done(function (resultJson) {
                     debugger
                     self.inputValueSearch("");
                     self.allArticlesByStoreTab().allArticlesListByStore(mapArticleModel(resultJson.response));
                 });
            }
        }

        var mapModel = function (resultJson) {
            var models = _.map(resultJson, function (item) {
                return new StoreModel(item);
            });
            return models
        }

        var mapArticleModel = function (resultJson) {
            var models = _.map(resultJson, function (item) {
                return new ArticleModel(item);
            });
            return models
        }
    }

    var viewModel = new StoresViewModel(new searchDatamodel(), LoadStoreViewModel);
    ko.applyBindings(viewModel);
});
