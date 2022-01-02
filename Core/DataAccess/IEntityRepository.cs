using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint
    //IEntiry: IEntity olabilir veya IEntity yi implemente eden bir nesne olabilir.
    //new(): new lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //listeleme
        T Get(Expression<Func<T, bool>> filter); //filtrleme
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeletebyId(T entity);

    }
}