namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Shared;

    public class Vehicle : Entity
    {
        private string _registrationNumber;
        private VehicleModel _model;
        private string _color;
        private long _currentKM;

        protected Vehicle()
        {
        }

        public Vehicle(string registrationNumber, VehicleModel model, string color, long currentKM = 0)
        {
            _registrationNumber = registrationNumber;
            _model = model;
            _color = color;
            _currentKM = currentKM;
        }

        public new virtual string Code
        {
            get { return _registrationNumber; }
            protected set { _registrationNumber = value; }
        }

        public virtual string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        public virtual VehicleModel Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public virtual string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public virtual long CurrentKM
        {
            get { return _currentKM; }
            set { _currentKM = value; }
        }

        public override string ToString()
        {
            return RegistrationNumber;
        }
    }
}