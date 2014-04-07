using Macsauto.Domain;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace Macsauto.Infrastructure.NHibernate.Contract
{
    /// <summary>
    /// Contract for all repository
    /// </summary>
    /// <typeparam name="TEntity">Entity this repository handles</typeparam>
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        #region ReadFunctions

        /// <summary>
        /// Get an entity based on it's id
        /// </summary>
        /// <param name="id">Entity's id</param>
        /// <returns>Entity</returns>
        TEntity Get(object id);

        /// <summary>
        /// Load an entity based on it's id
        /// </summary>
        /// <param name="id">Entity's id</param>
        /// <returns>Entity</returns>
        TEntity Load(object id);

        /// <summary>
        /// Find a single entity based on a criteria
        /// </summary>
        /// <param name="criteria">Criteria</param>
        /// <returns>Entity</returns>
        TEntity FindFirst(DetachedCriteria criteria);

        /// <summary>
        /// Count all entity
        /// </summary>
        /// <returns>Total entity found</returns>
        long Count();

        /// <summary>
        /// Count all entity that fullfil condition
        /// </summary>
        /// <param name="criteria">Criteria</param>
        /// <returns>Total entity found</returns>
        long Count(DetachedCriteria criteria);

        /// <summary>
        /// Check if an entity with given id exists
        /// </summary>
        /// <param name="id">Entity's id</param>
        /// <returns>True if found, otherwise false</returns>
        bool Exists(object id);

        /// <summary>
        /// Check if an entity with given criteria exists
        /// </summary>
        /// <param name="criteria">Criteria</param>
        /// <returns>True if found, otherwise false</returns>
        bool Exists(DetachedCriteria criteria);

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns>List of entities</returns>
        IList<TEntity> GetAll();

        /// <summary>
        /// Get all entities with a given criteria and order
        /// </summary>
        /// <param name="criteria">Criteria</param>
        /// <param name="orders">Orders</param>
        /// <returns>List of entities</returns>
        IList<TEntity> FindAll(DetachedCriteria criteria, params Order[] orders);

        #endregion

        #region TransactionFunctions

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// Delete all entities
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Delete all entities with a given criteria
        /// </summary>
        /// <param name="criteria">Criteria</param>
        void DeleteAll(DetachedCriteria criteria);

        /// <summary>
        /// Save an entity
        /// </summary>
        /// <param name="entity">Entity to save</param>
        /// <returns>Saved entity</returns>
        TEntity Save(TEntity entity);

        /// <summary>
        /// Save or update an entity
        /// </summary>
        /// <param name="entity">Entity to save or update</param>
        /// <returns>Saved or updated entity</returns>
        TEntity SaveOrUpdate(TEntity entity);

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="entity">Entity to update</param>
        void Update(TEntity entity);

        #endregion
    }
}