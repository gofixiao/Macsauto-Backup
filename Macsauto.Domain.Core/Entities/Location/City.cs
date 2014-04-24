namespace Macsauto.Domain.Core.Location.City
{
    public class City : Entity
    {
        private string _name;        
        private Province.Province _province;

        public virtual Province.Province Province
        {
            get { return _province; }
            protected set { _province = value; }
        }

        public virtual string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public City(string name, Province.Province province)
        {
            _name = name;
            _province = province;
        }

        protected City(){}

        public override string ToString()
        {
            return _name;
        }
    }
}