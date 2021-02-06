using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic constraint - kısıt
    //class : referans tip
    //IEntity : IEntity veya implemente eden nesne.
    //new(): new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class, IEntity, new() //Generics, ne verirsen o gelir
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null); //null: filte vermeye de bilirsin.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
