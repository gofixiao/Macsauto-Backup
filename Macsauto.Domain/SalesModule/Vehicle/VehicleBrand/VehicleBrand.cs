namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Shared;

    public class VehicleBrand : Entity
    {
        private string _name;

        protected VehicleBrand()
        {
        }

        public VehicleBrand(string code, string name)
        {
            _code = code;
            _name = name;
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}