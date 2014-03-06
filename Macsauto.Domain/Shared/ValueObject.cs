namespace Macsauto.Domain.Shared
{
    using System;
    using System.Linq;

    public class ValueObject<TValueObject> : IEquatable<TValueObject>
        where TValueObject : ValueObject<TValueObject>
    {
        #region Methods (IEquatable)

        public virtual bool Equals(TValueObject other)
        {
            if ((object) other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            var publicProperties = GetType().GetProperties();

            if (publicProperties.Any())
            {
                return publicProperties.All(p =>
                {
                    var left = p.GetValue(this, null);
                    var right = p.GetValue(other, null);

                    if (left is TValueObject)
                    {
                        return ReferenceEquals(left, right);
                    }

                    return left.Equals(right);
                });
            }

            return this == other;
        }

        #endregion

        #region Methods (Overrides)

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;

            var item = obj as ValueObject<TValueObject>;

            if (item == null) return false;

            return Equals((TValueObject)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return GetType().GetHashCode();
            }
        }

        public static bool operator ==(ValueObject<TValueObject> left, ValueObject<TValueObject> right)
        {
            return Equals(left, null) ? Equals(right, null) : left.Equals(right);
        }

        public static bool operator !=(ValueObject<TValueObject> left, ValueObject<TValueObject> right)
        {
            return !(left == right);
        }

        #endregion
    }
}
