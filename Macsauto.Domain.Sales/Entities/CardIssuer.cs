namespace Macsauto.Domain.Sales.Entities
{
    public class CardIssuer : Entity
    {
        private string _name;

        protected CardIssuer()
        {
        }

        public CardIssuer(string code, string name)
        {
            _code = code;
            _name = name;
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}