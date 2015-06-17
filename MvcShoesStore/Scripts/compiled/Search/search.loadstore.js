define("LoadStoreViewModel", [], function () {
	return function LoadStoreViewModel(parent, dataModel) {
		var self = this;

		self.allStoresList = ko.observableArray();
		self.allStoresListWidget = ko.observable();

		self.allArticlesList = ko.observableArray();
		self.allArticlesListWidget = ko.observable();

		self.allArticlesListByStore = ko.observableArray();
		self.allArticlesListByStoreWidget = ko.observable();

		self.allStoresListColumns = [
            { title: 'Id', field: 'StoreId', sortable: true, filterable: true, width: 100, type: "number" },
            { title: 'Name', field: 'StoreName()', width: 250, sortable: true, filterable: true },
            { title: 'Address', field: 'StoreAddress()', width: 150, sortable: false, filterable: true},
			{ title: 'Description ', field: 'StoreDescription()', sortable: true, filterable: false}
		];

		self.allArticlesListColumns = [
		    { title: 'Article Id', field: 'ArticleId', sortable: true, filterable: true, width: 100 },
            { title: 'Name', field: 'ArticleName()', width: 250, sortable: true, filterable: true },
            { title: 'Description', field: 'ArticleDescription()', width: 150, sortable: false, filterable: true },
			{ title: 'Price ', field: 'ArticlePrice()', sortable: true, filterable: false },
			{ title: 'Store Location', field: 'ArticleStoreName()', sortable: true, filterable: true, width: 100},
            { title: 'Total Shelf', field: 'ArticleTotalShelf()', width: 150, sortable: false, filterable: true },
			{ title: 'Total Vault ', field: 'ArticleTotalVault()', sortable: true, filterable: false },
		];

	}
});
