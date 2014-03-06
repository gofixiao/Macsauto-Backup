using Macsauto.Domain.Shared;

namespace Macsauto.Domain.SalesModule
{
    public class ServiceCategory : Entity
    {
        private string _name;
        private string _description;
        private ServiceCategory _parentCategory;

        protected ServiceCategory()
        {
        }

        public ServiceCategory(string code, string name, string description)
        {
            _code = code;
            _name = name;
            _description = description;
        }

        public ServiceCategory(string code, string name, string description, ServiceCategory parentCategory)
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

        public virtual ServiceCategory ParentCategory
        {
            get { return _parentCategory; }
            set { _parentCategory = value; }
        }
    }
}