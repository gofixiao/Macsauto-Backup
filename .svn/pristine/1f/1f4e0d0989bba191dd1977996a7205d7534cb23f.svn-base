namespace Macsauto.Domain.Contract
{
    using System.Collections.Generic;
    using Macsauto.Domain.Shared;

    public interface IRepository<T> where T : Entity
    {
        long Count();
        long GetLastDailyIndex();
        T FindById(object id);
        T Insert(T t);
        void Update(T t);
        IList<T> GetAll();
    }
}