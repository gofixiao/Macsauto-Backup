namespace Macsauto.Domain.Sales.PointRedemption
{
    public class PointRedemptionItem : ValueObject<PointRedemptionItem>
    {
        private PointRedemption _pointRedemption;
        private Merchandise.Merchandise _merchandise;
        private long _quantity;

        protected PointRedemptionItem()
        {
        }

        public PointRedemptionItem(PointRedemption pointRedemption, Merchandise.Merchandise merchandise, long quantity)
        {
            _pointRedemption = pointRedemption;
            _merchandise = merchandise;
            _quantity = quantity;
        }

        public virtual PointRedemption PointRedemption
        {
            get { return _pointRedemption; }
            protected set { _pointRedemption = value; }
        }

        public virtual Merchandise.Merchandise Merchandise
        {
            get { return _merchandise; }
            protected set { _merchandise = value; }
        }

        public virtual long Quantity
        {
            get { return _quantity; }
            protected set { _quantity = value; }
        }
    }
}