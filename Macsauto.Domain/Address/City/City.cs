namespace Macsauto.Domain
{
    public class City : Entity
    {
        private string _name;        
        private Province _province;

        public new virtual int Id { get; protected set; }

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