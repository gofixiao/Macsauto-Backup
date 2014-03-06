using Macsauto.Domain.Shared;
using NHibernate;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;

namespace Macsauto.Infrastructure.NHibernate.CustomType
{
    using System;
    using System.Data;

    public class GenderType : IUserType
    {
        bool IUserType.Equals(object x, object y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (x == null || y == null) return false;

            return x.Equals(y);
        }

        public int GetHashCode(object x)
        {
            return x == null ? typeof(bool).GetHashCode() + 473 : x.GetHashCode();
        }

        public object NullSafeGet(IDataReader rs, string[] names, object owner)
        {
            var obj = NHibernateUtil.String.NullSafeGet(rs, names[0]);

            if (obj == null) return null;

            var gender = (Gender)obj;

            if (gender != Gender.Male && gender != Gender.Female)
                throw new ApplicationException(string.Format("Expected data to be 'Y' or 'N' but was '{0}'.", gender));

            return gender == Gender.Male;
        }

        public void NullSafeSet(IDbCommand cmd, object value, int index)
        {
            if (value == null)
            {
                ((IDataParameter)cmd.Parameters[index]).Value = DBNull.Value;
            }
            else
            {
                var gender = (Gender)value == Gender.Male ? "M" : "F";

                ((IDataParameter)cmd.Parameters[index]).Value = gender;
            }
        }

        public object DeepCopy(object value)
        {
            return value;
        }

        public object Replace(object original, object target, object owner)
        {
            return original;
        }

        public object Assemble(object cached, object owner)
        {
            return cached;
        }

        public object Disassemble(object value)
        {
            return value;
        }

        public SqlType[] SqlTypes
        {
            get { return new[] {NHibernateUtil.String.SqlType}; }
        }
        
        public Type ReturnedType
        {
            get { return typeof(GenderType); }
        }
        
        public bool IsMutable
        {
            get { return false; }
        }
    }
}