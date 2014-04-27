namespace Macsauto.Domain.Core.Entities.Location    
{
    public class Address : ValueObject<Address>
    {
        private City _city;
        private string _zipcode;
        private string _addressLine;

        public Address(City city, string zipcode, string addressLine)
        {
            _city = city;
            _zipcode = zipcode;
            _addressLine = addressLine;
        }

        public virtual City City
        {
            get { return _city; }
            protected set { _city = value; }
        }

        public virtual string Zipcode
        {
            get { return _zipcode; }
            protected set { _zipcode = value; }
        }

        public virtual string AddressLine
        {
            get { return _addressLine; }
            protected set { _addressLine = value; }
        }

        public override string ToString()
        {
            if (_addressLine == null || _city == null)
            {
                return string.Empty;
            }
            
            return _addressLine + @", " + _city + @", " + _city.Province + @", " + _zipcode;
        }
    }
}