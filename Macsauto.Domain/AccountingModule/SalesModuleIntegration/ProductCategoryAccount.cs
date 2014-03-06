using Macsauto.Domain.SalesModule;

namespace Macsauto.Domain.AccountingModule.SalesModuleIntegration
{
    public class ProductCategoryAccount
    {
        private Account _account;
        private ProductCategory _productCategory;

        public ProductCategoryAccount()
        {
            
        }

        public virtual Account Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public virtual ProductCategory ProductCategory
        {
            get { return _productCategory; }
            set { _productCategory = value; }
        }
    }
}
