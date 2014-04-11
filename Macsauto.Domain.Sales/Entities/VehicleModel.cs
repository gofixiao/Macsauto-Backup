namespace Macsauto.Domain.Sales.Entities
{
    public class VehicleModel : Entity
    {
        private string _name;
        private VehicleBrand _brand;
        private VehicleSize _size;
        private VehicleType _type;

        public VehicleModel(string code, string name, VehicleBrand brand, VehicleSize size, VehicleType type) : base(code)
        {
            _name = name;
            _brand = brand;
            _size = size;
            _type = type;
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual VehicleBrand Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public virtual VehicleSize Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public virtual VehicleType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}