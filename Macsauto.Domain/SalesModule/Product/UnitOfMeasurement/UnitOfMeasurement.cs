using Macsauto.Domain.Shared;

namespace Macsauto.Domain.SalesModule
{
    /// <summary>
    /// Represents an unit of measurement (UOM) used across the system.
    /// Examples : Cm, M, Kg, Pcs
    /// </summary>
    public class UnitOfMeasurement : Entity
    {
        private string _description;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">UOM name, will be used as code</param>
        /// <param name="description">UOM description</param>
        public UnitOfMeasurement(string name, string description) : base(name)
        {
            _description = description;
        }

        /// <summary>
        /// UOM name (equal to code)
        /// </summary>
        public virtual string Name
        {
            get { return base.Code; }
        }

        /// <summary>
        /// UOM description
        /// </summary>
        public virtual string Description
        {
            get { return _description; }
            protected set { _description = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
