using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;
using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Querying;


namespace BLL
{
    public class BaseHandler
    {
        private bool isTransaction = false;

        protected void BeginOperation()
        {
            isTransaction = true;
        }

        protected void EndOperation()
        {
            Repository.Uow.SaveChanges();
            isTransaction = false;
        }

        protected void Add(Entity entity)
        {
            Repository.Uow.Add(entity);
            if (!isTransaction)
                Repository.Uow.SaveChanges();
        }

        protected void Add<TEntity>(IList<TEntity> entityList) where TEntity : Entity
        {
            foreach (TEntity entity in entityList)
            {
                Repository.Uow.Add(entity);
            }
            if (!isTransaction)
                Repository.Uow.SaveChanges();
        }

        protected void Update(Entity entity, int id)
        {
            Query query = new Query { EntityType = entity.GetType(), QueryExpression = Entity.Attribute("Id") == id };
            Repository.Uow.Update(query, entity);
            if (!isTransaction)
                Repository.Uow.SaveChanges();
        }

        /// <summary>
        /// Delete the entity by query directly instead of fetching the entity first and remove from repository
        /// </summary>
        /// <param name="entityType">Type of the entity</param>
        /// <param name="id">Id of the entity</param>

        protected void DeleteWithoutFetch(Type entityType, int id)
        {
            Query query = new Query { EntityType = entityType, QueryExpression = Entity.Attribute("Id") == id };
            Repository.Uow.Remove(query);
            if (!isTransaction)
                Repository.Uow.SaveChanges();
        }

        /// <summary>
        /// Delete the entity by fetching the entity first, this ensure cascading delete to work properly
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="id"></param>
        protected void Delete(Type entityType, int id)
        {
            Entity entity = Repository.Uow.FindById(entityType, id);
            Repository.Uow.Remove(entity);
            if (!isTransaction)
                Repository.Uow.SaveChanges();
        }

        protected void DeleteBy(Type entityType, string fieldName, object fieldValue)
        {
            Query query = new Query { EntityType = entityType, QueryExpression = Entity.Attribute(fieldName) == fieldValue };
            Repository.Uow.Remove(query);
            if (!isTransaction)
                Repository.Uow.SaveChanges();
        }

        protected IList<TEntity> GetList<TEntity>() where TEntity : Entity
        {
            return Repository.Uow.Find<TEntity>();
        }

        protected IList<TEntity> GetListBy<TEntity>(string fieldName, object fieldValue) where TEntity : Entity
        {
            Query query = new Query { EntityType = typeof(TEntity), QueryExpression = Entity.Attribute(fieldName) == fieldValue };
            return Repository.Uow.Find<TEntity>(query);
        }

        public void SaveChanges()
        {
            Repository.Uow.SaveChanges();
        }
    }
}
