using Macsauto.Domain.Shared;

namespace Macsauto.Domain.SalesModule
{
    public class ProductCategory : Entity
    {
        private string _name;
        private string _description;
        private ProductCategory _parentCategory;

        protected ProductCategory()
        {
        }

        public ProductCategory(string code, string name, string description)
        {
            _code = code;
            _name = name;
            _description = description;
        }

        public ProductCategory(string code, string name, string description, ProductCategory parentCategory)
        {
            _code = code;
            _name = name;
            _description = description;
            _parentCategory = parentCategory;
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public virtual ProductCategory ParentCategory
        {
            get { return _parentCategory; }
            set { _parentCategory = value; }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}