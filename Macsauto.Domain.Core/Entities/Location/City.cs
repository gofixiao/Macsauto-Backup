using System;

namespace Macsauto.Domain.Core.Entities.Location
{
    public class City : Entity<City, Guid>, IAggregateRoot
    {
        private string _name;        
        private Province _province;

        public virtual Province Province
        {
            get { return _province; }
            protected set { _province = value; }
        }

        public virtual string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public City(string name, Province province)
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