﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcShoesStore.ShoesStoreServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Store", Namespace="http://schemas.datacontract.org/2004/07/WcfShoesStore")]
    [System.SerializableAttribute()]
    public partial class Store : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcShoesStore.ShoesStoreServiceReference.Article[] ArticlesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MvcShoesStore.ShoesStoreServiceReference.Article[] Articles {
            get {
                return this.ArticlesField;
            }
            set {
                if ((object.ReferenceEquals(this.ArticlesField, value) != true)) {
                    this.ArticlesField = value;
                    this.RaisePropertyChanged("Articles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Article", Namespace="http://schemas.datacontract.org/2004/07/WcfShoesStore")]
    [System.SerializableAttribute()]
    public partial class Article : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StoreNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalShelfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalVaultField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StoreName {
            get {
                return this.StoreNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StoreNameField, value) != true)) {
                    this.StoreNameField = value;
                    this.RaisePropertyChanged("StoreName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalShelf {
            get {
                return this.TotalShelfField;
            }
            set {
                if ((this.TotalShelfField.Equals(value) != true)) {
                    this.TotalShelfField = value;
                    this.RaisePropertyChanged("TotalShelf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalVault {
            get {
                return this.TotalVaultField;
            }
            set {
                if ((this.TotalVaultField.Equals(value) != true)) {
                    this.TotalVaultField = value;
                    this.RaisePropertyChanged("TotalVault");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StoresNames", Namespace="http://schemas.datacontract.org/2004/07/WcfShoesStore")]
    public enum StoresNames : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Zapateria_del_Norte = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Zapateria_del_Sur = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Zapateria_del_Central = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Zapateria_del_Oeste = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShoesStoreServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllListStores", ReplyAction="http://tempuri.org/IService/GetAllListStoresResponse")]
        MvcShoesStore.ShoesStoreServiceReference.Store[] GetAllListStores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllListStores", ReplyAction="http://tempuri.org/IService/GetAllListStoresResponse")]
        System.Threading.Tasks.Task<MvcShoesStore.ShoesStoreServiceReference.Store[]> GetAllListStoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllListArticles", ReplyAction="http://tempuri.org/IService/GetAllListArticlesResponse")]
        MvcShoesStore.ShoesStoreServiceReference.Article[] GetAllListArticles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllListArticles", ReplyAction="http://tempuri.org/IService/GetAllListArticlesResponse")]
        System.Threading.Tasks.Task<MvcShoesStore.ShoesStoreServiceReference.Article[]> GetAllListArticlesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllListArticlesByStoreId", ReplyAction="http://tempuri.org/IService/GetAllListArticlesByStoreIdResponse")]
        MvcShoesStore.ShoesStoreServiceReference.Article[] GetAllListArticlesByStoreId(int storeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllListArticlesByStoreId", ReplyAction="http://tempuri.org/IService/GetAllListArticlesByStoreIdResponse")]
        System.Threading.Tasks.Task<MvcShoesStore.ShoesStoreServiceReference.Article[]> GetAllListArticlesByStoreIdAsync(int storeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateStore", ReplyAction="http://tempuri.org/IService/CreateStoreResponse")]
        bool CreateStore(int Id, string Name, string Description, string Address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateStore", ReplyAction="http://tempuri.org/IService/CreateStoreResponse")]
        System.Threading.Tasks.Task<bool> CreateStoreAsync(int Id, string Name, string Description, string Address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateArticle", ReplyAction="http://tempuri.org/IService/CreateArticleResponse")]
        bool CreateArticle(int Id, string Name, string Description, decimal Price, int TotalVault, int TotalShelf, string StoreName, int storeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateArticle", ReplyAction="http://tempuri.org/IService/CreateArticleResponse")]
        System.Threading.Tasks.Task<bool> CreateArticleAsync(int Id, string Name, string Description, decimal Price, int TotalVault, int TotalShelf, string StoreName, int storeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStore", ReplyAction="http://tempuri.org/IService/UpdateStoreResponse")]
        bool UpdateStore(MvcShoesStore.ShoesStoreServiceReference.StoresNames storeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStore", ReplyAction="http://tempuri.org/IService/UpdateStoreResponse")]
        System.Threading.Tasks.Task<bool> UpdateStoreAsync(MvcShoesStore.ShoesStoreServiceReference.StoresNames storeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateArticle", ReplyAction="http://tempuri.org/IService/UpdateArticleResponse")]
        bool UpdateArticle(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateArticle", ReplyAction="http://tempuri.org/IService/UpdateArticleResponse")]
        System.Threading.Tasks.Task<bool> UpdateArticleAsync(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteStore", ReplyAction="http://tempuri.org/IService/DeleteStoreResponse")]
        bool DeleteStore(MvcShoesStore.ShoesStoreServiceReference.StoresNames storeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteStore", ReplyAction="http://tempuri.org/IService/DeleteStoreResponse")]
        System.Threading.Tasks.Task<bool> DeleteStoreAsync(MvcShoesStore.ShoesStoreServiceReference.StoresNames storeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteArticle", ReplyAction="http://tempuri.org/IService/DeleteArticleResponse")]
        bool DeleteArticle(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteArticle", ReplyAction="http://tempuri.org/IService/DeleteArticleResponse")]
        System.Threading.Tasks.Task<bool> DeleteArticleAsync(int articleId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MvcShoesStore.ShoesStoreServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MvcShoesStore.ShoesStoreServiceReference.IService>, MvcShoesStore.ShoesStoreServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MvcShoesStore.ShoesStoreServiceReference.Store[] GetAllListStores() {
            return base.Channel.GetAllListStores();
        }
        
        public System.Threading.Tasks.Task<MvcShoesStore.ShoesStoreServiceReference.Store[]> GetAllListStoresAsync() {
            return base.Channel.GetAllListStoresAsync();
        }
        
        public MvcShoesStore.ShoesStoreServiceReference.Article[] GetAllListArticles() {
            return base.Channel.GetAllListArticles();
        }
        
        public System.Threading.Tasks.Task<MvcShoesStore.ShoesStoreServiceReference.Article[]> GetAllListArticlesAsync() {
            return base.Channel.GetAllListArticlesAsync();
        }
        
        public MvcShoesStore.ShoesStoreServiceReference.Article[] GetAllListArticlesByStoreId(int storeId) {
            return base.Channel.GetAllListArticlesByStoreId(storeId);
        }
        
        public System.Threading.Tasks.Task<MvcShoesStore.ShoesStoreServiceReference.Article[]> GetAllListArticlesByStoreIdAsync(int storeId) {
            return base.Channel.GetAllListArticlesByStoreIdAsync(storeId);
        }
        
        public bool CreateStore(int Id, string Name, string Description, string Address) {
            return base.Channel.CreateStore(Id, Name, Description, Address);
        }
        
        public System.Threading.Tasks.Task<bool> CreateStoreAsync(int Id, string Name, string Description, string Address) {
            return base.Channel.CreateStoreAsync(Id, Name, Description, Address);
        }
        
        public bool CreateArticle(int Id, string Name, string Description, decimal Price, int TotalVault, int TotalShelf, string StoreName, int storeId) {
            return base.Channel.CreateArticle(Id, Name, Description, Price, TotalVault, TotalShelf, StoreName, storeId);
        }
        
        public System.Threading.Tasks.Task<bool> CreateArticleAsync(int Id, string Name, string Description, decimal Price, int TotalVault, int TotalShelf, string StoreName, int storeId) {
            return base.Channel.CreateArticleAsync(Id, Name, Description, Price, TotalVault, TotalShelf, StoreName, storeId);
        }
        
        public bool UpdateStore(MvcShoesStore.ShoesStoreServiceReference.StoresNames storeId) {
            return base.Channel.UpdateStore(storeId);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateStoreAsync(MvcShoesStore.ShoesStoreServiceReference.StoresNames storeId) {
            return base.Channel.UpdateStoreAsync(storeId);
        }
        
        public bool UpdateArticle(int articleId) {
            return base.Channel.UpdateArticle(articleId);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateArticleAsync(int articleId) {
            return base.Channel.UpdateArticleAsync(articleId);
        }
        
        public bool DeleteStore(MvcShoesStore.ShoesStoreServiceReference.StoresNames storeId) {
            return base.Channel.DeleteStore(storeId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteStoreAsync(MvcShoesStore.ShoesStoreServiceReference.StoresNames storeId) {
            return base.Channel.DeleteStoreAsync(storeId);
        }
        
        public bool DeleteArticle(int articleId) {
            return base.Channel.DeleteArticle(articleId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteArticleAsync(int articleId) {
            return base.Channel.DeleteArticleAsync(articleId);
        }
    }
}
