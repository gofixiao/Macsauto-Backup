namespace Macsauto.Domain.Sales.Entities
{
    public class CardIssuer : Entity
    {
        private string _name;

        public CardIssuer(string name) : base(name)
        {
            _name = name;
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}